namespace OOStepByStep
{
    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public string ClassName { get; set; }
        //public override string Introduct()
        //{
        //    return $"{base.Introduct()} I am a teacher.";
        //}

        public override string Introduct()
        {
            return $"{base.Introduct()} I am a teacher of {ClassName}.";
        }
    }
}