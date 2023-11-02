using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        public Teacher()
        {
        }

        public Teacher(string name, int age) : base(name, age)
        {
        }

        //public Teacher(string name, int age, int classNumber) : base(name, age)
        //{
        //    ClassNumber = classNumber;
        //}

        public int ClassNumber { get; set; } = -1;

        public override string SelfIntroduce()
        {
            var str = base.SelfIntroduce();
            if (ClassNumber == -1)
            {
                return str + " I am a teacher.";
            }
            else
            {
                return str + $" I am a teacher of class {ClassNumber}.";
            }
        }
    }
}
