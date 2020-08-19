using System;

namespace Conditionals_exercise1
{
	class ExerciseOne
	{
		static void Main(string[] args)
		{
			Console.Write("Please enter a number: ");
			var input = Console.ReadLine();
			var number = Convert.ToInt32(input);
			if (number >= 1 && number <= 10)
				Console.WriteLine("Valid");
			else
				Console.WriteLine("Invalid");
		}
	}
}
