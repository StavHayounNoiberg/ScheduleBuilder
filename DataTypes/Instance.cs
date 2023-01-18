using System.Collections.Generic;

namespace ScheduleBuilder
{
    public enum ClassType : byte { Lecture, Practice, Lab };

    public class Instance
    {
        public ClassType Class { get; set; }
        public string CourseName { get; set; }
        public string GroupID { get; set; }
        public string Lecturer { get; set; }
        public List<TimeFrame> Times { get; set; }
        public List<Instance> Dependents { get; set; }

        public Instance(int type, string courseName, string groupID, string lecturer, List<TimeFrame> times, List<Instance> dependents)
        {
            this.Class = (ClassType)type;
            this.CourseName = courseName;
            this.GroupID = groupID;
            this.Lecturer = lecturer;
            this.Times = times;
            this.Dependents = dependents;
        }

        public Instance(int type, Course course, string groupID, string lecturer) : this(type, course.Name, groupID, lecturer, new List<TimeFrame>(), null) { }

        public Instance(string groupID) : this(0, string.Empty, groupID, null, new List<TimeFrame>(), null) { }

        public string GetLecturer(Instance instance)
        {
            return instance.Lecturer;
        }
    }
}