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
        [Theory]
        [InlineData("Tom", 21)]
        public void Should_show_msg_when_person_self_introduce_given_name_age(string name, int age)
        {
            Person person = new Person(name, age);

            string msg = person.SelfIntro();

            Assert.Equal($"My name is {name}. I am {age} years old.", msg);
        }

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
    }
}
