using System;

namespace Conditionals_exercise2
{
	class ExerciseTwo
	{
		static void Main(string[] args)
		{
			Console.Write("Please enter first number: ");
			var first_input = Console.ReadLine();
			var first_number = Convert.ToInt32(first_input);
			Console.Write("Please enter second number: ");
			var second_input = Console.ReadLine();
			var second_number = Convert.ToInt32(second_input);

			Console.WriteLine("Max value is: " + Math.Max(first_number, second_number));
		}
	}
}
