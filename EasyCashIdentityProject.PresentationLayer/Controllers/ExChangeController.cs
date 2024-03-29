﻿using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    public class ExChangeController : Controller
    {

        public async Task<IActionResult> Index()
        {
            #region DOLAR-TL
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=USD&to=TRY&q=1.0"),
                Headers =
    {
        { "X-RapidAPI-Key", "fa48e33451msh76e72f0777ec4cep19159ajsn516a9a848a48" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ViewBag.UsdToTry = body.Substring(0, 7);
            }
            #endregion



            #region EURO-TL
            var client1 = new HttpClient();
            var request1 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=EUR&to=TRY&q=1.0"),
                Headers =
    {
        { "X-RapidAPI-Key", "fa48e33451msh76e72f0777ec4cep19159ajsn516a9a848a48" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var response1 = await client.SendAsync(request1))
            {
                response1.EnsureSuccessStatusCode();
                var body1 = await response1.Content.ReadAsStringAsync();
                ViewBag.EurToTry = body1.Substring(0,7);
            }
            #endregion





            #region STERLİN-TL
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=GBP&to=TRY&q=1.0"),
                Headers =
    {
        { "X-RapidAPI-Key", "fa48e33451msh76e72f0777ec4cep19159ajsn516a9a848a48" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var response2 = await client.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ViewBag.GbpToTry = body2.Substring(0, 7);
            }
            #endregion






            #region EURO-DOLAR
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=USD&to=EUR&q=1.0"),
                Headers =
    {
        { "X-RapidAPI-Key", "fa48e33451msh76e72f0777ec4cep19159ajsn516a9a848a48" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var response3 = await client.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                ViewBag.UsdToEur = body3.Substring(0, 7);
            }
            #endregion

            return View();
        }

    }
}
