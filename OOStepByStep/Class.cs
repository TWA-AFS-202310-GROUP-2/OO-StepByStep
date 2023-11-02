using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Class
    {
        private Teacher teacher;
        public Class(int classNumber)
        {
            ClassNumber = classNumber;
        }

        public Class(int classNumber, Teacher teacher)
        {
            Teacher = teacher;
            teacher.ClassNumber = classNumber;
            ClassNumber = classNumber;
        }

        public Teacher Teacher
        {
            get
            {
                return teacher;
            }
            set
            {
                teacher = value;
                teacher.ClassNumber = ClassNumber;
            }
        }

        public List<Student> Students { get; set; } = new List<Student>();

        public int ClassNumber { get; set; }

        public string JoinStudent(Student student)
        {
            Students.Add(student);
            student.ClassNumber = ClassNumber;
            StringBuilder sb = new StringBuilder();

            if (Teacher != null)
            {
                sb.AppendLine($"{Teacher?.SelfIntroduce()} Welcome {student.Name} join class {ClassNumber}.");
            }

            for (int i = 0; i < Students.Count - 1; i++)
            {
                sb.AppendLine($"{Students[i]?.SelfIntroduce()} Welcome {student.Name} join class {ClassNumber}.");
            }

            return sb.ToString().Trim();
        }
    }
}
