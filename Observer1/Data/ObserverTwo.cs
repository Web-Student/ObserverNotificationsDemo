namespace Observer1.Data;

public class ObserverTwo : IObserver, IDisplayElement
{
    public void DisplayStats()
    {
        throw new NotImplementedException();
    }

    public void Update(int homeworkAssigments, int daysUntilBreak)
    {
        throw new NotImplementedException();
    }
}
