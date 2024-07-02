using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Proj;
public class TodosController {

    TodoDbContext _context = new TodoDbContext();

    public Todo AddTodo(Todo item) {
        item.Id = 0;
        item.TextStatus = "Active";
        item.DueDate = new DateTime(2024,07,02).AddDays(7);
        item.TextPriority = "Medium";
        _context.Todos.Add(item);
        _context.SaveChanges();
        return item;

    }

    public IEnumerable<Todo> GetTodos() {
        return _context.Todos.ToList();

    }

    public Todo UpdateTodos(int id, Todo updated) {
        var item = _context.Todos.Find(id);
        item.Description = updated.Description;
        item.DueDate = updated.DueDate;
        item.TextPriority = updated.TextPriority;
        _context.SaveChanges();
        return item;
    }
    public Todo GetTodoById(int id) {
        var found = _context.Todos.Find(id);
        return found;
    }
    public void DeleteTodo(int id) {

        var deleted = _context.Todos.Find(id);
        _context.Todos.Remove(deleted);
        _context.SaveChanges();
    }
}
