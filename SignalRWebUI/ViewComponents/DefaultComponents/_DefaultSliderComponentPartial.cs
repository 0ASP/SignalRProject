using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.DtoLayer.SliderDto;
using System.Net.Http;

namespace SignalRWebUI.ViewComponents.DefaultComponents
{


	public class _DefaultSliderComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _DefaultSliderComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7289/api/Sliders");
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultSliderDto>>(jsonData);
			return View(values);
		}
	}
}
