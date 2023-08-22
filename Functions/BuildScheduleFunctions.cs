using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace ScheduleBuilder
{
    public static class BuildScheduleFunctions
    {
        public static IWebDriver AfekaLogin(string username, string password)
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("headless");
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            service.SuppressInitialDiagnosticInformation = true;

            IWebDriver driver;
            driver = new ChromeDriver(service, options)
            {
                Url = "https://sso.afeka.ac.il/my.policy"
            };
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement element = driver.FindElement(By.Id("input_1"));
            element.SendKeys(username);
            element = driver.FindElement(By.Id("input_2"));
            element.SendKeys(password);
            element = driver.FindElement(By.Id("submit_row"));
            element.Submit();
            element = driver.FindElement(By.Id("/Common/Yedion"));
            element.Click();
            driver = ClosePrevWindow(ref driver);

            element = driver.FindElement(By.XPath("//*[@id=\"myTable120\"]/tbody/tr[1]/td/a"));
            element.Click();
            driver = ClosePrevWindow(ref driver);
            return driver;
        }

        private static IWebDriver ClosePrevWindow(ref IWebDriver driver)
        {
            driver.Close();
            List<string> windows_lst = driver.WindowHandles.ToList();
            driver.SwitchTo().Window(windows_lst.Last());
            return driver;
        }

        public static void GetAllData(ref IWebDriver driver, ref List<Course> courses, string year, string semester)
        {
            foreach (var course in courses)
            {
                GoToPage(ref driver, year, semester, course);
                GetCourseName(ref driver, course);
                GetCourseTest(ref driver, course);

                IWebElement element = driver.FindElement(By.XPath("//*[@id=\"kt_content\"]/div/div[2]/div/div/div/form/table/tbody/tr[2]/td")); // tags main cointaner
                List<IWebElement> tags = new List<IWebElement>(element.FindElements(By.XPath("*")));                                            // all children tags

                Dictionary<string, Instance> linker = new Dictionary<string, Instance>();

                for (int i = 1; i < tags.Count(); i += 4)
                {
                    GetTypeGroupID(tags.ElementAt(i), out int type, out string groupID);

                    if (linker.TryGetValue(groupID, out Instance group))    // if group has been "seen" already -- it's a dependent
                    {
                        group.CourseName = course.Name;
                        group.Class = (ClassType)type;
                    }
                    else                                                    // else -- group has not been "seen" -- a new group
                    {
                        group = new Instance(type, course, groupID, string.Empty);
                        course.Instances.Add(group);
                        if (tags.ElementAt(i + 1).Text.Contains("קבוצות"))  // if group has dependents
                            AddAllDependentsToGroup(tags.ElementAt(i + 1), linker, group);
                        linker.Add(groupID, group);
                    }

                    string lecturer = AddTimesGetLecturer(tags.ElementAt(i + 2), group);
                    if (!course.Lecturers.Contains(lecturer))
                        course.Lecturers.Add(lecturer);
                }
                driver.Navigate().Back();
            }
            driver.Quit();
        }

        private static void GoToPage(ref IWebDriver driver, string year, string semester, Course course)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement element = driver.FindElement(By.Id("R1C19"));
            SelectElement oSelect = new SelectElement(element);
            oSelect.SelectByValue(semester);
            element = driver.FindElement(By.XPath("//*[@id=\"kt_content\"]/div/div[2]/div/div/div/form/a[1]"));
            element.Click();
            element = driver.FindElement(By.Id("ChangeYear"));
            oSelect = new SelectElement(element);
            oSelect.SelectByValue(year);
            element = driver.FindElement(By.XPath("//*[@id=\"kt_content\"]/div/div[2]/div/div/div/form/a[2]"));
            element.Click();
            element = driver.FindElement(By.XPath("//*[@id=\"SubjectCode\"]"));
            element.Clear();
            element.SendKeys(course.ID.ToString());
            element = driver.FindElement(By.XPath("//*[@id=\"MyFather1\"]/div/div/input[2]"));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }

        private static void GetCourseName(ref IWebDriver driver, Course course)
        {
            IWebElement element;
            try
            {
                element = driver.FindElement(By.XPath("//*[@id=\"kt_content\"]/div/div[2]/div/div/div/form/table/tbody/tr[1]/td/h1"));
            }
            catch
            {
                try
                {
                    element = driver.FindElement(By.Id("desc"));
                }
                catch
                {
                    throw new Exception(string.Empty);
                }
                finally
                {
                    throw new Exception(course.ID.ToString());
                }
            }
            course.Name = element.Text.Remove(0, 5);
            course.Name = course.Name.Substring(0, course.Name.IndexOf("שנה\"ל"));
        }

        private static void GetCourseTest(ref IWebDriver driver, Course course)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"kt_content\"]/div/div[2]/div/div/div/form/table/tbody/tr[2]/td/div[1]/input"));
            element.Click();
            element = driver.FindElement(By.XPath("//*[@id=\"kt_content\"]/div/div[2]/div/div/div/form/table/tbody/tr[9]/td"));

            List<Tuple<string, string, DateTime>> tests = new List<Tuple<string, string, DateTime>>();
            string[] testsInfo = element.GetAttribute("innerText").Split('\n');
            int i = 0;

            foreach (var line in testsInfo)
            {
                if (line.Contains("מועד"))
                {
                    i++;
                    Tuple<string, string, DateTime> test = null;
                    DateTime dateAndTime = DateTime.MinValue;
                    DateTime date = DateTime.MinValue;
                    TimeSpan time = TimeSpan.MinValue;
                    string[] testLine = line.Replace("\r", "").Split(' ');
                    foreach (var info in testLine)
                    {
                        if (DateTime.TryParseExact(info, "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture, System.Globalization.DateTimeStyles.AllowWhiteSpaces, out DateTime _date))
                        {
                            date = _date;
                        }
                        else if (TimeSpan.TryParseExact(info, "h\\:mm", System.Globalization.CultureInfo.CurrentCulture, out TimeSpan _time))
                        {
                            time = _time;
                        }
                        if (date != DateTime.MinValue && time != TimeSpan.MinValue)
                        {
                            dateAndTime = date.Add(time);
                            test = new Tuple<string, string, DateTime>(course.Name, i.ToString(), dateAndTime);
                            tests.Add(test);
                        }
                    }
                }
            }
            course.Tests = tests;
            driver.Navigate().Back();
        }

        private static void GetTypeGroupID(IWebElement tag, out int type, out string groupID)
        {
            List<IWebElement> children = new List<IWebElement>(tag.FindElements(By.XPath("*")));
            string title = tag.Text;
            type = -1;
            if (title.Contains("סופי"))
                type = 0;
            else if (title.Contains("תרגול"))
                type = 1;
            else if (title.Contains("מעבדה"))
                type = 2;
            groupID = new String(children.ElementAt(0).Text.Where(char.IsDigit).ToArray());
        }

        private static void AddAllDependentsToGroup(IWebElement tag, Dictionary<string, Instance> linker, Instance group)
        {
            List<string> dependsList = tag.Text.Replace(" ", string.Empty).Replace("/", string.Empty).Replace("(", string.Empty).Replace(")", string.Empty).Split(',').ToList();
            dependsList.Add(dependsList.ElementAt(0).Substring(dependsList.ElementAt(0).IndexOf(':') + 1));
            dependsList.RemoveAt(0);
            group.Dependents = new List<Instance>();
            foreach (var id in dependsList)
            {
                if (!linker.ContainsKey(id))
                {
                    Instance dependence = new Instance(id);
                    group.Dependents.Add(dependence);
                    linker.Add(id, dependence);
                }
            }
        }

        private static string AddTimesGetLecturer(IWebElement tag, Instance group)
        {
            List<IWebElement> table = new List<IWebElement>(tag.FindElement(By.XPath(".//div[2]/div[2]/div[1]/table/tbody")).FindElements(By.TagName("tr")));
            string lecturer = string.Empty;
            foreach (var row in table)
            {
                string day = row.FindElement(By.XPath("./td[2]")).Text;
                string startTime = row.FindElement(By.XPath("./td[3]")).Text;
                string endTime = row.FindElement(By.XPath("./td[4]")).Text;
                lecturer = row.FindElement(By.XPath("./td[5]")).Text;
                string location = row.FindElement(By.XPath("./td[6]")).Text;
                group.Times.Add(new TimeFrame(day, startTime, endTime, location));
                group.Lecturer = lecturer;
            }
            return lecturer;
        }

        public static void KillChrome()
        {
            Process[] processes = Process.GetProcessesByName("chromedriver");
            foreach (Process chromedriver in processes)
            {
                chromedriver.Kill();
                chromedriver.Dispose();
            }
        }
    }
}
