using System.Collections.Generic;

namespace OOStepByStep;

public class Class
{
    //public List<Student> students = new List<Student>();
    //public Teacher teacher = new Teacher("Peggy",30);
    public List<Person> persons = new List<Person>();
    public Class(){}


    public void AddPersonToClass(Person person)
    {
        if (person is Student)
        {
            persons.Add(person);
        }
        else if(person is Teacher)
        {
            foreach (var pers in persons)
            {
                if (pers is Teacher)
                {
                    return;
                }
            }
            persons.Add(person);
        }
    }

    public List<string> Speak()
    {
        var allSpeak = new List<string>();
        foreach (var person in persons)
        {
            string oneSpeak="";
            if (person is Student)
            {
                oneSpeak = person.Speak();
            }
            else if (person is Teacher)
            {
                oneSpeak = person.Speak();
            }
            allSpeak.Add(oneSpeak);
        }
        return allSpeak;
    }
    
}