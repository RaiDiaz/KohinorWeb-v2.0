using KohinorData.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using static KohinorData.ViewModels.ReportsModel;

namespace KohinorData.Models
{
    public class AllModels
    {
        //Listas para dashboard
        public List<Ventas> pvt_i_ventas { get; set; }
        public List<Compras> cpa_i_compras { get; set; }
        public List<Activos> ACT_I_ACTIVOS { get; set; }
        public List<VentasMensual> pvt_i_ventas_mensual { get; set; }
        public List<ComprasMensual> cpa_i_compras_mensual { get; set; }
        public List<UsuariosConectados> seg_i_usuarios { get; set; }
        public List<EmpleadosSueldos> nom_i_empleados { get; set; }
        public List<Importaciones> im_i_importaciones { get; set; }
        public List<Kardex> inv_i_kardex { get; set; }
        public List<Cheques> con_i_cheques { get; set; }   

    }
}
