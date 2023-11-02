using System;
using System.Collections.Generic;

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

        [Fact]
        public void Should_return_teacher_in_class_introduction_when_teacher_given_introduction_in_class()
        {
            string name = "Jenny";
            int age = 32;

            var teacher = new Teacher(name, age,"class1");
            var class1 = new Class();
            class1.AddPersonToClass(teacher);
            var introduction = class1.Speak();
            Console.WriteLine(introduction[0]);
            Assert.Equal(new List<string>
            {
                "My name is Jenny, I am 32 years old. I am a teacher of class1."
            }, introduction);
        }

        [Fact]
        public void Should_return_student_in_class_introduction_when_student_given_introduction_in_class()
        {
            string name = "Tom";
            int age = 14;

            var student = new Student(name, age, "class1");
            var class1 = new Class();
            class1.AddPersonToClass(student);
            var introduction = class1.Speak();
            Console.WriteLine(introduction[0]);
            Assert.Equal(new List<string>
            {
                "My name is Tom, I am 14 years old. I am a student of class1."
            }, introduction);
        }

        [Fact]
        public void Should_return_student_and_teacher_in_class_introduction_when_they_given_introduction_in_class()
        {
            var student = new Student("Tom", 14, "class1");
            var teacher = new Teacher("Jenny", 32, "class1");
            var class1 = new Class();
            class1.AddPersonToClass(student);
            class1.AddPersonToClass(teacher);
            var introduction = class1.Speak();
            Console.WriteLine(introduction[0]);
            Assert.Equal(new List<string>
            {
                "My name is Tom, I am 14 years old. I am a student of class1.",
                "My name is Jenny, I am 32 years old. I am a teacher of class1."
            }, introduction);
        }

        [Fact]
        public void Should_return_welcome_in_class_introduction_when_they_welcome_newcomer_in_class()
        {
            var student = new Student("Tom", 14, "class1");
            var teacher = new Teacher("Jenny", 32, "class1");
            var class1 = new Class();
            class1.AddPersonToClass(student);
            var welcome = class1.AddPersonToClass(teacher);
            Assert.Equal(new List<string>
            {
                "My name is Tom, I am 14 years old. I am a student of class1. Welcome Jenny join class1."
            }, welcome);
        }
    }
}
