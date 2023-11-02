namespace OOStepByStep;

public class Teacher : Person
{
    public Teacher(string name, int age) : base(name, age)
    {
    }

    public override string Speak()
    {
        return base.Speak()+" I am a teacher.";
    }
}