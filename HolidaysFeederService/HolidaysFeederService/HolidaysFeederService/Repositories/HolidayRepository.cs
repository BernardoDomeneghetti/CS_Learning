using HolidaysFeederService.Models.Entities;
using HolidaysFeederService.Response.HolidayRepositoryReponse;
using HolidaysFeederService.Repositories.Commom;
using Dapper;
using System.Collections.Generic;
using System;

namespace HolidaysFeederService.Repositories
{
    class HolidayRepository: DapperBaseRepository
    {   
        public HolidayAppendResponse HolidayAppend(Holiday holiday)
        {
            try
            {
                string statement =
                    @"INSERT INTO holiday (Day, Month, Year, Description ) VALUES (@Day, @Month, @Year, @Description);";

                if (_session.IsConnectionOpen())
                {
                    _session.Connection.Execute(statement,param: holiday);
                }
                return new HolidayAppendResponse(true, "Holiday updated successfully", holiday);
            }
            catch(Exception e)
            {

                return new HolidayAppendResponse(false, "Holiday update failed", null);
            }
            finally
            {
                _session.CloseConection();
            }
        }
        public HolidayListResponse HolidayList()
        {
            List<Holiday> list = null;
            try
            {
                string statement = @"SELECT * FROM holiday;";

                if (_session.IsConnectionOpen())
                {
                    list = (List<Holiday>)_session.Connection.Query<Holiday>(statement);
                }
                return new HolidayListResponse(true, "Holiday updated successfully", list);
            }
            catch
            {
                return new HolidayListResponse(false, "Holiday update failed", null);
            }
            finally
            {
                _session.CloseConection();
            }
        }

    }
}
