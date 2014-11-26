using System;

namespace RedCourses.Services
{
    public class Video
    {
        public Video()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
