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

        [Fact]
        public void Should_return_name_age_class_when_self_introduce_given_a_student_with_class()
        {
            var p = new Student("Tom", 18);
            p.ClassNumber = 2;

            var res = p.SelfIntroduce();
            Assert.Equal("My name is Tom, I am 18 years old. I am a student of class 2.", res);
        }

        [Fact]
        public void Should_return_name_age_class_when_self_introduce_given_a_teacher_with_class()
        {
            var p = new Teacher("Amy", 30);
            p.ClassNumber = 2;

            var res = p.SelfIntroduce();
            Assert.Equal("My name is Amy, I am 30 years old. I am a teacher of class 2.", res);
        }

        [Fact]
        public void Should_introduce_self_when_join_student_in_class()
        {
            var teacher = new Teacher("Amy", 30);
            var tom = new Student("Tom", 18);
            var janny = new Student("Janny", 17);

            var cls = new Class(2, teacher);
            var res = cls.JoinStudent(tom);
            var res2 = cls.JoinStudent(janny);

            Assert.Equal("My name is Amy, I am 30 years old. I am a teacher of class 2. Welcome Tom join class 2.", res);

            Assert.Equal("My name is Amy, I am 30 years old. I am a teacher of class 2. Welcome Janny join class 2.\r\nMy name is Tom, I am 18 years old. I am a student of class 2. Welcome Janny join class 2.", res2);
        }
    }
}
