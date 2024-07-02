using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Proj;
public class TodosController {

    TodoDbContext _context = new TodoDbContext();

    public Todo AddTodo(Todo item) {
        item.TextStatus = "Active";
        item.DueDate.AddDays(7);
        item.TextPriority = "Medium";
        _context.Todos.Add(item);
        return item;
    }



}
