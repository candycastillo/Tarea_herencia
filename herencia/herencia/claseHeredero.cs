using System;

namespace herencia
{
	public class claseHeredero:claseHereda
	{
		protected string nombreHijo; 
		 
		public claseHeredero ()
		{
		
		    this.nombreHijo = "";  
		}
	
	  
		public  override String  metodoHerencia(  ){

			return "Nombre del padre: " + "  "+this.nombrePadre +" "+ this.apellidoPadre +"\n"+ 
				   "Nombre de la madre: " +"  "+ this.nombreMadre +"  "+ this.apellidoMadre +"\n"+
				   "Nombre del hijo: " +" "+ this.nombreHijo +" "+ this.apellidoPadre +" "+ this.apellidoMadre; 
				     }
          public  void capturaNombreHijo(){
			Console.WriteLine ("Ingrese el nombre del hijo");
			this.nombreHijo = Console.ReadLine (); 

		}
	
	
	}
}



	
	
	
	
	
	

