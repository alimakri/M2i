using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo4_1.Models
{
    public class DataPage1
    {
        public string Titre { get; set; }
        public List<Todo> Todos { get; set; }
    }
    public class Todo
    {
        public int Id { get; set; }
        public bool Fait { get; set; } = false;
        public string Libelle { get; set; }
        public DateTime DateExecution { get; set; }
    }
}