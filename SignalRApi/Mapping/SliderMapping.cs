using AutoMapper;
using SignalR.DtoLayer.SliderDto;
using SignalR.Entity.Entities;

namespace SignalRApi.Mapping
{
	public class SliderMapping : Profile
	{
        public SliderMapping()
        {
			CreateMap<Slider, ResultSliderDto>().ReverseMap();
			CreateMap<Slider, CreateSliderDto>().ReverseMap();
			CreateMap<Slider, GetSliderDto>().ReverseMap();
			CreateMap<Slider, UpdateSliderDto>().ReverseMap();
		}
    }
}
