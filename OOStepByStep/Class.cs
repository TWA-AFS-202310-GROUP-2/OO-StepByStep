namespace OOStepByStep;
using System.Collections.Generic;
public class Class
{
    public Teacher Teacher { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();
    public int ClassNumber { get; set; }
}