using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityBase.Entities
{
    public class EFContext : DbContext
    {

        public EFContext() : base("SemenConnection")
        {
        }
        public DbSet<AnimalType> AnimalTypes { get; set; }
    }
}
