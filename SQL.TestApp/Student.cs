using System;
using System.Collections.Generic;
using System.Text;

namespace SQL.TestApp
{
    class Student
    {
        private int _id;
        private string _name;
        private string _lastName;
        private string _group;
        private double _avgGrade;
        private string _email;

        public int ID 
        { 
            get 
            {
                return _id;
            } 
            set 
            { 
                _id = value;  
            } 
        }

        public string Name 
        { 
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }

        }

        public string Group
        {
            get
            {
                return _group;
            }
            set
            {
                _group = value;
            }
        }

        public double AvgGrade
        {
            get
            {
                return _avgGrade;
            }
            set
            {
                _avgGrade = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public Student()
        {

        }
          
            
    }
}
