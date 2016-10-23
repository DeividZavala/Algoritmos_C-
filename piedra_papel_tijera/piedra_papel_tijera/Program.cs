using System;

namespace piedra_papel_tijera
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string respuesta;
			do {
				string usuario;
				Console.WriteLine ("Escribe piedra papel o tijera: ");
				// el usuario hace su elección
				usuario = Console.ReadLine ();
				Console.WriteLine ("Tu opcion fue: " + usuario);
				// la computadora genera un valor random
				Random random = new Random ();
				int computadora = random.Next (1, 4);
				// se notifica al usuario lo que escogio la computadora
				if (computadora == 1) {
					Console.WriteLine ("La opcion de la computadora fue: piedra");
				} else if (computadora == 2) {
					Console.WriteLine ("La opcion de la computadora fue: papel");
				} else {
					Console.WriteLine ("La opcion de la computadora fue: tijera");
				}

				// Ejecuta las condicionales para saber quien ganó
				if (usuario == "piedra") {

					if (computadora == 2) {
						Console.WriteLine ("La computadora Ganó");
					} else if (computadora == 3) {
						Console.WriteLine ("Felicidades Ganaste");
					} else {
						Console.WriteLine ("Fue un empate");
					}

				} else if (usuario == "papel") {
					if (computadora == 3) {
						Console.WriteLine ("La computadora Ganó");
					} else if (computadora == 1) {
						Console.WriteLine ("Felicidades Ganaste");
					} else {
						Console.WriteLine ("Fue un empate");
					}

				} else if (usuario == "tijera") {
					if (computadora == 2) {
						Console.WriteLine ("La computadora Ganó");
					} else if (computadora == 1) {
						Console.WriteLine ("Felicidades Ganaste");
					} else {
						Console.WriteLine ("Fue un empate");
					}
				} else {
					Console.WriteLine ("Esta no es una opción valida");
				}

				Console.WriteLine ("Escribe s en caso de que quieras jugar o n si no quieres jugar mas");
				respuesta = Console.ReadLine ();
					
			} while(respuesta  ==  "s");

		}
	}
}
