using System;

namespace ScheduleBuilder
{
    public enum WeekDay { א, ב, ג, ד, ה, ו, error };

    public struct TimeFrame
    {
        public WeekDay Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Location { get; set; }

        public TimeFrame(string day, string startTime, string endTime, string location)
        {
            if (Enum.TryParse<WeekDay>(day, out WeekDay _day))
                this.Day = _day;
            else
                this.Day = (WeekDay)6;

            if (TimeSpan.TryParse(startTime, out TimeSpan _startTime))
                this.StartTime = _startTime;
            else
                this.StartTime = TimeSpan.Zero;

            if (TimeSpan.TryParse(endTime, out TimeSpan _endTime))
                this.EndTime = _endTime;
            else
                this.EndTime = TimeSpan.Zero;

            this.Location = location;
        }

        public static int CalculateRoundTime(TimeSpan start, TimeSpan end) => (int)Math.Ceiling(end.Subtract(start).TotalHours);
    }
}
