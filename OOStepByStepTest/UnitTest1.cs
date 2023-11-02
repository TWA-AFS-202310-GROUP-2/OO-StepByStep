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

        [Fact]
        public void Should_return_student_introduction_when_student_given_introduction()
        {
            string name = "Tom";
            int age = 14;

            var student = new Student(name, age);
            string introduction = student.Speak();

            Assert.Equal($"My name is {name}, I am {age} years old. I am a student.", introduction);
        }

        [Fact]
        public void Should_return_teacher_introduction_when_teacher_given_introduction()
        {
            string name = "Jenny";
            int age = 32;

            var teacher = new Teacher(name, age);
            string introduction = teacher.Speak();

            Assert.Equal($"My name is {name}, I am {age} years old. I am a teacher.", introduction);
        }
    }
}
