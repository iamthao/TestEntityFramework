using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntityFramework
{
    public class TestDbContext : DbContext
    {
        public TestDbContext() : base("AdminDb") { }
        public virtual DbSet<Grade> Grades { get; set; }
    }
}
