namespace Module2;

public class Course
{
    public Course()
    {
     EnrolledStudents = new List<Student>();
    }
    public string CourseName { get; set; }
    public string CourseCode { get; set; }

    public List<Student> EnrolledStudents;

    public void EnrollStudent(Student student)
    {
        if (!EnrolledStudents.Contains(student))
        {
            EnrolledStudents.Add(student);
        }
    }
}