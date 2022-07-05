using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Demo4_1.Models
{
    public class DataPage1
    {
        public SqlConnection Cnx;

        public DataPage1()
        {
            Titre = "Ma première page ASP.Net MVC 5";
            Todos = new List<Todo>();

            Cnx = new SqlConnection();
            Cnx.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TodoDB;Integrated Security=True";
            Cnx.Open();
            var cmd = new SqlCommand();
            cmd.Connection = Cnx;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select Id, Libelle, Fait, DateExecution from Todo";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                var d = (DateTime)rd["DateExecution"];
                Todos.Add(new Todo
                {
                    Id = (int)rd["Id"],
                    Libelle = (string)rd["Libelle"],
                    Fait = (bool)rd["Fait"],
                    DateExecution = d
                });
            }
            rd.Close();

        }

        internal void Add(Todo todoCree)
        {
            // TODO: Add insert logic here
            Todos.Add(todoCree);
            var cmd = new SqlCommand();
            cmd.Connection = Cnx;
            cmd.CommandType = System.Data.CommandType.Text;
            var fait = todoCree.Fait ? "1" : "0";

            cmd.CommandText = $"insert Todo (Libelle, Fait, DateExecution) values('{todoCree.Libelle}', {fait}, '{todoCree.DateExecution.Date}')";
            cmd.ExecuteNonQuery();
        }

        internal void Edit(Todo todoEdit)
        {
            var fait = todoEdit.Fait ? "1" : "0";
            // TODO: Add delete logic here
            var cmd = new SqlCommand();
            cmd.Connection = Cnx;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $@"update Todo 
                                    set Libelle='{todoEdit.Libelle.Replace("'", "''")}', 
                                        Fait={fait}, 
                                        DateExecution='{todoEdit.DateExecution}' 
                                  where Id={todoEdit.Id}";
            cmd.ExecuteNonQuery();
        }

        public string Titre { get; set; }
        public List<Todo> Todos { get; set; }

        internal void Delete(Todo todoDelete)
        {
            // TODO: Add delete logic here
            var cmd = new SqlCommand();
            cmd.Connection = Cnx;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"delete Todo where Id={todoDelete.Id}";
            cmd.ExecuteNonQuery();
        }
    }
    public class Todo
    {
        public int Id { get; set; }
        public bool Fait { get; set; } = false;
        public string Libelle { get; set; }
        public DateTime DateExecution { get; set; }
    }
}