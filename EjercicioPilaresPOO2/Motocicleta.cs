﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPilaresPOO2
{
        public class Motocicleta : Vehiculo
        {
            
            public string TipoDeMoto { get; set; }

          
            public Motocicleta(string marca, string modelo, int año, double kilometraje, string tipoDeMoto)
                : base(marca, modelo, año, kilometraje)
            {
                this.TipoDeMoto = tipoDeMoto;
            }

            public override void Encender()
            {
                Console.WriteLine($"La motocicleta {Marca} {Modelo} está encendida.");
            }

            public override void Apagar()
            {
                Console.WriteLine($"La motocicleta {Marca} {Modelo} está apagada.");
            }

            public override void Conducir(double km)
            {
                Kilometraje += km;
                Console.WriteLine($"La motocicleta {Marca} {Modelo} ha sido conducida por {km} km.");
            }
        }

    }

