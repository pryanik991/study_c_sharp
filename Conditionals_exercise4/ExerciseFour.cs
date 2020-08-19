using System;

namespace Conditionals_exercise4
{
	class ExerciseFour
	{
		static void Main(string[] args)
		{
			// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
			// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
			// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
			// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
			// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
			// the console. If the number of demerit points is above 12, the program should display License Suspended.
			
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
