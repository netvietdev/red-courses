using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RedCourses.Domain
{
    public class Course
    {
        private readonly IList<Video> _videos = new List<Video>();

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IReadOnlyCollection<Video> Videos
        {
            get { return new ReadOnlyCollection<Video>(_videos); }
        }

        public void AddVideo(Video video)
        {
            if (_videos.Contains(video) == false)
            {
                _videos.Add(video);
            }
        }

        public void RemoveVideo(Video video)
        {
            if (_videos.Contains(video))
            {
                _videos.Remove(video);
            }
        }
    }
}
