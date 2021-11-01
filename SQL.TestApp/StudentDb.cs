using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace SQL.TestApp
{
    class StudentDb : DbContext 
    {
        DbSet<Student> _Students;

        public DbSet<Student> Students
        {
            get
            {
                return _Students;
            }
            set
            {
                _Students = value;
            }
        }

        public StudentDb() : base("myDataBase")
        {

        }
    }
}
