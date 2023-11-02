namespace OOStepByStep;
using System.Collections.Generic;
using System.Text;
public class Class
{
    public Teacher Teacher { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();
    public int ClassNumber { get; set; }

    public string AddStudent(Student student)
    {
        Students.Add(student);

        student.ClassNumber = ClassNumber;

        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"{Teacher.Introduce()} Welcome {student.Name} join class {ClassNumber}.");

        foreach (var stud in Students)
        {
            if (stud.Name != student.Name)
            {
                sb.AppendLine($"{stud.Introduce()} Welcome {student.Name} join class {ClassNumber}.");
            }
        }

        return sb.ToString();
    }
}