using System;
using System.Collections.Generic;

namespace ScheduleBuilder
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Instance> Instances { get; set; }
        public List<Tuple<string, string, DateTime>> Tests { get; set; }
        public List<string> Lecturers { get; set; }
        public Course(int id, string name)
        {
            this.ID = id;
            this.Name = name;
            this.Instances = new List<Instance>();
            this.Tests = new List<Tuple<string, string, DateTime>>();
            this.Lecturers = new List<string>();
        }
    }

    public class CourseComparer : IComparer<Course>
    {
        public int Compare(Course x, Course y)
        {
            return x.Instances.Count - y.Instances.Count;
        }
    }

    public class TestComparer : IComparer<Tuple<string, string, DateTime>>
    {
        public int Compare(Tuple<string, string, DateTime> x, Tuple<string, string, DateTime> y)
        {
            long dif = (x.Item3.Subtract(y.Item3)).Ticks;
            if (dif > 0)
                return 1;
            else if (dif < 0)
                return -1;
            else
                return 0;
        }
    }
}
