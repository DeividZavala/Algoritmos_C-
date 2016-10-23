using System;

namespace IsVowel
{
	class MainClass
	{

		public static object[] Isvowel(object[] a){
			
			for(int i = 0; i < a.Length; i++)
			{
				if((int)a[i] == 97)
					a[i] = "a";
				else if((int)a[i] == 101)
					a[i] = "e";
				else if((int)a[i] == 105)
					a[i] = "i";
				else if((int)a[i] == 111)
					a[i] = "o";
				else if((int)a[i] == 117)
					a[i] = "u";
			}

			return a;
		
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			object[] arr = new object[]{12,23,97,03,45,105,43,346,117 };
			Isvowel (arr);
		}
	}
}
