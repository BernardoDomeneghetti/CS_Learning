using System;
using System.Data.SqlClient;
using HolidaysFeederService.Services.Main;
using HolidaysFeederService.Response.HolidayRepositoryReponse;

namespace HolidaysFeederService
{
    class Program
    {
        static void Main(String[] args)
        {
            HolidaysMainFeederService feeder = new HolidaysMainFeederService();            
            var responses = feeder.UpdateHolidays(DateTime.Now.Year);
            foreach ( HolidayAppendResponse response in responses)
            {
                try
                {
                    Console.WriteLine(
                        $"{response.Message}: {response.Holiday.Day}/{response.Holiday.Month}/{response.Holiday.Year} - {response.Holiday.Description}"
                    );
                }
                catch(Exception e)
                {
                    Console.WriteLine(
                        $"ERRO ao inserir feriado: {e.Message}"
                    );
                }
                
            }
        }
    }
}
