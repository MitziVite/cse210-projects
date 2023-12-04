using System;

public class Checklist : BaseGoal
{
    private string timesToAccomplish;
    private string bonusPoints;

    public void TimesToAccomplish()
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        timesToAccomplish = Console.ReadLine();
    }

    public void BonusPoints(){
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        bonusPoints = Console.ReadLine();
    }

    public override void RecordEvent()
    {
        Console.WriteLine("Event recorded for the Checklist Goal.");
    }

    public override bool IsCompleted()
    {
        return GetTimesCompleted() >= GetTimesToAccomplish();
    }

    public override string SaveGoalInfo()
    {
        return $"Checklist Goal: {goalName}, {goalDescription}, {totalPoints}, {bonusPoints},{timesToAccomplish}, {GetTimesCompleted()}";
    }
}
