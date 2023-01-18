using System.Collections.Generic;

namespace ScheduleBuilder
{
    public struct LoginDataStruct
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Year { get; set; }
        public string Semester { get; set; }
        public List<string> Courses { get; set; }

        public LoginDataStruct(string username, string password, string year, string semester, List<string> courses)
        {
            this.Username = username;
            this.Password = password;
            this.Year = year;
            this.Semester = semester;
            this.Courses = courses;
        }
    }
}
