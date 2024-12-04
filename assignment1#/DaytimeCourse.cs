
// Daytime course class
public class DaytimeCourse : Course
{
    public int SectionNumber { get; set; }
    public string BlockNumber { get; set; }
    public string CertificateID { get; set; }

    // Override CourseType method to return specific type
    public override string CourseType()
    {
        return "Daytime";
    }
}
