using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<Contexto>());

            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Contexto>());
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Estoque> Estoque { get; set; }
    }
}
