
public class Program
{
    public static void Main(string[] args)
    {
   
        List<Course> courses = new List<Course>();

        DaytimeCourse daytimeCourse = new DaytimeCourse
        {
            Name = "advance C#",
            CourseCode = "CMSK-0200-FS22(2)",
            Description = "This is a daytime course",
            InstructorName = "Trevor Bonner",
            NumberOfStudents = 29,
            SectionNumber = 570,
            BlockNumber = "Allard Hall ",
            CertificateID = "PP100-Y2"
        };
        courses.Add(daytimeCourse);

        EveningCourse eveningCourse = new EveningCourse
        {
            Name = "advance C#",
            CourseCode = "CMSK-0200-FS22(2)",
            Description = "This is an evening course",
            InstructorName = "Trevor Bonner",
            NumberOfStudents = 15,
            ContractorID = "CVEN-9982",
            ContractEndDate = DateTime.Now.AddMonths(6)
        };
        courses.Add(eveningCourse);

     
        foreach (var course in courses)
        {
            Console.WriteLine($"Course: {course.Name}");
            Console.WriteLine($"Description: {course.Description}");
            Console.WriteLine($"Type: {course.CourseType()}\n");
        }
    }
}