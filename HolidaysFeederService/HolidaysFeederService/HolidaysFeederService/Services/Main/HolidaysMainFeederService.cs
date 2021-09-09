using HolidaysFeederService.Models.ApiModels;
using HolidaysFeederService.Models.Entities;
using HolidaysFeederService.Repositories;
using HolidaysFeederService.Response.HolidayRepositoryReponse;
using HolidaysFeederService.Services.HolidayApiConsume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidaysFeederService.Services.Main
{
    public class HolidaysMainFeederService
    {
        public async Task<HolidayApi[]> GetHolidaysArray(int year)
        {
            HolidaysJsonDeserializer deserializer = new HolidaysJsonDeserializer();
            return await deserializer.SendGet(year);
        }
        public List<HolidayAppendResponse> UpdateHolidays(int year)
        {
            var repo = new HolidayRepository();
            var apiList = GetHolidaysArray(year).Result;
            List<HolidayAppendResponse> responses = new List<HolidayAppendResponse>();

            foreach (HolidayApi holiday in apiList)
            {                
                var date = Convert.ToDateTime(holiday.Date);
                responses.Add(
                    repo.HolidayAppend(
                        new Holiday(
                            date.Day,
                            date.Month,
                            date.Year,
                            holiday.Name
                        )
                    )
                );                
            }

            var easterFriday = Convert.ToDateTime($"01/04/{year}");
            while (easterFriday.DayOfWeek != DayOfWeek.Friday)
            {
                easterFriday = easterFriday.AddDays(1);
            }
            responses.Add(
                repo.HolidayAppend(
                    new Holiday(
                            easterFriday.Day,
                            easterFriday.Month,
                            easterFriday.Year,
                            "Sexta feira santa"
                        )
                )
            );

            return responses;
        }
         
    }
}
