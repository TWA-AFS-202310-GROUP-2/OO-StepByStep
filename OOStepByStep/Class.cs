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
        private List<Student> students = new List<Student>();
        private int classNumber;

        public Class(int classNumber, Teacher teacher)
        {
            this.classNumber = classNumber;
            this.teacher = teacher;
            this.teacher.ClassNumber = classNumber;
        }

        public string AddStudent(Student student)
        {
            student.ClassNumber = classNumber;

            string welcomeStr = string.Empty;

            welcomeStr += $"{teacher.Introduce()} Welcome {student.Name} join class {classNumber}.\n";

            foreach (var stud in students)
            {
                welcomeStr += $"{stud.Introduce()} Welcome {student.Name} join class {classNumber}.\n";
            }

            students.Add(student);

            return welcomeStr;
        }
    }
}
