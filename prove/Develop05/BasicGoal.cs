using System;

public class BasicGoal : BaseGoal
{
    public override void RecordEvent()
    {
        Console.WriteLine("Event recorded for the Basic Goal.");
    }

    public override string GetGoalName()
    {
        return base.GetGoalName();
    }

    public override bool IsCompleted()
    {
        return totalPoints >= 1000;
    }

    public override string SaveGoalInfo()
    {
        return $"Basic Goal: {goalName}, {goalDescription}, {totalPoints}, {IsCompleted()}";
    }
    
}
