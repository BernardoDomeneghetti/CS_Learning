using System;

namespace _3_FlowControl
{
    class Program
    {
        public static double RevenueValue(double investedValue, double revenuePercentage)
        {
            return investedValue * (revenuePercentage/100);
        }
        static void Main(string[] args)
        {
            double investedValue = 0;
            double revenuePercentage = 0;           
            int monthsProjection;

            //----------------INPUT SECTION--------------------
            investedValue = 1000.00;
            revenuePercentage = 0.36;
            monthsProjection = 100;
            //-------------------------------------------------   

            int count = 1;
            while (count <= monthsProjection)
            {
                investedValue = investedValue + RevenueValue(investedValue, revenuePercentage);
                string months = " month";
                if (count > 1){ months += "s";}
                Console.WriteLine("After " + count + months + ", the result value is gonna be: " + investedValue);
                count++;
            }          

            //----------------INPUT SECTION--------------------
            investedValue = 1000.00;
            revenuePercentage = 0.36;
            monthsProjection = 100;
            //-------------------------------------------------   

            for (count = 1; count <= monthsProjection; count++)
            {
                investedValue = investedValue + RevenueValue(investedValue, revenuePercentage);
                string months = " month";
                if (count > 1) { months += "s"; }
                Console.WriteLine("After " + count + months + ", the result value is gonna be: " + investedValue);
            }
        }

    }
}