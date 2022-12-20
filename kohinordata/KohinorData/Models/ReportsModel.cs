using System;
using System.Collections.Generic;
using System.Text;

namespace KohinorData.ViewModels
{
    public class ReportsModel
    {
        //filtros InformesGerenciales


        InformesGerenciales informesGerenciales { get; set; }

        public class Ventas
        {
            public int Cantidad { get; set; }
            public decimal TotalVenta { get; set; }
        }
        public class Compras
        {
            public int Cantidad { get; set; }
            public decimal TotalVenta { get; set; }
        }
        public class Activos
        {
            public int CantidadActivos { get; set; }
            public decimal Adquisicion { get; set; }
            public decimal acumulado { get; set; }
            public decimal Actual { get; set; }
        }
        public class EmpleadosSueldos
        {
            public int NumeroEmpleados { get; set; }
            public decimal sueldo { get; set; }
        }

        public class UsuariosConectados
        {
            public string codusu { get; set; }
            public string nomusu { get; set; }
            public string nomalm { get; set; }
            public DateTime fecha { get; set; }
        }
        public class VentasMensual 
        {
            public int Mes { get; set; }
            public int Cantidad { get; set; }
            public decimal TotalVenta { get; set; }
        }
        public class ComprasMensual
        {
            public int Mes { get; set; }
            public int Cantidad { get; set; }
            public decimal TotalVenta { get; set; }
        }
        public class Importaciones
        {
            public int Cantidad { get; set; }
            public decimal TotalImportacion { get; set; }
        }
        public class Kardex
        {
            public string Existencia { get; set; }
            public string CostoPromedio { get; set; }
        }
        public class Cheques
        {
            public string TipoTransaccion { get; set; }
            public string VAlor { get; set; }
        }




        public class InformesGerenciales
        {
            public string CODEMP { get; set; }
            public string codart { get; set; }
            public string codgru { get; set; }
            public string coduni { get; set; }
            public string codalm { get; set; }
            public string codcla { get; set; }
            public string codfam { get; set; }
            public string nomart { get; set; }
            public string desart { get; set; }
            public string nomalm { get; set; }
            public decimal prec01 { get; set; }
            public decimal prec02 { get; set; }
            public decimal prec03 { get; set; }
            public decimal prec04 { get; set; }
            public decimal prec05 { get; set; }
            public decimal prec06 { get; set; }
            public decimal prec07 { get; set; }
            public decimal prepvp { get; set; }
            public decimal exiact { get; set; }
            public string codiva { get; set; }
            public decimal cospro { get; set; }
            public decimal ultcos { get; set; }
            public decimal porcen { get; set; }
            public decimal desc01 { get; set; }
            public decimal desart_1 { get; set; }
            public decimal desc02 { get; set; }
            public decimal desc03 { get; set; }
            public decimal desc04 { get; set; }
            public decimal desc05 { get; set; }
            public decimal desc06 { get; set; }
            public string codalt { get; set; }
            public DateTime ultcom { get; set; }
            public DateTime ultven { get; set; }
            public string coddes { get; set; }
            public int diaper { get; set; }
            public int color { get; set; }
            public string modbass { get; set; }
            public string nomcla { get; set; }
            public string nomfa { get; set; }
            public string descri { get; set; }
            public string galmat { get; set; }
            public string numheb { get; set; }
            public string desmat { get; set; }
            public string compras { get; set; }
            public string ventas { get; set; }
            public string saldo { get; set; }
        }
        public class PuntosVentas
        {
            public string CODEMP { get; set; }
            public string codart { get; set; }
            public string coduni { get; set; }
            public string codalm { get; set; }
            public string nomemp { get; set; }
            public string dir01 { get; set; }
            public string tel01 { get; set; }
            public string ruc { get; set; }
            public string numfac { get; set; }
            public string codven { get; set; }
            public string medsoc { get; set; }
            public DateTime fecfac { get; set; }
            public string nomcli { get; set; }
            public string codcli { get; set; }
            public decimal totnet { get; set; }
            public decimal totbas { get; set; }
            public decimal totdes { get; set; }
            public decimal totiva { get; set; }
            public decimal totfac { get; set; }
            public string ttardes { get; set; }
            public string ntardes { get; set; }
        }

        public class Inventarios
        {
            public string codemp { get; set; }
            public string codcla { get; set; }
            public string nomcla { get; set; }
            public string codcta { get; set; }
            public string codart { get; set; }
            public string nomart { get; set; }
            public string coduni { get; set; }
            public int cantot { get; set; }
            public decimal cospro { get; set; }
            public decimal costot { get; set; }
            public decimal codfin { get; set; }
            public DateTime fecini { get; set; }
            public DateTime fecfin { get; set; }
            public int exiact { get; set; }
            public decimal valdes { get; set; }
            public string marart { get; set; }
            public string estado { get; set; }
            public string colart { get; set; }
            public string modart { get; set; }

        }
    }
}