namespace OOStepByStep
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual string Introduct()
        {
            var introduction = $"My name is {Name}. I am {Age} years old.";

            return introduction;
        }
    }
}