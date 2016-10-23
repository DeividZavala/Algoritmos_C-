using System;

namespace sumNeg_CuenPos
{
	class MainClass
	{

		public static int[] CountPositivesSumNegatives(int[] input)
		{
			int c = 0;
			int s = 0;
			if (input == null || input.Length == 0){
				return new int[]{};
			}
			for (int i = 0; i < input.Length; i++){  
				if (input[i] > 0){
					c += 1;
				}
				if (input[i] < 0){
					s += input[i];
				}
			}

			Console.WriteLine ("La cuenta de los numeros positivos es: "+c);
			Console.WriteLine ("La suma de los nuemros negativos es de: " + s);

			return new int[]{c, s};
		}

		public static void Main (string[] args)
		{
			int[] input = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15} ;
			Console.WriteLine ("Hello World!");
			CountPositivesSumNegatives (input);
		}
	}
}
