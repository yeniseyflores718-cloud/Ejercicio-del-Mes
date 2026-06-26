using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_del_Mes
{
    public class motocicleta : ClaseVehiculo
    {
        public int Cilindrada { get; set; }
        public motocicleta(float horasEstancia, int cilindrada) : base(horasEstancia)
        {
            Cilindrada = cilindrada;
        }

        public override float CalcularTarifa()
        {
            return HorasEstancia * 15.0f;
        }
    }
}
