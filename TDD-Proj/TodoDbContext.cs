using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Proj;
public class TodoDbContext : DbContext {

    public TodoDbContext() {
        }

    public TodoDbContext(DbContextOptions<TodoDbContext> options) 
        : base(options) {
    }

    public virtual DbSet<Todo> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
       => optionsBuilder.UseSqlServer("server=localhost\\sqlexpress02;database=tododbcontext;trusted_connection=true;trustServerCertificate=true;");

}
