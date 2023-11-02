namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var class1 = new Class1();
            Assert.NotNull(class1);
        }

        [Fact]
        public void Test_Person_Introduction()
        {
            var person = new Person { Name = "Tom", Age = 21 };

            var result = person.Introduce();

            Assert.Equal("My name is Tom. I am 21 years old.", result);
        }
    }
}
