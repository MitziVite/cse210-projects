using System;

public class EternalGoal : BaseGoal
{
    public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for the Eternal Goal: {GetGoalName()}");

        totalPoints += 100; 
    }

    public override string GetGoalName()
    {
        return base.GetGoalName();
    }

    public override bool IsCompleted()
    {
        return false; 
    }

    public override string SaveGoalInfo()
    {
        return $"Eternal Goal: {goalName}, {goalDescription}, {totalPoints}";
    }

    public override string GetAdditionalInfo()
    {
    
        return  $"[E] {goalName} ({goalDescription})";
    }
}
