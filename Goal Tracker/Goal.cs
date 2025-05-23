using System;
namespace Goal_Tracker
{
    public class Goal
    {
        public string Title { get; set; }
        public DateTime PlannedTime { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public Goal() { }

        public Goal(string title, DateTime plannedTime, DateTime dueDate)
        {
            Title = title;
            PlannedTime = plannedTime;
            DueDate = dueDate;
            IsCompleted = false;
        }

        public override string ToString()
        {
            string status = IsCompleted ? "[Виконано]" : "[У процесі]";
            return $"{status} {Title} (Початок: {PlannedTime:g}, Дедлайн: {DueDate:g})";
        }
    }
}
