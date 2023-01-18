using System;
using System.Collections.Generic;
using System.IO;

namespace ScheduleBuilder
{
    public static class IOFunctions
    {
        public static void ImportLoginData(out string username, out string password)
        {
            FileStream file = new FileStream("credentials.dat", FileMode.Open);
            BinaryReader bReader = new BinaryReader(file);
            username = bReader.ReadString();
            password = bReader.ReadString();
            bReader.Close();
            file.Close();
        }

        public static void ExportLoginData(string username, string password)
        {
            FileStream file = new FileStream("credentials.dat", FileMode.Create);
            BinaryWriter bWriter = new BinaryWriter(file);
            bWriter.Write(username);
            bWriter.Write(password);
            bWriter.Close();
            file.Close();
        }

        public static List<Schedule> ReadSchedulesFile(string scheduleFile, out List<Course> allCourses)
        {
            List<Schedule> allOptions;
            allCourses = new List<Course>();

            FileStream stream = new FileStream(scheduleFile, FileMode.Open);
            BinaryReader reader = new BinaryReader(stream);

            try
            {
                int optionsCount = reader.ReadInt32();

                if (optionsCount > 0)
                {
                    allOptions = new List<Schedule>();

                    for (int k = 0; k < optionsCount; k++)
                    {
                        Schedule option = new Schedule();
                        ReadScheduleTimeTable(ref reader, ref option);
                        ReadScheduleStartEndTimes(ref reader, ref option);

                        var coursesInSchedule = reader.ReadInt32();
                        for (int i = 0; i < coursesInSchedule; i++)
                        {
                            Instance instance = ReadInstance(reader);
                            int dependentCount = reader.ReadInt32();
                            if (dependentCount > 0)
                            {
                                for (int m = 0; m < dependentCount; m++)
                                {
                                    var dependent = ReadInstance(reader);
                                    instance.Dependents.Add(dependent);
                                }
                            }
                            option.CoursesInSchedule.Add(instance);
                        }

                        allOptions.Add(option);
                    }

                    int coursesCount = reader.ReadInt32();
                    for (int i = 0; i < coursesCount; i++)
                    {
                        int id = reader.ReadInt32();
                        string name = reader.ReadString();
                        Course course = new Course(id, name);

                        int lecturersCount = reader.ReadInt32();
                        if (lecturersCount > 0)
                        {
                            List<string> lecturers = new List<string>();
                            for (int k = 0; k < lecturersCount; k++)
                            {
                                lecturers.Add(reader.ReadString());
                            }
                            course.Lecturers = lecturers;
                        }

                        int testCount = reader.ReadInt32();
                        for (int j = 0; j < testCount; j++)
                        {
                            string item1 = reader.ReadString();
                            string item2 = reader.ReadString();
                            long date = reader.ReadInt64();
                            course.Tests.Add(new Tuple<string, string, DateTime>(item1, item2, DateTime.FromBinary(date)));
                        }
                        allCourses.Add(course);
                    }

                    reader.Close();
                    stream.Close();
                    return allOptions;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        private static void ReadScheduleTimeTable(ref BinaryReader reader, ref Schedule option)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    option.TimeTable[i, j] = reader.ReadBoolean();
                }
            }
        }

        private static void ReadScheduleStartEndTimes(ref BinaryReader reader, ref Schedule option)
        {
            for (int i = 0; i < 6; i++)
            {
                double totalMinutes = reader.ReadDouble();
                option.StartTimes[i] = TimeSpan.FromMinutes(totalMinutes);
                totalMinutes = reader.ReadDouble();
                option.EndTimes[i] = TimeSpan.FromMinutes(totalMinutes);
            }
        }

        private static Instance ReadInstance(BinaryReader reader)
        {
            int enumClass = reader.ReadInt32();
            string courseName = reader.ReadString();
            string groupID = reader.ReadString();
            string lecturer = reader.ReadString();
            Instance instance = new Instance(enumClass, courseName, groupID, lecturer, new List<TimeFrame>(), new List<Instance>());

            int timesCount = reader.ReadInt32();
            for (int j = 0; j < timesCount; j++)
            {
                string day = reader.ReadString();
                string startTime = reader.ReadString();
                string endTime = reader.ReadString();
                string location = reader.ReadString();
                instance.Times.Add(new TimeFrame(day, startTime, endTime, location));
            }

            return instance;
        }

        public static void ExportOptions(List<Schedule> options, List<Course> courses, string saveFile)
        {
            FileStream stream = new FileStream(saveFile, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(options.Count);
            foreach (var option in options)
            {
                WriteOption(writer, option);

                writer.Write(option.CoursesInSchedule.Count);
                foreach (var instance in option.CoursesInSchedule)
                {
                    WriteInstance(writer, instance);
                    if (instance.Dependents != null)
                    {
                        writer.Write(instance.Dependents.Count);
                        if (instance.Dependents.Count > 0)
                        {
                            foreach (var dependent in instance.Dependents)
                            {
                                WriteInstance(writer, dependent);
                            }
                        }
                    }
                    else
                    {
                        writer.Write(0);
                    }
                }
            }

            writer.Write(courses.Count);
            foreach (var course in courses)
            {
                writer.Write(course.ID);
                writer.Write(course.Name);
                writer.Write(course.Lecturers.Count);
                foreach (var lecturer in course.Lecturers)
                {
                    writer.Write(lecturer);
                }
                writer.Write(course.Tests.Count);
                foreach (var test in course.Tests)
                {
                    writer.Write(test.Item1);
                    writer.Write(test.Item2);
                    writer.Write(test.Item3.ToBinary());
                }
            }
            writer.Close();
            stream.Close();
        }

        private static void WriteOption(BinaryWriter writer, Schedule option)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    writer.Write(option.TimeTable[i, j]);
                }
            }

            for (int i = 0; i < 6; i++)
            {
                writer.Write(option.StartTimes[i].TotalMinutes);
                writer.Write(option.EndTimes[i].TotalMinutes);
            }
        }

        private static void WriteInstance(BinaryWriter writer, Instance instance)
        {
            writer.Write((int)(instance.Class));
            writer.Write(instance.CourseName);
            writer.Write(instance.GroupID);
            writer.Write(instance.Lecturer);

            writer.Write(instance.Times.Count);
            foreach (var time in instance.Times)
            {
                writer.Write(time.Day.ToString());
                writer.Write(time.StartTime.ToString());
                writer.Write(time.EndTime.ToString());
                writer.Write(time.Location);
            }
        }
    }
}
