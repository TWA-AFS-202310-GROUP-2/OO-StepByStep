namespace OOStepByStep
{
    public class Teacher : Person
    {
        private string classIntroduction = string.Empty;

        public Teacher(string className)
        {
            this.classIntroduction = $" I am a teacher of {className}.";
        }

        public Teacher()
        {
            this.classIntroduction = $" I am a teacher.";
        }

        public override string Introduct()
        {
            return $"{base.Introduct()}" + classIntroduction;
        }
    }
}