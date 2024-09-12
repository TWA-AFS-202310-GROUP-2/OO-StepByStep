using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private int classnum;
        private string classIntroduction = string.Empty;
        public Teacher(string name, int age) : base(name, age)
        {
            this.classIntroduction = $" I am a teacher.";
        }

        public Teacher(string name, int age, int classNumber) : base(name, age, classNumber)
        {
            this.classnum = classNumber;
            this.classIntroduction = $" I am a teacher of class {classNumber}.";
        }

        public override string SelfIntro()
        {
            return base.SelfIntro() + this.classIntroduction;
        }
    }
}
