using System;

namespace fundamentos_loops
{
	class MainClass
	{

		static string RepiteString(int number, string palabra){
			string result = "";
			for(int i = 0 ; i < number; i++){
				result += palabra;
				//Console.WriteLine ("palabra");
			}
			Console.WriteLine (result);
			return result;

		}
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			RepiteString(10,"hola");
		}
	}
}
