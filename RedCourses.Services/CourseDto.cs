using System;

namespace RedCourses.Services
{
    public class CourseDto
    {
        public CourseDto()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
