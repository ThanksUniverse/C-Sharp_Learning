namespace Todo.Domain.Entities;

public class Todo : Entity
{
    public Todo(string title, DateTime date, string user)
    {
        Title = title;
        Date = date;
        User = user;
    }

    public string Title { get; private set; }
    public bool Done { get; private set; } = false;
    public DateTime Date { get; private set; }
    public string User { get; private set; }

    public void MarkAsDone()
    {
        Done = true;
    }

    public void MarkAsUndone()
    {
        Done = false;
    }

    public void UpdateTile(string title)
    {
        Title = title;
    }
}