/*using System;

namespace dia_cinco
{
	class MainClass
	{
		static int cuentaVocal(string palabra){
			int result = 0;
			string[] vocales = { "a", "e", "i", "o","u","A","E","I","O","U" };
			foreach (string x in vocales)
			{
				if (palabra.Contains(x))
				{
					result++;
				}
			}
			Console.WriteLine (result);
			return result;
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			cuentaVocal ("mi nombre es david");

			//object[] arr = new object[]{ 134, 343, 3242, 324, "a", "u" };

		
			a = 97;
			e = 101;
			i = 105;
			o = 111;
			u = 117;
		}
	}
}*/

using System;

namespace DiaCincoCuentaVocalProyecto
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int totalvocales = 0;

			Console.WriteLine("Ingresa una frase ---->>");
			string frase = Console.ReadLine().ToLower();

			for (int i = 0; i < frase.Length; i++)
			{
				if (frase[i]  == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u')
				{
					totalvocales++;
				}
			}
			Console.WriteLine("El numero total de vocales es--->: {0}", totalvocales);

			Console.ReadLine();
		}
	}
}

12,3,5,2,4,3,9

144,9,25,4,2,9,3