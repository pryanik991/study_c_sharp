using System;

namespace Conditionals_exercise3
{
	class ExerciseThree
	{
		static void Main(string[] args)
		{
			// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
			// is landscape or portrait.
			
			Console.Write("Please enter height of an image: ");
			var height = Convert.ToInt32(Console.ReadLine());
			Console.Write("Please enter width of an image: ");
			var width = Convert.ToInt32(Console.ReadLine());

			if (height > width)
				Console.WriteLine("Image is a portrait");
			else if (height < width)
				Console.WriteLine("Image is a landscape");
			else
				Console.WriteLine("Image is in a shape of square");
		}
	}
}
