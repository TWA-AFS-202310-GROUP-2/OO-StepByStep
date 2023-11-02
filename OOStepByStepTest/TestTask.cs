namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class TestTask
    {
        [Fact]
        public void Should_return_name_and_age_when_self_introduce_given_a_person()
        {
            var p = new Person("Tom", 21);
            var res = p.SelfIntroduce();
            Assert.Equal("My name is Tom, I am 21 years old.", res);
        }
    }
}
