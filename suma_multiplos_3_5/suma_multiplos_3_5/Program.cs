using System;
using System.Collections.Generic;


namespace suma_multiplos_3_5
{
	class MainClass
	{
		static int[] sumMultimplos(int rango){
			List<int> result = new List<int> ();

			for (int i = 0; i <= rango; i++) {
				if (i % 3 == 0 || i % 5 == 0) {
					result.Add(i);
				}
			}
			int[] res = result.ToArray ();

			for (int x = 0; x < res.Length; x++) {
				Console.WriteLine (res [x]);
			}
			return res;
		}

		public static void Main (string[] args)
		{
			//Console.WriteLine ("Hello World!");
			//Console.WriteLine("Escribe un rango de numeros:");

			sumMultimplos (50);
		}
	}
}
