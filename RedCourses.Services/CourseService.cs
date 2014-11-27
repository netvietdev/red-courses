using System;
using System.Collections.Generic;
using System.Linq;

namespace RedCourses.Services
{
    public class CourseService
    {
        private readonly IList<CourseDto> _courses = new List<CourseDto>();

        public IList<CourseDto> GetAll()
        {
            return _courses;
        }

        public CourseDto GetById(Guid courseId)
        {
            return _courses.Single(c => c.Id == courseId);
        }

        public void AddCourse(CourseDto course)
        {
            _courses.Add(course);
        }

        public void DeleteCourse(CourseDto course)
        {
            _courses.Remove(course);
        }

        public void DeleteCourse(Guid courseId)
        {
            var course = _courses.Single(c => c.Id == courseId);
            DeleteCourse(course);
        }

        public void UpdateCourse(Guid courseId, CourseDto course)
        {
            var existingCourse = _courses.Single(c => c.Id == courseId);
            existingCourse.Name = course.Name;
            existingCourse.Description = course.Description;
        }

        public void AddVideo(Guid courseId, VideoDto video)
        {
            var course = GetById(courseId);
            course.Videos.Add(video);
        }

        public void DeleteVideo(Guid courseId, Guid videoId)
        {
            var course = GetById(courseId);
            var video = course.Videos.Single(v => v.Id == videoId);
            course.Videos.Remove(video);
        }

        public void UpdateVideo(Guid courseId, Guid videoId, VideoDto video)
        {
            var course = GetById(courseId);
            var existingVideo = course.Videos.Single(v => v.Id == videoId);
            existingVideo.Url = video.Url;
            existingVideo.Description = video.Description;
        }
    }
}
