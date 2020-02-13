using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency
{
    class AgencyContext:DbContext 
    {
        public AgencyContext() : base("AgencyContext")
        { }
        public DbSet <EstateAgency> EstateAgencies { get; set; }
    }
}
