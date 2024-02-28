namespace Observer1.Data;

public class ObserverOne : IObserver, IDisplayElement
{
    //in this implementation, our observer writes to the console about the data it gets

    private int numHomeworkAssignments;
    private int daysTilBreak;

    public void DisplayStats()
    {
        Console.WriteLine($"Homework Assignments Due: {numHomeworkAssignments}");
        Console.WriteLine($"Days until spring break: {daysTilBreak}");
    }

    public void Update(int homeworkAssignments, int daysUntilBreak)
    {
        numHomeworkAssignments = homeworkAssignments;
        daysTilBreak = daysUntilBreak;
        DisplayStats();
    }
}
