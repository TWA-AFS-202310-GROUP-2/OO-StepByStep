namespace OOStepByStep;
public class Student : Person
{
    public Student(string name, int age, int classNumber) : base(name, age)
    {
        ClassNumber = classNumber;
    }

    public Student(string name, int age) : base(name, age)
    {
    }

    public int ClassNumber { get; set; }

    public override string Introduce()
    {
        if (ClassNumber == 0)
        {
            return $"{base.Introduce()} I am a student.";
        }
        else
        {
            return $"{base.Introduce()} I am a student of class {ClassNumber}.";
        }
    }
}
