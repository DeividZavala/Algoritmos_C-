using System;

namespace Mayusculas_y_minusculas
{
	class MainClass
	{
		public static string MayusToMinus(string s)
		{
			string s1 = string.Empty;
			foreach(var ch in s)
			{
				s1+=char.IsLower(ch)?char.ToUpper(ch):char.ToLower(ch);
			}
			Console.WriteLine (s1);
			return s1;
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			string palabra = "Hola Mundo";
			MayusToMinus (palabra);
		}

	}
}
