using System;

namespace HolidaysFeederService.Repositories.Commom
{
    public abstract class DapperBaseRepository
    {
        public DbSession _session;

        public DapperBaseRepository()
        {
            _session = new DbSession();
        }
    }
}