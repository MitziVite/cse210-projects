using System;

public class BasicGoal : BaseGoal
{
    int totalScore;
    private bool isCompleted = false;
     public override bool IsCompleted()
    {
        return isCompleted;
    }

     public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for the Basic Goal: {GetGoalName()}");

        if (!isCompleted)
        {
            isCompleted = true;
            // Incrementar totalScore en lugar de totalPoints
            totalScore += totalPoints; 
        }
    }

    public override string GetGoalName()
    {
        return base.GetGoalName();
    }

    
    public override string SaveGoalInfo()
    {
        return $"Basic Goal: {goalName}, {goalDescription}, {totalPoints}, {IsCompleted()}";
    }

    public override string GetAdditionalInfo()
    {
        if(isCompleted){
            return $"[X] {goalName} ({goalDescription})";
        }
        else{
            return $"[ ] {goalName} ({goalDescription})";
        }
        
    }
}
