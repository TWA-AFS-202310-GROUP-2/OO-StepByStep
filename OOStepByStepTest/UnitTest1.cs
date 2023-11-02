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

        [Fact]
        public void Should_return_student_name_age_When_Introduct_Given_name_age_student()
        {//given
            var student = new Student("Tom", 21);
            //when
            string studentIntroduction = student.Introduct();
            //then
            Assert.Equal("My name is Tom. I am 21 years old. I am a student.", studentIntroduction);
        }

        [Fact]
        public void Should_return_teacher_name_age_When_Introduct_Given_name_age_teacher()
        {//given
            var teacher = new Teacher("Amy", 30);
            //var teacher = new Teacher("Amy", 30);
            //when
            string studentIntroduction = teacher.Introduct();
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", studentIntroduction);
        }
    }
}
