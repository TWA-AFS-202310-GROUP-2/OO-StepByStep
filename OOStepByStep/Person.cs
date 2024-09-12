using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Person
    {
        public string name;
        private int age;
        private int classNumber;
        // AC1: A person can introduce him/herself with name and age like: "My name is Tom. I am 21 years old."
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name, int age, int classNumber)
        {
            this.name = name;
            this.age = age;
            this.classNumber = classNumber;
        }

        public virtual string SelfIntro()
        {
            return $"My name is {this.name}. I am {this.age} years old.";
        }
    }
}
