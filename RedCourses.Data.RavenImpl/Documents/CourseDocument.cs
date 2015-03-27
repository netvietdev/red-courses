using System;
using System.Collections.Generic;

namespace RedCourses.Data.RavenImpl.Documents
{
    public class CourseDocument
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<VideoDocument> Videos { get; private set; }

        public CourseDocument()
        {
            Videos = new List<VideoDocument>();
        }
    }
}
