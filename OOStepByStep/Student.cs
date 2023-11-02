namespace OOStepByStep
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public override string Introduct()
        {
            return $"{base.Introduct()} I am a student.";
        }
    }
}