namespace OOStepByStep;

public class Person
{
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public virtual string Speak()
    {
        return $"My name is {name}, I am {age} years old.";
    }

}