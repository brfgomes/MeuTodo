using System.ComponentModel.DataAnnotations;

namespace MeuTodo.ViewModels;

public class UpdateTodoViewModel
{
    [Required] public string Title { get; set; }
}