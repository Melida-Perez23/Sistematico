using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistematico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la marca del vehículo: ");
            string marca = Console.ReadLine();

            Console.Write("Ingrese la placa del vehículo: ");
            string placa = Console.ReadLine();

            Console.Write("Ingrese el modelo del vehículo: ");
            string modelo = Console.ReadLine();

            Console.Write("Ingrese el color del vehículo: ");
            string color = Console.ReadLine();

            Console.Write("Ingrese la capacidad del tanque de combustible en galones: ");
            double capacidadTanqueCombustible = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el rendimiento de combustible en km/galón: ");
            double rendimientoCombustible = Convert.ToDouble(Console.ReadLine());

            Automovil mivehiculo = new Automovil(marca, placa, modelo, color, capacidadTanqueCombustible, rendimientoCombustible);

            Console.WriteLine($"Marca: {mivehiculo.Marca}, Placa: {mivehiculo.Placa}, Modelo: {mivehiculo.Modelo}, Color: {mivehiculo.Color}");

            mivehiculo.RestablecerCombustible(10); 
            mivehiculo.Conducir(100); 

            if (mivehiculo.PuedeConducir(50)) 
            {
                mivehiculo.Conducir(50);
            }
            else
            {
                Console.WriteLine("No hay suficiente combustible para completar el viaje.");
            }
        }
    }
}

