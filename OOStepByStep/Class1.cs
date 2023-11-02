namespace OOStepByStep
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Class1
    {
        private string className = string.Empty;
        public Class1(string classNmae)
        {
            this.className = classNmae;
        }

        public Teacher Teacher { get; set; }
        public Student Student { get; set; }

        public List<Student> StudentList { get; set; } = new List<Student>();

        public string AddStudents(Student student)
        {
            if (StudentList.Any(item => item.Name == student.Name))
            {
                return "The student has been in our class.";
            }

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{Teacher.Introduct()} Welcome {student.Name} join {className}.");
            foreach (var student1 in StudentList)
            {
                stringBuilder.AppendLine($"{student1.Introduct()} Welcome {student.Name} join {className}.");
            }

            StudentList.Add(student);
            return stringBuilder.ToString();
        }
    }
}
