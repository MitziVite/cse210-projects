using System;

public class EternalGoal : BaseGoal
{
    public override void RecordEvent()
    {
        Console.WriteLine("Event recorded for the Eternal Goal.");
    }

    public override string GetGoalName()
    {
        return base.GetGoalName();
    }

    public override bool IsCompleted()
    {
        return false; // EternalGoal siempre se considera completado
    }

    public override string SaveGoalInfo()
    {
        return $"Eternal Goal: {goalName}, {goalDescription}, {totalPoints}";
    }
}
