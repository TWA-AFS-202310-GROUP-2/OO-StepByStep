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

        [Fact]
        public void Should_return_name_and_age_when_self_introduce_given_a_student()
        {
            var p = new Student("Tom", 18);
            var res = p.SelfIntroduce();
            Assert.Equal("My name is Tom, I am 18 years old. I am a student.", res);
        }

        [Fact]
        public void Should_return_name_and_age_when_self_introduce_given_a_teacher()
        {
            var p = new Teacher("Amy", 30);
            var res = p.SelfIntroduce();
            Assert.Equal("My name is Amy, I am 30 years old. I am a teacher.", res);
        }
    }
}
