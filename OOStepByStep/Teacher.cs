namespace OOStepByStep;
public class Teacher : Person
{
    public override string Introduce()
    {
        return $"{base.Introduce()} I am a teacher.";
    }
}