namespace OOStepByStep
{
    public class Student : Person
    {
        private string classIntroduction = string.Empty;

        public Student(string className)
        {
            this.classIntroduction = $" I am a student of {className}.";
        }

        public Student()
        {
            this.classIntroduction = $" I am a student.";
        }

        public override string Introduct()
        {
            return $"{base.Introduct()}" + classIntroduction;
        }
    }
}