using System;

namespace Gordon_ramsay
{
	class MainClass
	{
		/*public static string GordonFancy(string a)
		{
			return a.Replace('a', '@').Replace('e', '*').Replace('i', '*')
				.Replace('o', '*').Replace('u', '*')
				.Replace(" ", "!!!! ").ToUpper() + "!!!!";
		}*/

		public static string Gordon(string a)
		{
			string r = null;
			foreach (var i in a)
			{
				var t = char.ToUpper(i);
				switch (t)
				{
				case 'A':
					r += "@";
					break;
				case 'E':
					r += "*";
					break;
				case 'I':
					r += "*";
					break;
				case 'O':
					r += "*";
					break;
				case 'U':
					r += "*";
					break;
				case ' ':
					r += "!!!! ";
					break;
				default:
					r += t;
					break;
				}
			}
			Console.WriteLine (r + "!!!!");
			return r + "!!!!";
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			string lex = "Eres estupido?";
			Gordon (lex);
		}
	}
}
