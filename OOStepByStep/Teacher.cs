namespace OOStepByStep
{
    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public override string Introduct()
        {
            return $"{base.Introduct()} I am a teacher.";
        }
    }
}