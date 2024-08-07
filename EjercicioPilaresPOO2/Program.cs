using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPilaresPOO2
{
    public class Program
    {

        static void Main()
        {
            
            Auto auto = new Auto("Toyota", "Corolla", 2020, 15000, 4);
            Motocicleta moto = new Motocicleta("Yamaha", "R1", 2021, 5000, "Deportiva");
            Camion camion = new Camion("Volvo", "FH16", 2018, 80000, 15000);

          
            auto.Encender();
            auto.Conducir(100);
            auto.Apagar();
            Console.WriteLine($"Kilometraje del auto: {auto.Kilometraje} km\n");

            moto.Encender();
            moto.Conducir(50);
            moto.Apagar();
            Console.WriteLine($"Kilometraje de la motocicleta: {moto.Kilometraje} km\n");

            camion.Encender();
            camion.Conducir(200);
            camion.Apagar();
            Console.WriteLine($"Kilometraje del camión: {camion.Kilometraje} km");
        }
    }
}
