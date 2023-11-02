namespace OOStepByStep;

public class Teacher : Person
{
    public string? className;
    public Teacher(string name, int age) : base(name, age)
    {
    }

    public Teacher(string name, int age, string className
    ) : base(name, age)
    {
        this.className = className;
    }

    public override string Speak()
    {
        if (className != null && className.Length > 0)
        {
            return base.Speak()+$" I am a teacher of {className}.";
        }
        else
        {
            return base.Speak()+$" I am a teacher.";
        }
    }
}