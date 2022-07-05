using System.Collections.Generic;
using System.Linq;

namespace DemoEF.Models
{
    public class DataPage1
    {
        public TodoContext Context;

        public DataPage1()
        {
            Titre = "Ma première page ASP.Net MVC 5";
            Context = new TodoContext();
            Todos = Context.Todoes.ToList();
        }

        internal void Add(Todo todoCree)
        {
            Context.Todoes.Add(todoCree);
            Context.SaveChanges();
        }

        internal void Edit(Todo todoEdit)
        {
            var fait = todoEdit.Fait ? "1" : "0";
            var todo = Todos.Where(x => x.Id == todoEdit.Id).FirstOrDefault();
            if (todo != null)
            {
                todo.Libelle = todoEdit.Libelle;
                todo.Fait = todoEdit.Fait;
                todo.DateExecution = todoEdit.DateExecution;
                Context.SaveChanges();
            }
        }

        public string Titre { get; set; }
        public List<Todo> Todos { get; set; }

        internal void Delete(Todo todoDelete)
        {
            var todo = Todos.Where(x => x.Id == todoDelete.Id).FirstOrDefault();
            if (todo != null)
            {
                Context.Todoes.Remove(todo);
                Context.SaveChanges();
            }
        }
    }
}