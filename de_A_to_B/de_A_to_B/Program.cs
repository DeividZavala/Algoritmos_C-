using System;
using System.Text;

namespace de_A_to_B
{
	class MainClass
	{
		public static string aTob(string x)
		{
			var stringBuilder = new StringBuilder();
			foreach (var ch in x)
			{
				switch (ch)
				{
				case 'a':
					stringBuilder.Append('b');
					break;
				case 'b':
					stringBuilder.Append('a');
					break;
				default:
					stringBuilder.Append(ch);
					break;
				}
			}
			Console.WriteLine (stringBuilder.ToString ());
			return stringBuilder.ToString();
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			aTob ("hablar");
		}
	}
}
