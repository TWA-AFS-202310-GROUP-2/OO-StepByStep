namespace OOStepByStepTest
{
    using OOStepByStep;
    using System.Security.Claims;
    using Xunit;

    public class UnitTest
    {
        [Fact]
        public void Should_return_msg_when_person_introduce()
        {
            var person = new Person { Name = "Tom", Age = 21 };
            var result = person.Introduce();
            Assert.Equal("My name is Tom. I am 21 years old.", result);
        }

        [Fact]
        public void Should_return_msg_when_student_introduce()
        {
            var student = new Student { Name = "Tom", Age = 18 };
            var result = student.Introduce();
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", result);
        }

        [Fact]
        public void Should_return_msg_when_teacher_introduce()
        {
            var teacher = new Teacher { Name = "Amy", Age = 30 };
            var result = teacher.Introduce();
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", result);
        }

        [Fact]
        public void Should_return_msg_when_classnumber_given_and_student_introduce()
        {
            var student = new Student { Name = "Tom", Age = 18, ClassNumber = 2 };
            var result = student.Introduce();
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2.", result);
        }

        [Fact]
        public void Should_return_msg_when_classnumber_given_and_teacher_introduce()
        {
            var teacher = new Teacher { Name = "Amy", Age = 30, ClassNumber = 2 };
            var result = teacher.Introduce();
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", result);
        }

        [Fact]
        public void Should_return_msg_when_new_student_join_class2()
        {
            var teacher = new Teacher { Name = "Amy", Age = 30 };
            var class2 = new Class(2, teacher);

            var studentTom = new Student { Name = "Tom", Age = 18 };
            var studentJim = new Student { Name = "Jim", Age = 20 };

            class2.AddStudent(studentTom);

            var result = class2.AddStudent(studentJim);

            var expectedOutput =
                "My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Jim join class 2.\n" +
                "My name is Tom. I am 18 years old. I am a student of class 2. Welcome Jim join class 2.\n";
            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void Should_return_msg_when_new_student_join_class3()
        {
            var teacher = new Teacher { Name = "Amy", Age = 30 };
            var class3 = new Class(3, teacher);

            var studentTom = new Student { Name = "Tom", Age = 18 };
            var studentJim = new Student { Name = "Jim", Age = 20 };

            class3.AddStudent(studentTom);

            var result = class3.AddStudent(studentJim);

            var expectedOutput =
                "My name is Amy. I am 30 years old. I am a teacher of class 3. Welcome Jim join class 3.\n" +
                "My name is Tom. I am 18 years old. I am a student of class 3. Welcome Jim join class 3.\n";
            Assert.Equal(expectedOutput, result);
        }
    }
}
