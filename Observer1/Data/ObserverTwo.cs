using Microsoft.JSInterop;
using System.Windows.Markup;


namespace Observer1.Data;

public class ObserverTwo : IObserver, IDisplayElement
{
    private int numHomeworkAssignments;
    private int daysTilBreak;
    private int stress;
    public void DisplayStats()
    {
        using StreamWriter writer = new StreamWriter("StressLevelStats.txt", append:true);
        writer.WriteLine($"Timestamp: {DateTime.Now}\tHomework Assignments Due: {numHomeworkAssignments}\tDays Until Spring Break: {daysTilBreak}\t\tOverall Stress Level: {stress}");
    }

    public void Update(int homeworkAssigments, int daysUntilBreak)
    {
        numHomeworkAssignments = homeworkAssigments;
        daysTilBreak = daysUntilBreak;
        if (daysTilBreak > 0)
        {
            stress = homeworkAssigments / daysTilBreak;
        }
       else { stress = 0; }
       DisplayStats(); //notify the world that our statistics changed
    }
}
