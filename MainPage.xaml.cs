using System.Collections.ObjectModel;

namespace AttendanceDashboard
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<V_GraficaAsistenciasMeses> AsistenciasMeses { get; set; }

        public MainPage()
        {
            InitializeComponent();

            AsistenciasMeses = new ObservableCollection<V_GraficaAsistenciasMeses>
            {
                new V_GraficaAsistenciasMeses { Año = "2025", NumeroMes = "01", Mes = "Enero", TotalAsistencias = 120 },
                new V_GraficaAsistenciasMeses { Año = "2025", NumeroMes = "02", Mes = "Febrero", TotalAsistencias = 134 },
                new V_GraficaAsistenciasMeses { Año = "2025", NumeroMes = "03", Mes = "Marzo", TotalAsistencias = 128 },
                new V_GraficaAsistenciasMeses { Año = "2025", NumeroMes = "04", Mes = "Abril", TotalAsistencias = 150 },
                new V_GraficaAsistenciasMeses { Año = "2025", NumeroMes = "05", Mes = "Mayo", TotalAsistencias = 143 }
            };

            this.BindingContext = this;
        }

   
    }

}
