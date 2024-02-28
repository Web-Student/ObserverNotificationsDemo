namespace Observer1.Data;

public interface ISubject
{
    public void Subscribe(IObserver o);
    public void Unsubscribe(IObserver o);
    public void NotifyObservers();
}

