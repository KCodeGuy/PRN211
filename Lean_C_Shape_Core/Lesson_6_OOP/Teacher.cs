using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_OOP
{
    internal class Teacher
    {
        private int id;
        private string name;
        private int age;

        public Teacher(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public int Id
        {
            get { return id; }
            set {
                if(value > 10000)
                {
                    id = -1;
                }else
                {
                    id = value;
                }
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value;}
        }

        public int Age { 
            get { return age; }
            set { age = value; }
        }
    }
}
