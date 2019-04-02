using EFCF1.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF1.Data.Context
{
    class CFDbContext:DbContext
    {
        public CFDbContext():base("CS1")
        { }
        public DbSet<Personel> personels { get; set; }
        public DbSet<Departman> departmans { get; set; }
    }

}
