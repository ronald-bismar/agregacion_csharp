using System;
namespace Agregacion
{
	public class Carrera
	{
		private string nombre;
		private string direccion;
		private short nro_Docentes;
		private Docente []D;
		private int nro_Universitarios;
		private Universitario []U;
		public Carrera(Docente Do, Universitario Un)
		{
			nombre = "Medicina";
			direccion = "Villa Dolores";
			nro_Docentes = 2;
			D = new Docente[nro_Docentes];
			for (int i = 0; i < nro_Docentes; i++) {
				D[i] = Do;
			}
			nro_Universitarios = 2;
			U = new Universitario[nro_Universitarios];
			for (int i = 0; i < nro_Universitarios; i++) {
				U[i] = Un;
			}
		}
		public void leer(){
			Console.WriteLine();
			Console.WriteLine("** Datos De la carrera **");
			Console.WriteLine("Introduzca el nombre: ");
			nombre=Console.ReadLine();
			Console.WriteLine("Introduzca la direccion :");
			direccion=Console.ReadLine();
			Console.WriteLine("Introduzca el numero de docentes: ");
			nro_Docentes=short.Parse(Console.ReadLine());
			for(int i = 0; i<nro_Docentes; i++)
				D[i].leer();
			Console.WriteLine("Introduzca el numero de universitarios:");
			nro_Universitarios=int.Parse(Console.ReadLine());
			for(int i = 0; i<nro_Universitarios; i++){
				U[i].leer();
			}
		}
		public void mostrar()
		{
			Console.WriteLine();
			Console.WriteLine("----------------------------------------");
			Console.WriteLine("** Mostrar Datos De La Carrera **");
			Console.WriteLine("Nombre: "+nombre);
			Console.WriteLine("Direccion: "+direccion);
			Console.WriteLine("Numero de Docentes: "+nro_Docentes);
			for(int i =0; i<nro_Docentes; i++)
				D[i].mostrar();
			Console.WriteLine("Numero de Universitarios: "+nro_Universitarios);
			for(int i =0; i<nro_Universitarios; i++)
				U[i].mostrar();
			Console.WriteLine("----------------------------------------");
		}
		public string getNombre(){
			return nombre;
		}
		public void setNombre(string nombre){
			this.nombre = nombre;
		}
		public string getDireccion(){
			return direccion;
		}
		public void setDireccion(string direccion){
			this.direccion = direccion;
		}
		public short getNroDocentes(){
			return nro_Docentes;
		}
		public void setNroDocentes(short nro_Docentes){
			this.nro_Docentes = nro_Docentes;
		}
		public Docente[] getDocente(){
			return D;
		}
		public void setDocente(Docente[] D){
			this.D = D;
		}
		public int getNroUniversitarios(){
			return nro_Universitarios;
		}
		public void setNroUniversitarios(int nro_Universitarios){
			this.nro_Universitarios = nro_Universitarios;
		}
		public Universitario[] getUniversitario(){
			return U;
		}
		public void setUniversitario(Universitario[] U){
			this.U = U;
		}
		//c) Buscar la carrera “X” mostrar la cantidad de docentes y estudiantes que tiene
		public void mostrarCantDocentesYEstudiantes(){
			Console.WriteLine("La cantidad de docentes de la carrera es: "+nro_Docentes);
			Console.WriteLine("La cantidad de estudiantes de la carrera es: "+nro_Universitarios);
		}
		//d) Contar cuantos docentes son extranjeros
		public int docentesExtranjeros(){
			int cont = 0;
			for(int i = 0; i < nro_Docentes; i++){
				if(D[i].docenteExtranjero() == true){
					cont++;
				}
			}
			return cont;
		}
	}
}
