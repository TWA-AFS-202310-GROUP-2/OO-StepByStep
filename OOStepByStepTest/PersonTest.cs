using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using OOStepByStep;

namespace OOStepByStepTest
{
    public class PersonTest
    {
        // AC1 test
        [Theory]
        [InlineData("Tom", 21)]
        public void Should_show_msg_when_person_self_introduce(string name, int age)
        {
            Person person = new Person(name, age);

            string msg = person.SelfIntro();

            Assert.Equal($"My name is {name}. I am {age} years old.", msg);
        }

        // AC2 test
        [Theory]
        [InlineData("Tom", 18)]
        public void Should_show_msg_when_student_self_introduce(string name, int age)
        {
            Student student = new Student(name, age);

            string msg = student.SelfIntro();

            Assert.Equal($"My name is {name}. I am {age} years old. I am a student.", msg);
        }

        [Theory]
        [InlineData("Amy", 30)]
        public void Should_show_msg_when_teacher_self_introduce(string name, int age)
        {
            Teacher teacher = new Teacher(name, age);

            string msg = teacher.SelfIntro();

            Assert.Equal($"My name is {name}. I am {age} years old. I am a teacher.", msg);
        }

        // AC3 test
        [Theory]
        [InlineData("Tom", 18, 2)]
        public void Should_show_msg_when_student_self_introduce_given_class(string name, int age, int classnum)
        {
            Student student = new Student(name, age, classnum);

            string msg = student.SelfIntro();

            Assert.Equal($"My name is {name}. I am {age} years old. I am a student of class {classnum}", msg);
        }

        [Theory]
        [InlineData("Amy", 30, 2)]
        public void Should_show_msg_when_teacher_self_introduce_given_class(string name, int age, int classnum)
        {
            Teacher teacher = new Teacher(name, age, classnum);

            string msg = teacher.SelfIntro();

            Assert.Equal($"My name is {name}. I am {age} years old. I am a teacher of class {classnum}", msg);
        }

        // AC4
        [Fact]
        public void Should_show_empty_when_first_student_add_to_class()
        {
            int classnum = 2;
            string student_name = "Tim";
            int student_age = 18;

            Class class2 = new Class(classnum);
            var studentTim = new Student(student_name, student_age, classnum);

            string result = class2.AddStudent(studentTim);

            string expectedOutput ="\r\n";
            Assert.Equal(expectedOutput, result);

        }

        [Fact]
        public void Should_show_intro_msg_when_addStudent_to_class()
        {
            string teacher_name = "Amy";
            int teacher_age = 30;
            int classnum = 2;
            Teacher teacher = new Teacher(teacher_name, teacher_age, classnum);
            Class class2 = new Class(classnum, teacher);

            string student_name1 = "Tom";
            int student_age1 = 18;

            string student_name2 = "Jim";
            int student_age2 = 18;

            var studentTom = new Student(student_name1, student_age1, classnum);
            var studentJim = new Student(student_name2, student_age2, classnum);

            class2.AddStudent(studentTom);

            var result = class2.AddStudent(studentJim);

            var expectedOutput =
                "My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Jim join class 2.\r\n" +
                "My name is Tom. I am 18 years old. I am a student of class 2. Welcome Jim join class 2.\r\n";
            Assert.Equal(expectedOutput, result);
        }
    }
}