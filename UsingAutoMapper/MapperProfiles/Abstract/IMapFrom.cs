using AutoMapper;

namespace UsingAutoMapper.MapperProfiles.Abstract
{
    public interface IMapFrom<T>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}