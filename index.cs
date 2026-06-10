public class Student
{
    public string Id{get; set;} = "";
    public string Name{get; set;} = "";
    public int Age;
    public decimal GPA;
}


public class Course
{
    public string Code{get; set;} = "";
    //public int Code;
    public string Title{get; set;} = "";
    public int Capacity;
}
