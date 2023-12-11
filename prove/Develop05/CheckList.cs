using System;

public class Checklist : BaseGoal
{
    private int timesCompleted = 0;
    private int timesToAccomplish = 10;

    private int bonusPoints;

    public void TimesToAccomplish()
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        if (int.TryParse(Console.ReadLine(), out int inputTimesToAccomplish))
    {
    
        timesToAccomplish = inputTimesToAccomplish;
    }
    else
    {
        Console.WriteLine("Invalid input. Using the default value.");
       
    }}


    public void BonusPoints()
    {
       Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        if (int.TryParse(Console.ReadLine(), out int inputBonusPoints))
        {
            bonusPoints = inputBonusPoints;
        }
        else
        {
            Console.WriteLine("Invalid input. Using the default value.");
        }
    }

     public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for the Checklist Goal: {GetGoalName()}");
        timesCompleted++;

        if (timesCompleted == timesToAccomplish)
        {
            totalPoints += totalPoints+ bonusPoints;
        }

        Program.UpdateTotalScore(totalPoints);
    }
    public override bool IsCompleted()
    {
        return timesCompleted >= timesToAccomplish;
    }

    public override string SaveGoalInfo()
    {
        return $"Checklist Goal: {goalName}, {goalDescription}, {totalPoints}, {bonusPoints}, {timesToAccomplish}, {GetTimesCompleted()}";
    }
    
     public override string GetAdditionalInfo()
    {
        if(timesToAccomplish == timesCompleted){
                return $"[X] {goalName} ({goalDescription} -- Currently completed: {timesCompleted}/{timesToAccomplish}";
        }
        else{
                return $"[ ] {goalName} ({goalDescription} -- Currently completed: {timesCompleted}/{timesToAccomplish}";
        }

    }
}