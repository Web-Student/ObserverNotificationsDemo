namespace Observer1.Data;

public interface IObserver
{
    public void Update(int homeworkAssigments, int daysUntilBreak); //needs to take in the data to update in the future
}