using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenipo
{
    interface IVehiculo
    {
     string Vehiculo { get; set; }
        void Acelerar();
        void Frenar();
        void DarVueta();

    }
}
