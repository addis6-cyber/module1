public record EnrollmentRecord(
    string StudentId,
    string CourseCode,
    DateTime EnrolledAt
);

public class Student
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public decimal GPA { get; set; }
}

public class Course
{
    public string Code { get; set; } = "";
    public string Title { get; set; } = "";
    public int Capacity { get; set; }
    public int EnrolledCount { get; set; }
}