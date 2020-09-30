using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetCSharpItescia.Data;

namespace ProjetCSharpItescia.NEf
{
    public class ContextEf : DbContext
    {
        public ContextEf() : base("C_BdCampagne") { }
        public DbSet<Campagne>CampagnesEntites { get; set; }


    }
}
