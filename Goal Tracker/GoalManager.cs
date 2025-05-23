using System.Collections.Generic;
using System.Linq;
namespace Goal_Tracker
{

    public class GoalManager
    {
        public GoalManager() { }
        public List<Goal> Goals { get; private set; } = new List<Goal>();
        public void AddGoal(Goal goal)
        {
            Goals.Add(goal);
        }
        public void EditGoal(int index, Goal updatedGoal)
        {
            if (index >= 0 && index < Goals.Count)
            {
                Goals[index] = updatedGoal;
            }
        }
        public void RemoveGoal(int index)
        {
            if (index >= 0 && index < Goals.Count)
            {
                Goals.RemoveAt(index);
            }
        }
        public int GetProgressPercentage()
        {
            if (Goals.Count == 0) return 0;
            int completedCount = Goals.Count(goal => goal.IsCompleted);
            return (completedCount * 100) / Goals.Count;
        }
    }
}
