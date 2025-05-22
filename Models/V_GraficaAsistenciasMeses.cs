using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceDashboard.Models
{
    public class V_GraficaAsistenciasMeses
    {
        public string Año { get; set; }
        public string NumeroMes { get; set; }
        public string Mes { get; set; }
        public int TotalAsistencias { get; set; }
    }
}
