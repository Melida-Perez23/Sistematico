using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistematico
{
    public partial class Automovil
    {
        public string Marca { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public double CapacidadTanqueCombustible { get; set; }
        public double NivelCombustible { get; set; }
        public double RendimientoCombustible { get; set; }

        public Automovil(string marca, string placa, string modelo, string color, double capacidadTanqueCombustible, double rendimientoCombustible)
        {
            Marca = marca;
            Placa = placa;
            Modelo = modelo;
            Color = color;
            CapacidadTanqueCombustible = capacidadTanqueCombustible;
            RendimientoCombustible = rendimientoCombustible;
            NivelCombustible = 0;
        }
        public bool PuedeConducir(int distancia)
        {
            double combustibleNesesario = distancia / RendimientoCombustible;
            return combustibleNesesario <= NivelCombustible;
        }
        public void RestablecerCombustible(double cantidad)
        {
            if (cantidad <= 0) return;

            double combustibleAdicional = Math.Min(cantidad, CapacidadTanqueCombustible - NivelCombustible);
            NivelCombustible += combustibleAdicional;
            Console.WriteLine($"Se reabastecieron {combustibleAdicional} galones de combustible.");
        }
        public void Conducir(int distancia)
        {
            if (distancia <= 0) return;

            double combustibleConsumido = distancia / RendimientoCombustible;
            if (combustibleConsumido > NivelCombustible)
            {
                Console.WriteLine("No hay suficiente combustible para completar el viaje.");
            }
            else
            {
                NivelCombustible -= combustibleConsumido;
                Console.WriteLine($"Se consumió {combustibleConsumido} galones de combustible.");
            }
        }

       

      
    }
}

