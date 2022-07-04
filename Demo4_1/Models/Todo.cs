using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo4_1.Models
{
    public class DataPage1
    {
        public string Titre;
        public List<Todo> Todos;
    }
    public class Todo
    {
        public int Id;
        public string Libelle;
        public DateTime DateExecution;
    }
}