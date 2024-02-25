namespace Observer1.Data;

public class Statistics : ISubject
{
    //these are the default methods we have to implement
    public void Notify(IObserver o)
    {
        throw new NotImplementedException();
    }

    public void Subscribe(IObserver o)
    {
        throw new NotImplementedException();
    }

    public void Unsubscribe(IObserver o)
    {
        throw new NotImplementedException();
    }

    //These are our own personal statistics to track
    protected double creditsLeftOnAzure = 0.0;
    protected int homeworkAssignmentsDueThisWeek = 100;
    protected double stressLevel = 0.0; //maybe I should move this to a different specific implementation of our observer, stress level = creditsLeft * homework due
}
