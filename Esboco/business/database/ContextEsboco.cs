using business.classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.database
{
   public class ContextEsboco : DbContext
    {
        public ContextEsboco() : base("Esboco")
        {

        }

        public DbSet<Mensagem> Mensagem { get; set; }
        public DbSet<Fonte> Fonte { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        

    }


}
