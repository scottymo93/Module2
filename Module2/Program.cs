namespace Module2;

class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>();
        
        var student1 = new Student();
        student1.Name = "Scott";
        student1.ID = 1;
        students.Add(student1);
        
        var student2 = new Student();
        student2.Name = "Zion";
        student2.ID = 2;
        students.Add(student2);
        
        var student3 = new Student();
        student3.Name = "Mercy";
        student3.ID = 3;
        students.Add(student3);
        
        var student4 = new Student();
        student4.Name = "Maverick";
        student4.ID = 4;
        students.Add(student4);
        
    }
}