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
            var person = new Person("Tom", 21);

            var result = person.Introduce();

            Assert.Equal("My name is Tom. I am 21 years old.", result);
        }

        [Fact]
        public void Test_Student_Introduction()
        {
            var student = new Student("Tom", 18);

            var result = student.Introduce();

            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", result);
        }

        [Fact]
        public void Test_Teacher_Introduction()
        {
            var teacher = new Teacher("Amy", 30);

            var result = teacher.Introduce();

            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", result);
        }

        [Fact]
        public void Test_Student_Class_Introduction()
        {
            var student = new Student("Tom", 18, 2);

            var result = student.Introduce();

            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2.", result);
        }

        [Fact]
        public void Test_Teacher_Class_Introduction()
        {
            var teacher = new Teacher("Amy", 30, 2);

            var result = teacher.Introduce();

            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", result);
        }

        [Fact]
        public void Test_AddStudent_To_Class()
        {
            var teacher = new Teacher("Amy", 30, 2);

            var class2 = new Class { ClassNumber = 2, Teacher = teacher };

            var studentTom = new Student("Tom", 18, 2);

            var studentJim = new Student("Jim", 18, 2);

            class2.AddStudent(studentTom);

            var result = class2.AddStudent(studentJim);

            var expectedOutput =

                "My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Jim join class 2.\r\n" +

                "My name is Tom. I am 18 years old. I am a student of class 2. Welcome Jim join class 2.\r\n";

            Assert.Equal(expectedOutput, result);
        }
    }
}
