using System;

namespace RedCourses.Services
{
    public class VideoDto
    {
        public VideoDto()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
