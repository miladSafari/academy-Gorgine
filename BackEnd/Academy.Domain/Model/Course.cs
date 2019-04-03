namespace Academy.Domain.Model
{
    public class Course
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public CourseCategory Category { get; set; }
    }
}
