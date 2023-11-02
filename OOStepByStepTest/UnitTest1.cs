namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_return_name_age_When_Introduct_Given_name_age()
        {//given
            var person = new Person("Tom", 21);
            //when
            string introduction = person.Introduct();
            //then
            Assert.Equal("My name is Tom. I am 21 years old.", introduction);
        }
    }
}
