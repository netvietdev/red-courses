using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Http;

namespace RedCourses.UI.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "CourseByIdWithStyleApi",
                routeTemplate: "api/Courses/{id}/{style}",
                defaults: new { controller = "Courses" }
            );

            config.Routes.MapHttpRoute(
                name: "CourseVideosApi",
                routeTemplate: "api/Course/{id}/video/{videoId}",
                defaults: new { controller = "Courses" }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            config.Formatters.JsonFormatter.SerializerSettings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }
    }
}
