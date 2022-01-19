using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SQL.TestApp2
{
    public class StudentDb : DbContext
    {
        public StudentDb() : base("StudentDb")
        {

        }
        public DbSet<Student> Students
        {
            get; set;
        }
    }
}
