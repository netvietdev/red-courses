using System.Linq;
using RedCourses.Services;
using System.Web.Http;

namespace RedCourses.UI.Controllers.Apis
{
    public class SetupController : ApiController
    {
        /// <summary>
        /// Initialize all sample data
        /// </summary>
        public dynamic Get()
        {
            if (!Services.Services.Course.GetAll().Any())
            {
                Services.Services.Course.AddCourse(new CourseDto()
                {
                    Name = "AngularJS",
                    Description = "HTML is great for declaring static documents, but it falters when we try to use it for declaring dynamic views in web-applications. AngularJS lets you extend HTML vocabulary for your application. The resulting environment is extraordinarily expressive, readable, and quick to develop."
                });

                Services.Services.Course.AddCourse(new CourseDto()
                {
                    Name = "JQuery",
                    Description = "jQuery is a fast, small, and feature-rich JavaScript library. It makes things like HTML document traversal and manipulation, event handling, animation, and Ajax much simpler with an easy-to-use API that works across a multitude of browsers. With a combination of versatility and extensibility, jQuery has changed the way that millions of people write JavaScript."
                });
            }
            return Services.Services.Course.GetAll();
        }
    }
}
