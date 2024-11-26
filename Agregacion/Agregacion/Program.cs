using System;

namespace Agregacion
{
	class Program
	{
		public static void Main(string[] args)
		{
			Docente D = new Docente();
			Universitario Un = new Universitario();
			Carrera C = new Carrera(D, Un);
			Universidad U = new Universidad(C);
			U.leer();
			U.mostrar();
			
			//MLO
			U.buscarDocente();
			U.actualizarMatriculaEstudiante();
			U.mostrarCantDocentesYEstudiantes();
			U.docentesExtranjeros();
			Console.ReadKey(true);	
		}
	}
}