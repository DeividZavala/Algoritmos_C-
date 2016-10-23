using System;

namespace proyecto_uno
{
	class MainClass
	{
		static string FakeBin(string x)
		{
			string result = string.Empty;
			foreach(char c in x){
				result += (int.Parse(c.ToString()) < 5 ? "0":"1");
			}
			Console.WriteLine (result);
			return result;
		}

		
		public static void Main (string[] args){
			string test =  "210927435";
			FakeBin (test);

		}


	}
}