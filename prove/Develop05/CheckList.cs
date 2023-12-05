using System;

public class Checklist : BaseGoal
{
    private int timesCompleted = 0;
    private int timesToAccomplish = 10;

    private string bonusPoints;

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
        bonusPoints = Console.ReadLine();
    }

     public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for the Checklist Goal: {GetGoalName()}");

    
        totalPoints += 50; 

 
        timesCompleted++;
        if (IsCompleted())
        {
            totalPoints += 500;
        }
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