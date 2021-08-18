using System;
using ByteBankSample;

namespace ByteBankSample {
	public class TestClass
	{
		/*	This class is used to tests and all about curiosity
		 *	there will be a lot of examples of normal, right and wrong uses of the language
		 *	
		 */
		public void Test()
		{
			//-----------------------------Playing with primitive and Wrapper types---------
			//-  int _int;
			//-  Int32 _Int32;
			//-  
			//-  //Console.WriteLine("This is an primitive null reference of int: ",_int); 
			//-  //Console.WriteLine("This is an primitive null reference of int: ", _Int32);
			//-  //These line will not even compile because
			//-  //The VisualStudio IDE knows that the the value is not even filled 
			//-  
			//-  _int = 2;
			//-  _Int32 = 2;
			//-  
			//-  Console.WriteLine("This is an primitive null reference of int: ", _int);
			//-  Console.WriteLine("This is an primitive null reference of int: ", _Int32);
			//-  
			//-  //Now it must work
			//-  
			//-  int _int_2;
			//-  Int32 _Int32_2;
			//-  
			//-  _int_2 = _Int32;
			//-  _Int32_2 = _int;
			//-  
			//-  Console.WriteLine("This is an primitive null reference of int: ", _int_2);
			//-  Console.WriteLine("This is an primitive null reference of int: ", _Int32_2);
			//-  
			//-  //_int_2 = null;
			//-  //_Int32_2 = null;
			//-  //As expected, the primitive reference did not hold in a pointer value
			//-  //But, not expected that the "Wrapper" type wouldn't hold it, demonstrate 
			//-  //that this type of reference is not derived from Object base type 

		}
	}
}

