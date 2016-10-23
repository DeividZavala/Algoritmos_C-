using System;

namespace password
{
	class MainClass
	{
		public static string checkPassword(int[] key)
		{
			for (int i = 0; i < key.Length / 2; i++)
			{
				if (key [i] != key [key.Length - 1 - i]) {
					Console.WriteLine ("No");
					return "No";
				}
			}
			Console.WriteLine ("Si");
			return "Si";
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			int[] test = new int[] { 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1 };
			checkPassword (test);
		}
	}
}
