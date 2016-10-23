using System;

namespace Par_o_Impar
{
	class MainClass
	{
		public static string EvenOrOdd(string str)
		{
			int odds = 0;
			int evens = 0;
			foreach (char i in str)
			{
				int number = Convert.ToInt32(i.ToString());
				if (number % 2 == 0)
				{
					evens += Convert.ToInt32(number);
				}
				else
				{
					odds += Convert.ToInt32(number);
				}
			}
			if (odds > evens)
			{
				return "Odd is greater than Even";
			}
			else if (evens > odds)
			{
				return "Even is greater than Odd";
			}
			else
			{
				return "Even and Odd are the same";
			}
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			EvenOrOdd ("123");
		}
	}
}
