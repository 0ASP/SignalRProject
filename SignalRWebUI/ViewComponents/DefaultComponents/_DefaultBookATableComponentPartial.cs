﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.DtoLayer.BookingDto;

namespace SignalRWebUI.ViewComponents.DefaultComponents
{
	public class _DefaultBookATableComponentPartial : ViewComponent
	{
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultBookATableComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7289/api/Booking");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
            return View(values);
        }
    }
}
