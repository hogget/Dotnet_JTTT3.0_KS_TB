using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApplication1
{
    class Task
    {
        public string Adres_strony;
        public string Klucz;
        public string Email;
        public Task(string Adres, string klucz, string email)
        {
            Adres_strony = Adres;
            Klucz = klucz;
            Email = email;
        }
        public Task() { }
    }

    public class TaskDbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TaskDbContext>
    {
        protected override void Seed(TaskDbContext context)
        {
            context.SaveChanges();
            base.Seed(context);
        }

    }
    public class TaskDbContext : DbContext
    {
        public TaskDbContext()
            : base ("Zadania")  //lista inicjalizacyjna konstruktora 

        {
            Database.SetInitializer(new TaskDbInitializer());
        }
        public DbSet<Task> Task { get; set; }

    }


  
}

