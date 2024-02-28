namespace Observer1.Data;
public class StatisticsSubject : ISubject
{
    //These are our own personal statistics to track
    protected int daysUntilSpringBreak = 3;
    protected int homeworkAssignmentsDueThisWeek = 100;
    protected double stressLevel = 0.0; //maybe I should move this to a different specific implementation of our observer, stress level = 1/daysLeft * homework due
    List<IObserver> observers;

    public StatisticsSubject()
    {
        observers = new List<IObserver>();
    }

    //these are the default methods we have to implement
    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(homeworkAssignmentsDueThisWeek, daysUntilSpringBreak);
        }
    }

    public void Subscribe(IObserver o)
    {
        observers.Add(o);
    }

    public void Unsubscribe(IObserver o)
    {
        int i = observers.IndexOf(o);
        if (i >= 0) { observers.RemoveAt(i); }
    }

}
