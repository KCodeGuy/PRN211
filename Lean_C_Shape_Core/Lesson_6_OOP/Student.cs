using System;

namespace Lesson_6_OOP
{
    internal class Student
    {
        private int id;
        private string name;
        private int age;

        public Student() { }
        public Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        } 

        public int getId() { return id; }
        public void setID(int id) {this.id = id;}
        public string getName() { return name; }

        public void setName(string name) { this.name = name;}
            
        public int getAge() { return age; }
        public void setAge(int age) { this.age = age; }
    }
}
