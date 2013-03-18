using System;

namespace herencia
{
	class MainClass
	{
		    public void capturaDatos(){
			claseHeredero datos = new claseHeredero (); 
			Console.WriteLine ("Ingresa nombre y apellido del padre");
			Console.WriteLine ("Nombre");
			datos.nombrePadre = Console.ReadLine ();
			Console.WriteLine ("Apellido");
			datos.apellidoPadre = Console.ReadLine (); 
			Console.Clear ();
			Console.WriteLine ("Ingresa nombre y apellido de la madre");
			Console.WriteLine ("Nombre");
			datos.nombreMadre = Console.ReadLine ();
			Console.WriteLine ("Apellido");
			datos.apellidoMadre = Console.ReadLine (); 
			Console.Clear (); 
			datos.capturaNombreHijo (); 
			datos.metodoHerencia (); 
			Console.Clear ();
			Console.WriteLine (datos.metodoHerencia());
		 }

	public static void Main (string[] args)
		{
			MainClass objeto = new MainClass ();
			objeto.capturaDatos ();

		}
	}
}
