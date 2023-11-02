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

        [Fact]
        public void Test_Student_Introduction()
        {
            var student = new Student { Name = "Tom", Age = 18 };

            var result = student.Introduce();

            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", result);
        }

        [Fact]
        public void Test_Teacher_Introduction()
        {
            var teacher = new Teacher { Name = "Amy", Age = 30 };

            var result = teacher.Introduce();

            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", result);
        }
    }
}
