using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPilaresPOO2
{
        public class Camion : Vehiculo
        {
            
            public double CapacidadDeCarga { get; set; }

            
            public Camion(string marca, string modelo, int año, double kilometraje, double capacidadDeCarga)
                : base(marca, modelo, año, kilometraje)
            {
                this.CapacidadDeCarga = capacidadDeCarga;
            }

           
            public override void Encender()
            {
                Console.WriteLine($"El camión {Marca} {Modelo} está encendido.");
            }

            public override void Apagar()
            {
                Console.WriteLine($"El camión {Marca} {Modelo} está apagado.");
            }

            public override void Conducir(double km)
            {
                Kilometraje += km;
                Console.WriteLine($"El camión {Marca} {Modelo} ha sido conducido por {km} km.");
            }
        }
    }


