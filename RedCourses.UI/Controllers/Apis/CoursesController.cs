using RedCourses.Services;
using System;
using System.Web.Http;

namespace RedCourses.UI.Controllers.Apis
{
    public class CoursesController : ApiController
    {
        // GET: /api/Course
        public dynamic GetAllCourses()
        {
            return Services.Services.Course.GetAll();
        }

        // GET: /api/Course/{id}
        public dynamic GetCourseById(Guid id)
        {
            return Services.Services.Course.GetById(id);
        }

        // GET: /api/Course/{id}/{style}:details
        public dynamic GetCourseById(Guid id, string style)
        {
            return Services.Services.Course.GetById(id);
        }

        // POST: /api/Course
        public void Post(CourseDto course)
        {
            Services.Services.Course.AddCourse(course);
        }

        // PUT: /api/Course/{id}
        public void Put(Guid id, CourseDto course)
        {
            Services.Services.Course.UpdateCourse(id, course);
        }

        // DELETE: /api/Course/{id}
        public void Delete(Guid id)
        {
            Services.Services.Course.DeleteCourse(id);
        }

        // POST: /api/Course/{courseId}/video
        [HttpPost]
        public void AddVideo(Guid id, VideoDto video)
        {
            Services.Services.Course.AddVideo(id, video);
        }

        // DELETE: /api/Course/{id}/video/{videoId}
        [HttpDelete]
        public void DeleteVideo(Guid id, Guid videoId)
        {
            Services.Services.Course.DeleteVideo(id, videoId);
        }

        // DELETE: /api/Course/{courseId}/video/{videoId}
        [HttpPut]
        public void UpdateVideo(Guid courseId, Guid videoId, VideoDto video)
        {
            Services.Services.Course.UpdateVideo(courseId, videoId, video);
        }
    }
}
