using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TDD_Proj;
public class Todo {
    public int Id { get; set; }
    [StringLength(300)]
    public string Description { get; set; } = string.Empty;
    [Column(TypeName = "datetime")]
    public DateTime DueDate { get; set; }
    [StringLength(30)]
    public string TextStatus { get; set; } = string.Empty;
    [StringLength(30)]
    public string TextPriority { get; set; } = string.Empty;
}
