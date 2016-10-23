using System;
using System.Linq;


namespace dia_cuatro
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			string[] miArray = { "David", "Miguel", "Diego" };
			Console.WriteLine (miArray.Length);
			for (var i = 0; i < 3; i++) {
				Console.WriteLine (miArray [i]);

			}
			int[] arr = { 2, 4, 7, 1};
			Console.WriteLine(arr.Max());

			int[] num = { 1, 34, 3, 44, 5 };
			//num = IndexOf (34);
			/*
			Lenght
			insert(3,45);
			remove(3)
			Replace(34,12)
			contains(4)
			Console.WriteLine (num.Min ());*/


			int suma = 0; 
			foreach (int i in num){
				
				suma += i;
				Console.WriteLine (suma);
			}

		}
	}
}
