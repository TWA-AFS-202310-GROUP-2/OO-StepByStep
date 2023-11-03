namespace OOStepByStepTest
{
    using OOStepByStep;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Security.Cryptography;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_return_name_age_When_Introduct_Given_name_age()
        {//given
            var person = new Person { Name = "Tom", Age = 21 };
            //when
            string introduction = person.Introduct();
            //then
            Assert.Equal("My name is Tom. I am 21 years old.", introduction);
        }

        [Fact]
        public void Should_return_student_name_age_When_Introduct_Given_name_age_student()
        {//given
            var student = new Student { Name = "Tom", Age = 21 };
            //when
            string studentIntroduction = student.Introduct();
            //then
            Assert.Equal("My name is Tom. I am 21 years old. I am a student.", studentIntroduction);
        }

        [Fact]
        public void Should_return_teacher_name_age_When_Introduct_Given_name_age_teacher()
        {//given
            var teacher = new Teacher { Name = "Amy", Age = 30 };
            //when
            string teacherIntroduction = teacher.Introduct();
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", teacherIntroduction);
        }

        [Fact]
        public void Should_return_student_class_name_age_When_Introduct_Given_name_age_student()
        {//given
            var student = new Student("Class 2") { Name = "Tom", Age = 21 };

            //when
            string studentIntroduction = student.Introduct();
            //then
            Assert.Equal("My name is Tom. I am 21 years old. I am a student of Class 2.", studentIntroduction);
        }

        [Fact]
        public void Should_return_teacher_class_name_age_When_Introduct_Given_name_age_teacher()
        {//given
            var teacher = new Teacher("Class 2") { Name = "Amy", Age = 30 };
            //when
            string teacherIntroduction = teacher.Introduct();
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of Class 2.", teacherIntroduction);
        }

        [Fact]
        public void Should_return_teacher_welcome_class_name_age_When_Introduct_Given_name_age_teacher()
        {//given
            var newstudent = new Student { Name = "Ben", Age = 19 };
            Class1 class1 = new Class1("Class 2")
            {
                Teacher = new Teacher("Class 2") { Name = "Amy", Age = 30 },
                StudentList = new List<Student>
                {
                    new Student("Class 2") { Name = "Lily", Age = 18 },
                    //new Student { Name = "John", Age = 19, ClassName = "Class 2" },
                },
            };

            //when
            string reulst = class1.AddStudents(newstudent);
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of Class 2. Welcome Ben join Class 2.\r\n" +
                "My name is Lily. I am 18 years old. I am a student of Class 2. Welcome Ben join Class 2.\r\n", reulst);
        }

        [Fact]
        public void Should_return_error_When_add_existed_student_Given_student()
        {//given
            Class1 class1 = new Class1("Class 2")
            {
                Teacher = new Teacher("Class 2") { Name = "Amy", Age = 30 },
                StudentList = new List<Student>
                {
                    new Student("Class 2") { Name = "Lily", Age = 18 },
                    new Student("Class 2") { Name = "John", Age = 19 },
                },
            };
            var newstudent = new Student("Class 2") { Name = "Lily", Age = 18 };
            //when
            string reulst = class1.AddStudents(newstudent);
            //then
            Assert.Equal("The student has been in our class.", reulst);
        }

        [Fact]
        public void Should_return_null_When_add_student_Given_null_class()
        {//given
            Class1 class1 = new Class1("Class 2")
            {
                Teacher = new Teacher(),
                StudentList = new List<Student>
                {
                },
            };
            var newstudent = new Student("Class 2") { Name = "Lily", Age = 18 };
            //when
            string reulst = class1.AddStudents(newstudent);
            //then
            Assert.Equal("Lily is the first student of Class 2", reulst);
        }
    }
}
