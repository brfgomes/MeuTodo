namespace MeuTodo.Models;

public class Todo
{
    public Todo(int id, string title, bool done)
    {
        Id = id;
        Title = title;
        Done = done;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public bool Done { get; set; }
}

