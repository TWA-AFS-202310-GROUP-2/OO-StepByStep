using System;

namespace OOStepByStep;

public class Student : Person
{
    public string className;
    public Student(string name, int age) : base(name, age)
    {
    }
    public Student(string name, int age,string className) : base(name, age)
    {
        this.className=className;
    }
    public override string Speak()
    {
        if (className != null && className.Length > 0)
        {
            return base.Speak() + $" I am a student of {className}.";
        }
        else
        {
            return base.Speak() + $" I am a student.";
        }
    }
}