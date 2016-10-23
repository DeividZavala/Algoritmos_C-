using System;

//namespace dia_uno
namespace ño
{
	class MainClass
	{
		static int suma(int x, int y=3){
			int result;
			result = x + y;
			return result;
		}

		class tele{
			private string name = "fixters";
			public string color = "Azul";
			public void Setname(string value){
				name = value;
			}
			public string GetName(){
				return name;
			}

			public int suma(int num1, int num2){
				int result = num1 + num2;
				return result;
			}
		}
		
		public static void Main (string[] args)
		{
			tele samsung = new tele();
			Console.WriteLine(samsung.GetName ());
			samsung.Setname ("David");
			Console.WriteLine(samsung.GetName ());
			Console.WriteLine (samsung.suma (24, 26));

			tele lg = new tele ();
			lg.GetName ();
			lg.Setname ("Hugo");
			Console.WriteLine (lg.GetName());
			Console.WriteLine (samsung.GetName());
			Console.WriteLine (samsung.color);
			tele sony = new tele ();

			/*int accion;
			do {
				Console.WriteLine ("escribe un numero");
				int num1 = Convert.ToInt32 (Console.ReadLine ());
				Console.WriteLine ("escribe el segundo numero");
				int num2 = Convert.ToInt32 (Console.ReadLine ());
				int result = num1 + num2;
				Console.WriteLine ("El resultado de la operacion es ", result);
				Console.WriteLine ("Quieres hacer otra operacion pon el 1");
				accion = Convert.ToInt32 (Console.ReadLine ());
			} while(accion == 1);*/


			/*Console.WriteLine (suma (y:6, x:3));
			Console.WriteLine (suma (1,9));
			Console.WriteLine (suma (10,20));
			suma (1,9);
			suma (10,20);*/
		}
	}
}
