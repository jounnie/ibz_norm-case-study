using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using last_minute_shared;
using Microsoft.AspNetCore.Components;

namespace LastMinuteServiceClient
{
    public class FlightsService
    {
        private readonly HttpClient _httpClient;

        public FlightsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Flights[]> LoadFlights()
        {
            var jsonAsync = await _httpClient.GetJsonAsync<Flights[]>("localhost:5000/api/flights");
            return jsonAsync;
        }
    }
}