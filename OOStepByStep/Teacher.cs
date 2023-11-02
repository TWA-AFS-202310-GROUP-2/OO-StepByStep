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
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, int classNumber) : base(name, age, classNumber)
        {
            this.classnum = classNumber;
        }

        public override string SelfIntro()
        {
            if (this.classnum != 0)
            {
                return $"{base.SelfIntro()} I am a teacher of class {this.classnum}";
            }
            else
            {
                return base.SelfIntro() + " I am a teacher.";
            }
        }
    }
}
