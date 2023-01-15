using AutoMapper;

namespace NZWalks.API.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>();
                //if property names are different then need to do like below
                //.ForMember(dest=>dest.Id, options => options.MapFrom(src => src.Id));

                //reverse map is used to convert DTO to model
                //.ReverseMap();


        }
    }
}
