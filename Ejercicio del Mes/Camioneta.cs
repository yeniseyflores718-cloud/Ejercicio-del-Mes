using Ejercicio_del_Mes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoWinForms
{
    public class Camioneta : ClaseVehiculo
    {
       
        public int NumEjes { get; set; }

        public Camioneta(int horasEstancia, int numeroEjes) : base(horasEstancia)
        {
            NumEjes = numeroEjes;
        }

        public override float CalcularTarifa()
        {
            return HorasEstancia * 45;
        }
      
    }
}
