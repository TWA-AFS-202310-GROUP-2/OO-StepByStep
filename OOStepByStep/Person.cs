namespace OOStepByStep
{
    using System;
    public class Person
    {
        public Person()
        {
        }

        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public int Age { get; set; }
        public string Name { get; set; }

        public virtual string SelfIntroduce()
        {
            return $"My name is {Name}, I am {Age} years old.";
        }
    }
}
