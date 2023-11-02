using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using OOStepByStep;

namespace OOStepByStepTest
{
    public class PersonTest
    {
        [Theory]
        [InlineData("Tom", 21)]
        public void Should_show_msg_when_person_self_introduce_given_name_age(string name, int age)
        {
            Person person = new Person(name, age);

            string msg = person.SelfIntro();

            Assert.Equal($"My name is Tom. I am 21 years old.", msg);
        }
    }
}
