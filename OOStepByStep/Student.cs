using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        public int classnum;
        private string classIntroduction = String.Empty;
        public Student(string name, int age) : base(name, age)
        {
            this.classIntroduction = $" I am a student.";
        }

        public Student(string name, int age, int classNumber) : base(name, age, classNumber)
        {
            this.classnum = classNumber;
            this.classIntroduction = $" I am a student of class {classNumber}.";
        }

        public override string SelfIntro()
        {
            return base.SelfIntro() + this.classIntroduction;
        }
    }
}
