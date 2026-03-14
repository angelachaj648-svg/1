int opcion;
int aprobados = 0;
int reprobados = 0;
int totalEstudiantes = 0;
double sumaPromedios = 0;

do
{
	Console.WriteLine("SISTEMA DE CONTROL DE NOTAS");
	Console.WriteLine("1. Registrar estudiante");
	Console.WriteLine("2. Mostrar promedio general");
	Console.WriteLine("3. Mostrar cantidad de aprobados y reprobados");
	Console.WriteLine("4. Salir");
	Console.Write("Seleccione una opcion: ");
	opcion = int.Parse(Console.ReadLine());

	switch (opcion)
	{
		case 1:
			Console.Write("Ingrese el nombre del estudiante: ");
			string nombre = Console.ReadLine();

			Console.Write("Ingrese nota 1: ");
			double n1 = int.Parse(Console.ReadLine());

			Console.Write("Ingrese nota 2: ");
			double n2 = int.Parse(Console.ReadLine());

			Console.Write("Ingrese nota 3: ");
			double n3 = int.Parse(Console.ReadLine());

			double promedio = CalcularPromedio(n1, n2, n3);

			string estado;
			if (promedio >= 61)
			{
				estado = "Aprobado";
				aprobados++;
			}
			else
			{
				estado = "Reprobado";
				reprobados++;
			}

			totalEstudiantes++;
			sumaPromedios += promedio;

			MostrarResultado(nombre, promedio, estado);
			break;

		case 2:
			if (totalEstudiantes > 0)
			{
				double promedioGeneral = sumaPromedios / totalEstudiantes;
				Console.WriteLine("Promedio general de estudiantes: " + promedioGeneral);
			}
			else
			{
				Console.WriteLine("No hay estudiantes registrados.");
			}
			break;

		case 3:
			Console.WriteLine("Cantidad de aprobados: " + aprobados);
			Console.WriteLine("Cantidad de reprobados: " + reprobados);
			break;

		case 4:
			Console.WriteLine("Saliendo del sistema...");
			break;

		default:
			Console.WriteLine("Opcion no valida.");
			break;
	}

	Console.WriteLine();

} while (opcion != 4);



static double CalcularPromedio(double a, double b, double c)
{
	return (a + b + c) / 3;
}
static void MostrarResultado(string nombre, double promedio, string estado)
{
	Console.WriteLine("RESULTADO DEL ESTUDIANTE ");
	Console.WriteLine("Nombre: " + nombre);
	Console.WriteLine("Promedio: " + promedio);
	Console.WriteLine("Estado: " + estado);
}