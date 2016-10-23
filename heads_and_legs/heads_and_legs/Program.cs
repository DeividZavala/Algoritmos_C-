using System;

namespace heads_and_legs
{
	class MainClass
	{
		public static object Animals(int heads, int legs)
		{


			/*cab= 72;
			patas = 200;

			(4*x) + 2 (72-x) = 200
				4x+144-2x=200
				2x+144=200
				2x=200-144
				x=(200-144)/2*/



			var cows = (legs - 2 * heads) / 2;
			var chickens = heads - cows;


			if (cows < 0 || chickens < 0 || cows + chickens != heads || 2 * chickens + 4 * cows != legs)
				return "No solutions";



			Console.WriteLine ("Cuadrupedos: " + cows);
			Console.WriteLine ("Bipedos: "+chickens);
			return new[] { chickens, cows };
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Animals (6, 24);
		}
	}
}

