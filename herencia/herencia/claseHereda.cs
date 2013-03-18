using System;

namespace herencia
{
	public  class  claseHereda
	{

		public string nombrePadre;
		public string apellidoPadre;
		public string nombreMadre;
		public string apellidoMadre;

		public claseHereda ()
		{
		this.nombrePadre = "";
		this.apellidoPadre = "";
		this.nombreMadre = "";
			this.apellidoMadre = ""; 
		
		}
	
	public  virtual String metodoHerencia(){

			return
				this.nombrePadre + this.apellidoPadre +
				this.nombreMadre + this.apellidoMadre; 

			}

	  }
}

