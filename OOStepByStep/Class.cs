using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Class
    {
        private Teacher teacher;
        private List<Student> students = new List<Student>();
        public int classNumber;

       // private int _classNumber;
        //public int ClassNumber { get=>_classNumber; }
        public Class(int classNumber, Teacher teacher)
        {
            this.classNumber = classNumber;
            this.teacher = teacher;
        }

        public string AddStudent(Student student)
        {
            students.Add(student);
            student.classnum = classNumber;
            StringBuilder modifiedIntro = new StringBuilder();
            modifiedIntro.AppendLine($"{teacher.SelfIntro()} Welcome {student.name} join class {this.classNumber}.");
            foreach (var onestudent in students)
            {
                if (onestudent.name != student.name)
                {
                    modifiedIntro.AppendLine($"{onestudent.SelfIntro()} Welcome {student.name} join class {this.classNumber}.");
                }
            }
            return modifiedIntro.ToString();


        }
    }
}
