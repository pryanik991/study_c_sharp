using System;

namespace Conditionals_exercise2
{
	class ExerciseTwo
	{
		// Write a program which takes two numbers from the console and displays the maximum of the two.
		
		static void Main(string[] args)
		{
			Console.Write("Please enter first number: ");
			var firstInput = Console.ReadLine();
			var firstNumber = Convert.ToInt32(firstInput);

			Console.Write("Please enter second number: ");
			var secondInput = Console.ReadLine();
			var secondNumber = Convert.ToInt32(secondInput);

			Console.WriteLine("Max value is: " + Math.Max(firstNumber, secondNumber));
		}
	}
}
