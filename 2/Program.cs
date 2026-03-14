int opcion = 0;
double totalVendido = 0;
int cantidadVentas = 0;
double ventaMayor = 0;

double CalcularVenta(int cantidad, double precio)
{
	return cantidad * precio;
}

void MostrarResumen(string producto, int cantidad, double precio, double total)
{
	Console.WriteLine("Producto: " + producto);
	Console.WriteLine("Cantidad: " + cantidad);
	Console.WriteLine("Precio: " + precio);
	Console.WriteLine("Total de la venta: " + total);

}

do
{

	Console.WriteLine("Presione 1 para Registrar venta");
	Console.WriteLine("Presione 2 para Mostrar total vendido");
	Console.WriteLine("Presione 3 para Mostrar promedio de ventas");
	Console.WriteLine("Presione 4 para Mostrar venta mayor registrada");
	Console.WriteLine("Presione 5 paraS salir");
	opcion = int.Parse(Console.ReadLine());

	switch (opcion)
	{

		case 1:
			{

				Console.WriteLine("Ingrese el nombre del producto");
				string nombre = Console.ReadLine();

				Console.WriteLine("Ingrese la cantidad vendida");
				int cantidad = int.Parse(Console.ReadLine());

				Console.WriteLine("Ingrese el precio por unidad");
				double precio = double.Parse(Console.ReadLine());

				double total = CalcularVenta(cantidad, precio);

				MostrarResumen(nombre, cantidad, precio, total);

				totalVendido += total;
				cantidadVentas++;

				if (total > ventaMayor)
				{
					ventaMayor = total;
				}



				break;

			}

		case 2:
			{

				Console.WriteLine("Total Vendido: " + totalVendido);

				break;

			}

		case 3:
			{

				if (cantidadVentas > 0)
				{
					double promedio = totalVendido / cantidadVentas;
					Console.WriteLine("Promedio de ventas" + promedio);
				}
				else
				{
					Console.WriteLine("No hay ventas registradas");
				}


				break;

			}

		case 4:
			{

				Console.WriteLine("Venta mayor registrada: " + ventaMayor);

				break;

			}

		case 5:
			{
				Console.WriteLine("Saliendo...");

				break;

			}

		default:
			{
				Console.WriteLine("Valor no valido ");
				break;
			}


	}


} while (opcion != 5);