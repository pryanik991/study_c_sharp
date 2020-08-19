using System;

namespace Conditionals_exercise4
{
	class ExerciseFour
	{
		static void Main(string[] args)
		{
			Console.Write("PLease enter a speed limit: ");
			var speed_limit = Convert.ToInt32(Console.ReadLine());
			Console.Write("PLease enter a speed of a car: ");
			var car_speed = Convert.ToInt32(Console.ReadLine());

			if (car_speed < speed_limit)
				Console.WriteLine("Ok");
			else
			{
				float demerit_point = (car_speed - speed_limit) / 5f;
				if (demerit_point > 12)
					Console.WriteLine("Your license has been suspended.");
				else
					@Console.WriteLine("You've exceeded speed limit with " + demerit_point + " demerit points.");
			}
				
		}
	}
}
