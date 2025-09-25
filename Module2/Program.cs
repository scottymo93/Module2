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
        student1.AddGrade(99.1);
        student1.AddGrade(94,97,99.4,50,77.77);
        
        
        var student2 = new Student();
        student2.Name = "Zion";
        student2.ID = 2;
        students.Add(student2);
        student2.AddGrade(99.2);
        student2.AddGrade(94,99,99.4,80,97.77);
        
        var student3 = new Student();
        student3.Name = "Mercy";
        student3.ID = 3;
        students.Add(student3);
        student3.AddGrade(99.3);
        student3.AddGrade(95,97,99.4,100,87.77);
        
        var student4 = new Student();
        student4.Name = "Maverick";
        student4.ID = 4;
        students.Add(student4);
        student4.AddGrade(99.4);
        student4.AddGrade(100,97,99.4,100,97.77);

        foreach (var student in students)
        {
            Console.WriteLine($"Student Name: {student.Name}");
            Console.WriteLine($"Student ID: {student.ID}");
            foreach (var grade in student.Grades)
            {
                Console.WriteLine($"Student Grades: {grade}");
            }
            Console.WriteLine($"Student Average Grade: {student.CalculateAverageGrade()}");
            Console.WriteLine();
        }

        var mathClass = new Course();
        mathClass.CourseName = "Math";
        mathClass.CourseCode = "101";
        mathClass.EnrollStudent(student1);
        mathClass.EnrollStudent(student2);
        Console.WriteLine($"Welcome to {mathClass.CourseName} {mathClass.CourseCode}. Here are the following enrolled students:");
        foreach (var student in mathClass.EnrolledStudents)
        {
            Console.WriteLine(student.Name);
        }
        
    }
}