using System;

namespace Agregacion
{
	public class Universidad
	{
		private string nombre;
		private string direccion;
		private short nro_Carreras;
		private Carrera []C;
		public Universidad(Carrera Ca)
		{
			nombre = "UPEA";
			direccion = "Rio Seco";
			nro_Carreras = 2;
			C = new Carrera[nro_Carreras];
			for (int i = 0; i < nro_Carreras; i++) {
				C[i] = Ca;
			}
		}
		public void leer(){
			Console.WriteLine("** Datos De la universidad **");
			Console.WriteLine("Introduzca el nombre de la universidad");
			nombre=Console.ReadLine();
			Console.WriteLine("Introduzca la direccion	");
			direccion=Console.ReadLine();
			Console.WriteLine("Introduzca el numero de Carreras");
			nro_Carreras=short.Parse(Console.ReadLine());
			for(int i = 0; i<nro_Carreras; i++){
				C[i].leer();
			}
		}
		public void mostrar()
		{
			Console.WriteLine("----------------------------------------");
			Console.WriteLine("** Mostrar Datos De La universidad **");
			Console.WriteLine("Nombre: "+nombre);
			Console.WriteLine("Direccion: "+direccion);
			Console.WriteLine("Numero de Carreras: "+nro_Carreras);
			for(int i =0; i<nro_Carreras; i++){
				C[i].mostrar();
			}
			Console.WriteLine("----------------------------------------");

		}
		//a) Buscar al docente con número de registro docente “x” mostrar su ci y categoría
		//MLO
		public void buscarDocente(){
			Console.WriteLine();
			bool band = false;
			Console.WriteLine("BUSCAR REGISTRO DE DOCENTE: ");
			Console.WriteLine("Ingrese numero de registro: ");
			string x = Console.ReadLine();
			for(int i = 0; i < nro_Carreras; i++){
				for(int j = 0; j < C[i].getNroDocentes(); j++){
					if(x.ToLower().Equals(C[i].getDocente()[j].getNroRegistro().ToLower())){
						int CI = C[i].getDocente()[j].getCI();
						string cat = C[i].getDocente()[j].getCategoria();
						Console.WriteLine("El numero de CI del docente es: "+CI);
						Console.WriteLine("La categoria del docente es: "+cat);
						band = true;
					}
				}
			}
			if(band == false){
				Console.WriteLine("No se encontró el numero de registro");
			}
		}
		
		//b) Actualizar la matricula del estudiante con ci “x” por la matricula “y”
		//MLO
		public void actualizarMatriculaEstudiante(){
			Console.WriteLine();
			bool band = false;
			Console.WriteLine("ACTUALIZAR MATRICULA DE ESTUDIANTE: ");
			Console.WriteLine("Ingrese numero de CI: ");
			int x = int.Parse(Console.ReadLine());
			for(int i = 0; i < nro_Carreras; i++){
				for(int j = 0; j < C[i].getNroUniversitarios(); j++){
					if(x == C[i].getUniversitario()[j].getCI()){
						Console.Write("Ingrese nuevo numero de matricula: ");
						string y = Console.ReadLine();
						C[i].getUniversitario()[j].setMatricula(y);
						C[i].getUniversitario()[j].mostrar();
						band = true;
					}
				}
			}
			if(band == false)
				Console.WriteLine("No se encontró el numero de registro");
		}
		
		//c) Buscar la carrera “X” mostrar la cantidad de docentes y estudiantes que tiene
		//MLM
		public void mostrarCantDocentesYEstudiantes(){
			Console.WriteLine();
			bool band = false;
			Console.WriteLine("MOSTRAR DOCENTES Y ESTUDIANTES: ");
			Console.WriteLine("Ingrese el nombre de la carrera: ");
			string nom = Console.ReadLine();
			for (int i = 0; i < nro_Carreras; i++) {
				if(nom.ToLower().Equals(C[i].getNombre().ToLower())){
					C[i].mostrarCantDocentesYEstudiantes();
					band = true;
				}
			}
			if(band == false)
				Console.WriteLine("No se encontró la carrera");
		}
		
		//d) Contar cuantos docentes son extranjeros
		//MLM
		public void docentesExtranjeros(){
			int contT = 0;
			for (int i = 0; i < nro_Carreras; i++) {
				contT += C[i].docentesExtranjeros();
			}
			Console.WriteLine();
			Console.WriteLine("La cantidad de docentes extranjeros es: "+contT);
		}
	}
}