using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        public Student()
        {
        }

        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classNumber) : base(name, age)
        {
            ClassNumber = classNumber;
        }

        public int ClassNumber { get; set; } = -1;

        public override string SelfIntroduce()
        {
            var str = base.SelfIntroduce();
            if (ClassNumber == -1)
            {
                return str + " I am a student.";
            }
            else
            {
                return str + $" I am a student of class {ClassNumber}";
            }
        }
    }
}
