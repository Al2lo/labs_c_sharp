using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_9
{
    internal class UserContext:DbContext
    {
        public UserContext():base("Connection")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Works> Works { get; set; }
    }
}
