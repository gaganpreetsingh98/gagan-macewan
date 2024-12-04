public class EveningCourse : Course
{
    public string ContractorID { get; set; }
    public DateTime ContractEndDate { get; set; }


    public override string CourseType()
    {
        return "Evening";
    }
}
