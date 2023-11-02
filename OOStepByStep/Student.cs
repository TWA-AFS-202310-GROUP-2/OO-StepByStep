namespace OOStepByStep
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public string ClassName { get; set; }

        //public override string Introduct()
        //{
        //    return $"{base.Introduct()} I am a student.";
        //}

        public override string Introduct()
        {
            return $"{base.Introduct()} I am a student of {ClassName}.";
        }
    }
}