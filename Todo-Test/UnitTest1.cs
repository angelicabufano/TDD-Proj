
namespace Todo_Test;
using TDD_Proj;

public class UnitTest1 {
    Todo item = default!;
    TodosController ctrl = default!;
    TodoDbContext _context = default!;
    public UnitTest1() { 
        item = new Todo();
        ctrl = new TodosController();
        _context = new TodoDbContext();
    }

    [Fact]
    public void Test1() {
        Assert.True(_context.Todos.Any(i => i.Description == item.Description));
        Assert.Equal("Active", item.TextStatus);
        Assert.Equal(item.DueDate.AddDays(7), item.DueDate);
        Assert.Equal("Medium", item.TextPriority);

    }
}