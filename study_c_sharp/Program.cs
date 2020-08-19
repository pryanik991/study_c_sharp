using System;

namespace study_c_sharp
{
	class Exercise1
	{
		static void Main(string[] args)
		{

			Console.Write("Please enter a number: ");
			var input = Console.ReadLine();
			var result = Convert.ToInt32(input);
			if (result >= 1 && result <= 10)
				Console.WriteLine("Valid");
			else
				Console.WriteLine("Invalid");
			
		}
	}
}
