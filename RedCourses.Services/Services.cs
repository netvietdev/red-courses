namespace RedCourses.Services
{
    public class Services
    {
        private static readonly CourseService CourseService = new CourseService();

        public static CourseService Course
        {
            get { return CourseService; }
        }
    }
}
