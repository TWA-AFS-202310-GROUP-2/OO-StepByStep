using System.Collections.Generic;
using System.Linq;

namespace OOStepByStep;

public class Class
{
    public List<Person> persons = new List<Person>();
    public List<string> AddPersonToClass(Person person)
    {
        List<string> welcome = new List<string>();
        if (persons.Count>0)
        {
            welcome = Speak();

            string className = person is Student?(person as Student).className:(person as Teacher).className;
            for(int i=0;i<welcome.Count;i++) 
            {
                welcome[i] = welcome[i] + $" Welcome {person.name} join {className}.";
            }
        }

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
                    return welcome;
                }
            }
            persons.Add(person);
        }
        return welcome;
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