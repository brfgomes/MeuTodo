namespace MeuTodo.Models;

public class Todo
{
    public Todo(string title, bool done, DateTime date)
    {
        Title = title;
        Done = done;
        Date = DateTime.Now;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public bool Done { get; set; }
    public DateTime Date { get; set; }
}