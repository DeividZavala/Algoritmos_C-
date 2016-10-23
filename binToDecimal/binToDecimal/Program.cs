using System;

namespace binToDecimal
{
	class MainClass
	{
		public static int bintoDes(string s){
			int result = 0;
			char[] arr = s.ToCharArray();
			Array.Reverse(arr);
			for (var i =0 ;i<arr.Length;i++){
				if(arr[i].ToString()== "1"){
					result += (int)Math.Pow(2,i);
				}
			}
			Console.Write (result);
			return result;
		}

		public static void Main (string[] args)
		{
			string s ="011010" ;
			bintoDes (s);

		}
	}
}
