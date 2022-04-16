using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.LOGICA
{
    public class LVuelos
    {
        public int Id_Vuelos { get; set; }
        public int Id_CO { get; set; }
        public int Id_CD { get; set; }
        public DateTime Fecha { get; set; }
        public string HoraSalida {get; set;}
        public string HoraLlegada { get; set; }
        public string NumedoDeVuelo { get; set; }
        public int Id_Aerolinea { get; set; }
        public int Id_Estado { get; set; }

    }
}
