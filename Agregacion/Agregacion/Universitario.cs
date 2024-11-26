using System;
namespace Agregacion
{
	public class Universitario
	{
		private string nombre;
		private string paterno;
		private string materno;
		private int CI;
		private string matricula;
		public Universitario()
		{
			nombre = "Ivan";
			paterno = "Ortega";
			materno = "Valdez";
			CI = 436356;
			matricula = "864877-9897";
		}
		public void leer(){
			Console.WriteLine();
			Console.WriteLine("** Datos Del universitario **");
			Console.WriteLine("Introduzca el nombre: ");
			nombre=Console.ReadLine();
			Console.WriteLine("Introduzca el apellido paterno: ");
			paterno=Console.ReadLine();
			Console.WriteLine("Introduzca el apellido materno: ");
			materno=Console.ReadLine();
			Console.WriteLine("Introduzca el CI: ");
			CI=int.Parse(Console.ReadLine());
			Console.WriteLine("Introduzca la matricula: ");
			matricula=Console.ReadLine();
		}
		public void mostrar()
		{
			Console.WriteLine();
			Console.WriteLine("----------------------------------------");
			Console.WriteLine("** Mostrar Datos Del Universitario **");
			Console.WriteLine("Nombre: "+nombre);
			Console.WriteLine("Apellido paterno: "+paterno);
			Console.WriteLine("Apllido materno: "+materno);
			Console.WriteLine("Numero de CI: "+CI);
			Console.WriteLine("Numero de matricula: "+matricula);
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
		public string getMatricula(){
			return matricula;
		}
		public void setMatricula(string matricula){
			this.matricula = matricula;
		}
	}
}