﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.Bussiness.Abstract;
using SignalR.DtoLayer.SliderDto;
using SignalR.Entity.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SlidersController : ControllerBase
	{
		private readonly ISliderService _sliderService;
		private readonly IMapper _mapper;

		public SlidersController(ISliderService sliderService, IMapper mapper)
		{
			_sliderService = sliderService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult SliderList()
		{
			var value = _mapper.Map<List<ResultSliderDto>>(_sliderService.TGetListAll());
			return Ok(value);
		}
		[HttpPost]
		public IActionResult CreateSlider(CreateSliderDto createSliderDto)
		{
			Slider Slider = new Slider()
			{
				Description1 = createSliderDto.Description1,
				Description2 = createSliderDto.Description2,
				Description3 = createSliderDto.Description3,
				Title1 = createSliderDto.Title1,
				Title2 = createSliderDto.Title2,
				Title3 = createSliderDto.Title3,
			};
			_sliderService.TAdd(Slider);
			return Ok("Rezervasyon Yapıldı.");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteSlider(int id)
		{
			var value = _sliderService.TGetById(id);
			_sliderService.TDelete(value);
			return Ok("Rezervasyon Silindi.");
		}
		[HttpPut]
		public IActionResult UpdateSlider(UpdateSliderDto updateSliderDto)
		{
			Slider Slider = new Slider()
			{
				SliderID = updateSliderDto.SliderID,
				Description1 = updateSliderDto.Description1,
				Description2 = updateSliderDto.Description2,
				Description3 = updateSliderDto.Description3,
				Title1 = updateSliderDto.Title1,
				Title2 = updateSliderDto.Title2,
				Title3 = updateSliderDto.Title3
			};
			_sliderService.TUpdate(Slider);
			return Ok("Rezervasyon Güncellendi.");
		}
		[HttpGet("{id}")]
		public IActionResult GetSlider(int id)
		{
			var value = _sliderService.TGetById(id);
			return Ok(value);
		}


	}
}
