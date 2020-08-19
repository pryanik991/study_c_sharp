using System;

namespace Loops_exercise2
{
	class ExerciseTwo
	{
		// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
		// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.

		static void Main(string[] args)
		{
			var sum = 0;

			while (true)
			{
				@Console.Write("Please enter a number or 'ok' to exit: ");
				var input = Console.ReadLine();

				if (input.ToLower() == "ok")
					break;

				sum += Convert.ToInt32(input);
			}

			Console.WriteLine("Sum of all numbers is: " + sum);
		}
	}
}
