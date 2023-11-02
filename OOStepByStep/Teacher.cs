namespace OOStepByStep;
public class Teacher : Person
{
    public Teacher(string name, int age, int classNumber) : base(name, age)
    {
        ClassNumber = classNumber;
    }

    public Teacher(string name, int age) : base(name, age)
    {
    }

    public int ClassNumber { get; set; }

    public override string Introduce()
    {
        if (ClassNumber != 0)
        {
            return $"{base.Introduce()} I am a teacher of class {ClassNumber}.";
        }
        else
        {
            return $"{base.Introduce()} I am a teacher.";
        }
    }
}