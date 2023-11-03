using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        public override string Introduce()
        {
            if (this.ClassNumber == -1)
            {
                return $"{base.Introduce()} I am a student.";
            }
            else
            {
                return $"{base.Introduce()} I am a student of class {this.ClassNumber}.";
            }
        }
    }
}
