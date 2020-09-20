namespace HardProj.EF
{
    using HardProj.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {

        public Context()
            : base("name=Context")
        {
        }

        public DbSet<Book> Books { get; set; } 
        public DbSet<Author> Authors { get; set; }
        public DbSet<Ganre> Ganres { get; set; }

       // public DbSet<DeleteMethod> DeleteMethods { get; set; }
    }
}