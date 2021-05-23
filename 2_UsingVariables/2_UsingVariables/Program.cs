using System;

namespace _2_UsingVariables
{
    class Program
    {
        String str; // <- this is a class atribute 
        static void Main(string[] args)
        {
            String str = "Testing"; // <-This is a local variable            

            //Notice that the variables's name is tha same of our class atribute
            //Hierarchically, the more important reference is always the most internal
            //In this case the used reference is gonna be the local variable

            Console.WriteLine(str);

            /*
            There are many types in C#
            the most useds are 
                String -> Used to charactere sentences exp: "String variable"
                int -> Used to integer values exp: 10
                double -> to floating point values exp: 3.14
                Boolean -> Boolean values are True or false values.
            */
            int integerNumber = 10;
            Double floatingPointNumber = 10.12;
            Boolean booleanValue = true;

            //There are many other data types, but these are enough for a while            

            /*
            When using numeric types in atribuition operations  
            sometimes we have to be carefull.
            for example
            */

            int sum = 1 + 1; //There is no way of this sum going wrong, but 
            Console.WriteLine("1 + 1 = " + sum);

            Double integerDivision = 4 / 2;// <- Looks like any fraction operation, and result 2 as expected
            Console.WriteLine("4 / 2 = " + integerDivision);

            integerDivision = 3 / 2; //<- but if the same hapes with no interger result, the result doesn't goes as expected
            Console.WriteLine("3 / 2 = " + integerDivision);
       
            /*
            This happens because, when an integer value gets divided for another integer value
            the compiler captures only the integer portion of the result, ignoring the rest
            to make sure that an division is gonna as expected, we use an explict way to show the compiler, that value is floating point 
            */

            integerDivision = 3.0 / 2.0; //<- by this way, we make sure that the result will not be cutted
            Console.WriteLine("3.0 / 2.0 = " + integerDivision);

            //--Other way to do it is trough casting
            integerDivision = (Double)3 / (Double)2; 
            Console.WriteLine("(Double) 3 / (Double) 2 = " + integerDivision);

            //CASTING

            /*
            Casting basically is a convertion of a reference of one structure to another structure witch it fits in
            like, convert a int value to a double, just like we did
            or a double to an integer value like this:
            */
            
            Double salary = 1728.38;
            Console.WriteLine("Actual Double Salary is: " + salary);

            //int integerSalary = salary; if we try the atribuition without the casting explicition, doesnt work 
            int integerSalary = (int)salary;
            Console.WriteLine("Integer Salary is: " + integerSalary);
        }
    }
}