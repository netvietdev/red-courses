using Mapping.AutoMapper;
using RedCourses.Data.RavenImpl.Documents;
using RedCourses.Domain;

namespace RedCourses.Data.RavenImpl.Mappers
{
    public class VideoMapFactory : AutoMapperFactory<Video, VideoDocument>
    {
    }
}
