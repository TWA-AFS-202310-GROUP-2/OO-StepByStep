namespace OOStepByStep;

public class Student : Person
{
    public Student(string name, int age) : base(name, age)
    {
    }

    public override string Speak()
    {
        return base.Speak()+" I am a student.";
    }
}