
namespace Todo_Test;
using TDD_Proj;

public class UnitTest1 {
    Todo item = default!;
    TodosController ctrl = default!;
    
    public UnitTest1() { 
        item = new Todo();
        ctrl = new TodosController();
    }
    
    [Fact]
    public void Test1() {
        var todo1 = ctrl.AddTodo(item);
        Assert.Equal("Active", item.TextStatus);
        Assert.Equal("Medium", item.TextPriority);
        Assert.True(todo1.Id == 4);

    } 
    [Fact]
    public void Test2() {
        var todos = ctrl.GetTodos();
        Assert.Equal(todos.Count(), 3);
    } 
    [Fact]
    public void Test3() {
        item.Description = "brush teeth";
        item.DueDate = new DateTime(2024,07,05);
        item.TextPriority = "High";
        var item2 = ctrl.UpdateTodos(4, item);
        Assert.Equal(item2.Description, item.Description);
    }
    [Fact]
    public void Test4() {
        var todos = ctrl.GetTodoById(1);
        Assert.NotNull(todos);
    }
    [Fact]
    public void Test5() {
        ctrl.DeleteTodo(2);
        Assert.Null(ctrl.GetTodoById(2));
    }
}