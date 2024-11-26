using System;
namespace Agregacion
{
	public class Docente
	{
		private string nombre;
		private string paterno;
		private string materno;
		private int CI;
		private string nro_Registro_Docente;
		private string categoria;
		private string nacionalidad;
		public Docente()
		{
			nombre = "Jose";
			paterno = "Acarapi";
			materno = "Nuñez";
			CI = 43632356;
			nro_Registro_Docente = "164357-34";
			categoria = "tercera";
			nacionalidad = "boliviano";
		}
		public void leer(){
			Console.WriteLine();
			Console.WriteLine("** Datos Del docente **");
			Console.WriteLine("Introduzca el nombre: ");
			nombre=Console.ReadLine();
			Console.WriteLine("Introduzca el apellido paterno: ");
			paterno=Console.ReadLine();
			Console.WriteLine("Introduzca el apellido materno: ");
			materno=Console.ReadLine();
			Console.WriteLine("Introduzca el CI: ");
			CI=int.Parse(Console.ReadLine());
			Console.WriteLine("Introduzca el numero de registro: ");
			nro_Registro_Docente=Console.ReadLine();
			Console.WriteLine("Introduzca la categoria del docente: ");
			categoria=Console.ReadLine();
			Console.WriteLine("Introduzca la nacionalidad del docente: ");
			nacionalidad=Console.ReadLine();
		}
		public void mostrar()
		{
			Console.WriteLine();
			Console.WriteLine("----------------------------------------");
			Console.WriteLine("** Mostrar Datos Del Docente **");
			Console.WriteLine("Nombre: "+nombre);
			Console.WriteLine("Apellido paterno: "+paterno);
			Console.WriteLine("Apllido materno: "+materno);
			Console.WriteLine("Numero de CI: "+CI);
			Console.WriteLine("Numero de registro: "+nro_Registro_Docente);
			Console.WriteLine("Categoria deL docente: "+categoria);
			Console.WriteLine("Nacionalidad deL docente: "+nacionalidad);
			Console.WriteLine("----------------------------------------");
		}
		public string getNombre(){
			return nombre;
		}
		public void setNombre(string nombre){
			this.nombre = nombre;
		}
		public string getPaterno(){
			return paterno;
		}
		public void setPaterno(string paterno){
			this.paterno = paterno;
		}
		public string getMaterno(){
			return materno;
		}
		public void setMaterno(string materno){
			this.materno = materno;
		}
		public int getCI(){
			return CI;
		}
		public void setCI(int CI){
			this.CI = CI;
		}
		public string getNroRegistro(){
			return nro_Registro_Docente;
		}
		public void setNroRegistro(string nro_Registro_Docente){
			this.nro_Registro_Docente = nro_Registro_Docente;
		}
		public string getCategoria(){
			return categoria;
		}
		public void setCategoria(string categoria){
			this.categoria = categoria;
		}
		public string getNacionalidad(){
			return nacionalidad;
		}
		public void setNacionalidad(string nacionalidad){
			this.nacionalidad = nacionalidad;
		}
		//d) Contar cuantos docentes son extranjeros
		public bool docenteExtranjero(){
			bool band = false;
			if(nacionalidad != "boliviano" || nacionalidad != "boliviana")
				band = true;
			return band;
		}
	}
}
