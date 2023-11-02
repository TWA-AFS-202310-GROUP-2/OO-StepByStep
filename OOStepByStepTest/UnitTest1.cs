namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_return_person_introduction_when_peron_given_introduction()
        {
            string name = "Tom";
            int age = 14;

            var person = new Person(name, age);
            string introduction = person.Speak();

            Assert.Equal($"My name is {name}, I am {age} years old.",introduction);
        }
    }
}
