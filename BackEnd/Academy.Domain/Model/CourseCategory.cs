namespace Academy.Domain.Model
{
    public class CourseCategory
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public CourseCategory Parent { get; set; }
    }
}
