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
    }
}
