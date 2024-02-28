namespace Observer1.Data;
//this is the finished working code
public class StatisticsSubject : ISubject
{
    //These are our own personal statistics to track
    protected int daysUntilSpringBreak { get; set; }
    protected int homeworkAssignmentsDueThisWeek { get; set; }
    //protected double stressLevel = 0.0; //maybe I should move this to a different specific implementation of our observer, stress level = 1/daysLeft * homework due
    List<IObserver> observers;
    
    public void SetMeasurements(int days, int homework)
    {
        daysUntilSpringBreak = days;
        homeworkAssignmentsDueThisWeek = homework;
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public StatisticsSubject()
    {
        observers = new List<IObserver>();
        daysUntilSpringBreak = 7;
        homeworkAssignmentsDueThisWeek = 50;
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
