using System;

namespace RedCourses.Data.RavenImpl.Documents
{
    public class VideoDocument
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
