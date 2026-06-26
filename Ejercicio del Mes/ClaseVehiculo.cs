using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_del_Mes
{
    public abstract class ClaseVehiculo
    {
        public int HorasEstancia { get; set; }
        protected ClaseVehiculo (int horasEstancia)
        {
            HorasEstancia = horasEstancia;
        }
        public abstract float CalcularTarifa();

    }

}
}
