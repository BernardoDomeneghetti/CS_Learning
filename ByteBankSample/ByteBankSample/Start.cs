using System;
using ByteBank.models;
using ByteBankSample.factories;
using ByteBank.helpers;



namespace ByteBankSample
{
    class Start
    {
        public static void Main(string[] args)
        {
            try
            {
                //Customer nardin = new Customer("Bernardo",0000,0,"Ativo");

                //CurrentAccount ac = CurrentAccountFactory.GetNumberedCurrentAccount(nardin, 100);

                //UserGUI.OutLine(ac.Balance.ToString());
                //ac.Deposit(0);
                //UserGUI.OutLine(ac.Balance.ToString());
                //ac.Deposit(100);
                //UserGUI.OutLine(ac.Balance.ToString());
                //ac.Withdraw(50);
                //UserGUI.OutLine(ac.Balance.ToString());
                ////ac.Withdraw(100);
                ////UserGUI.OutLine(ac.Balance);
                ///


                UserGUI.Out(URLArrgumentExtractorHelper.GetExplainedUrlArguments("global.cainiao.com/detail.htm?mailNoList=LE325003638SE&teste=teste&agora=foi"));

            }
            catch (Exception e)
            {
                UserGUI.ExceptionOut(
                    e.Message
                        +"\n##################### STACK TRACE###########################\n"
                        + e.StackTrace
                    );
                
            }            
        }
    }
}