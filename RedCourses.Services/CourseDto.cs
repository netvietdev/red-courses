using System;
using System.Collections.Generic;

namespace RedCourses.Services
{
    public class CourseDto
    {
        public CourseDto()
        {
            Id = Guid.NewGuid();
            Videos = new List<VideoDto>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IList<VideoDto> Videos { get; private set; }
    }
}
