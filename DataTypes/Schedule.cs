using System;
using System.Collections.Generic;
using System.Linq;

namespace ScheduleBuilder
{
    public class Schedule
    {
        public bool[,] TimeTable;
        public TimeSpan[] StartTimes;
        public TimeSpan[] EndTimes;
        public List<Instance> CoursesInSchedule;

        public Schedule()
        {
            TimeTable = new bool[6, 15];
            StartTimes = new TimeSpan[6];
            for (int i = 0; i < StartTimes.Length; i++)
                StartTimes[i] = TimeSpan.FromHours(23);
            EndTimes = new TimeSpan[6];
            CoursesInSchedule = new List<Instance>();
        }

        public Schedule(Schedule source)
        {
            TimeTable = (bool[,])source.TimeTable.Clone();
            StartTimes = (TimeSpan[])source.StartTimes.Clone();
            EndTimes = (TimeSpan[])source.EndTimes.Clone();
            CoursesInSchedule = new List<Instance>(source.CoursesInSchedule);
        }

        public static List<Schedule> FindAllOptions(ref List<Course> courses)
        {
            List<Schedule> options = new List<Schedule>();
            RecursiveScheduler(ref courses, ref options, new Schedule());
            return options;
        }

        public static void RecursiveScheduler(ref List<Course> courses, ref List<Schedule> options, Schedule schedule)
        {
            if (courses.Count == 0)     // stop condition = no more courses to schedule
            {
                options.Add(schedule);
                return;
            }

            foreach (var instance in courses.First().Instances)
            {
                if (instance.Dependents != null)
                {
                    foreach (var dependent in instance.Dependents)
                    {
                        if (ScheduleCourseDependentCheck(instance, dependent, schedule) == true)
                        {
                            Schedule updatedSchedule = new Schedule(schedule);
                            ScheduleCourse(instance, updatedSchedule);
                            ScheduleCourse(dependent, updatedSchedule);
                            updatedSchedule.CoursesInSchedule.Add(instance);
                            updatedSchedule.CoursesInSchedule.Add(dependent);
                            List<Course> updatedCourses = new List<Course>(courses);
                            updatedCourses.RemoveAt(0);
                            RecursiveScheduler(ref updatedCourses, ref options, updatedSchedule);
                        }
                    }
                }
                else
                {
                    if (ScheduleCourseCheck(instance, schedule) == true)
                    {
                        Schedule updatedSchedule = new Schedule(schedule);
                        ScheduleCourse(instance, updatedSchedule);
                        updatedSchedule.CoursesInSchedule.Add(instance);
                        List<Course> updatedCourses = new List<Course>(courses);
                        updatedCourses.RemoveAt(0);
                        RecursiveScheduler(ref updatedCourses, ref options, updatedSchedule);
                    }
                }
            }
        }

        public static bool ScheduleCourseDependentCheck(Instance instance, Instance dependent, Schedule schedule)
        {
            if (ScheduleCourseCheck(dependent, schedule) == false)
                return false;
            if (ScheduleCourseCheck(instance, schedule) == false)
                return false;
            return true;
        }

        public static bool ScheduleCourseCheck(Instance instance, Schedule schedule)
        {
            foreach (var time in instance.Times)
            {
                int totalTime = TimeFrame.CalculateRoundTime(time.StartTime, time.EndTime);
                int startplace = time.StartTime.Hours - 8;
                for (int i = 0; i < totalTime; i++)
                {
                    if (schedule.TimeTable[(int)time.Day, startplace + i] == true)
                        return false;
                }
            }
            return true;
        }

        public static void ScheduleCourse(Instance instance, Schedule schedule)
        {
            foreach (var time in instance.Times)
            {
                int totalTime = TimeFrame.CalculateRoundTime(time.StartTime, time.EndTime);
                int startplace = time.StartTime.Hours - 8;
                for (int i = 0; i < totalTime; i++)
                {
                    schedule.TimeTable[(int)time.Day, startplace + i] = true;
                }
                UpdateStartEndTimes(time, schedule);
            }
        }

        public static void UpdateStartEndTimes(TimeFrame time, Schedule schedule)
        {
            if (schedule.StartTimes[(int)time.Day] > time.StartTime)
                schedule.StartTimes[(int)time.Day] = time.StartTime;
            if (schedule.EndTimes[(int)time.Day] < time.EndTime)
                schedule.EndTimes[(int)time.Day] = time.EndTime;
        }
    }
}
