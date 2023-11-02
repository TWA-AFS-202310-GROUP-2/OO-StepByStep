namespace OOStepByStep;
public class Student : Person
{
    public override string Introduce()
    {
        return $"{base.Introduce()} I am a student.";
    }
}
