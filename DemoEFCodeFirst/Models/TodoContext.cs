using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace DemoEFCodeFirst.Models
{
    public partial class TodoContext : DbContext
    {
        public TodoContext() : base("name=TodoContext")
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Todo> Todos { get; set; }
    }
    [Table("AFaire")]
    public partial class Todo
    {
        public Todo()
        {
            this.Comments = new HashSet<Comment>();
        }
        [Key]
        public int Cle { get; set; }
        public string Libelle { get; set; }
        [Column("Realise")]
        public bool Fait { get; set; }
        public string Machine { get; set; }
        public System.DateTime DateExecution { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
    public partial class Comment
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public int Todo { get; set; }
        public virtual Todo Todo1 { get; set; }
    }
}