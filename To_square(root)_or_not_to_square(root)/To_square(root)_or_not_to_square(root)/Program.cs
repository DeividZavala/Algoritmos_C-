using System;

namespace To_squareroot_or_not_to_squareroot
{
	class MainClass
	{
		public static int[] TosqrtOrNot(int[] array){
			int[] result = new int[array.Length];
			for (int i =0;i< array.Length;i++) {
				double square = Math.Sqrt (array[i]);
				if (square % 1 == 0) {
					result [i] = (int)square;
				} else {
					result [i] = (int)Math.Pow (array [i], 2);
				}
			}
			return result;
		}

		public static void Main (string[] args)
		{
			var input = new int[] { 4, 3, 9, 7, 2, 1 };
			TosqrtOrNot (input);
			Console.WriteLine ("Hello World!");
		}
	}
}