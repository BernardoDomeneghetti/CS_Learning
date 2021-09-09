using HolidaysFeederService.Models.ApiModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HolidaysFeederService.Services.HolidayApiConsume
{
    public class HolidaysJsonDeserializer {
        private HttpClient _client;
        public HttpClient Client { 
            get
            {
                if (_client == null)
                {
                    _client = new HttpClient();
                }
                return _client;
            }
        }
    
        public async Task<HolidayApi[]> SendGet(int year)
        {
            try
            {
                Client.BaseAddress = new Uri("http://brasilapi.com.br/api/feriados/v1/");
                HttpResponseMessage response = await Client.GetAsync(year.ToString());
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                
                return JsonConvert.DeserializeObject<HolidayApi[]>(content);
            }
            catch
            {
                throw;
            }
        } 
    }
}
