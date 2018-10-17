using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenipo
{
   interface IVehiculo
    {
        
    }
    class Vehiculo : IVehiculo

    {
        string color = "", asientos = "", volante = "";

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Vehiculo()
        {

        }

        public Vehiculo(string color)
        {
            this.color = color;
        }

        public void Acelerar()
        {
            Console.WriteLine("El vheiculo esta avelerando");
        }

        public void Frenar()
        {
            Console.WriteLine("El Vehiculo esta frnando");
        }

        public void DarVueta()
        {
            Console.WriteLine("El Vehiculo esta dando Vuelta");
        }
    }
}
