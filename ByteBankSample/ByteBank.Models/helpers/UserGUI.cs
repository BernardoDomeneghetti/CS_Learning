using System;

namespace ByteBank.helpers
{
    public class UserGUI
    {
        public static void OutLine(String text)
        {
            Console.WriteLine(text);
        }
        public static void Out(String text)
        {
            Console.Write(text);
        }        
        public static void ExceptionOut(String text)
        {
            Console.WriteLine("----------------------RUNTIME EXCEPTION----------------------");
            Console.WriteLine(text);
            Console.WriteLine("-------------------------------------------------------------");
        }


    }
}
