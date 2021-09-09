using System;
using System.Data;
using System.Data.SqlClient;

namespace HolidaysFeederService.Repositories.Commom
{
    public sealed class DbSession : IDisposable
    {
        public IDbConnection Connection { get; set; }
        public IDbTransaction Transaction { get; set; }

        public DbSession()
        {

            // PRODUÇAO

            //Connection = new SqlConnection(new Database.Connection.Database().GetConnectionString("user_system_hysoft", "PAYMENT"));

            // DEV
            Connection = new SqlConnection(new DatabaseCore.Connection.Database().GetConnectionString());

            //string ConnectionString = ("user id=user_system_hysoft;" +
            //   "password=VGhdm{MxVW3@9K#;Network Address=dbhm.hysoft.com.br; " +
            //   "Persist Security Info=true; " +
            //   "database=PAYMENTPIXHM; " +
            //   "connection timeout=300");

            //Connection = new SqlConnection(ConnectionString);
        }

        public bool IsConnectionOpen()
        {
            try
            {
                if (Connection == null)
                {
                    return false;
                }

                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                    return true;
                }

                return true;

            } catch
            {                
                return false;
            }
        }

        public bool CloseConection()
        {
            try
            {
                if (Transaction != null)
                {
                    return false;
                }

                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                    return true;
                }

                return true;

            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            //Connection?.Close();
            //Connection?.Dispose();
        }     
    }
}