using Dapper;
using KohinorData.ViewModels;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using static KohinorData.ViewModels.ReportsModel;

namespace KohinorData.Services
{
    public class ReportsServices: IReportsServices
    {

        private readonly IConfiguration _configuration;
        public ReportsServices(IConfiguration configuration)
        {
            _configuration = configuration;
            ConnectionString = _configuration.GetConnectionString("ReportsTestDB");
            providerName = "System.Data.SqlClient";
        }

        public string ConnectionString { get; }
        public string providerName { get; }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConnectionString);
            }
        }
        //Funciones del dashboard
        public List<Ventas> pvt_i_ventas(string s_CodEmp)
        {
            List<Ventas> result = new List<Ventas>();
            try
            {
                using (IDbConnection dbconnection = Connection)
                {
                    dbconnection.Open();
                    result = dbconnection.Query<Ventas>("[dbo].[pvt_i_ventas]", new { s_CodEmp = s_CodEmp }, commandType: CommandType.StoredProcedure).ToList();
                    dbconnection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                return result;
            }

        }

        public List<Compras> cpa_i_compras(string s_CodEmp)
        {
            List<Compras> result = new List<Compras>();
            try
            {
                using (IDbConnection dbconnection = Connection)
                {
                    dbconnection.Open();
                    result = dbconnection.Query<Compras>("[dbo].[cpa_i_compras]", new { s_CodEmp = s_CodEmp }, commandType: CommandType.StoredProcedure).ToList();
                    dbconnection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                return result;
            }
        }

        public List<Activos> ACT_I_ACTIVOS(string s_CodEmp)
        {
            List<Activos> result = new List<Activos>();
            try
            {
                using (IDbConnection dbconnection = Connection)
                {
                    dbconnection.Open();
                    result = dbconnection.Query<Activos>("[dbo].[ACT_I_ACTIVOS]", new { s_CodEmp = s_CodEmp }, commandType: CommandType.StoredProcedure).ToList();
                    dbconnection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                return result;
            }
        }

        public List<VentasMensual> pvt_i_ventas_mensual(string s_CodEmp)
        {
            List<VentasMensual> result = new List<VentasMensual>();
            try
            {
                using (IDbConnection dbconnection = Connection)
                {
                    dbconnection.Open();
                    result = dbconnection.Query<VentasMensual>("[dbo].[pvt_i_ventas_mensual]", new { s_CodEmp = s_CodEmp }, commandType: CommandType.StoredProcedure).ToList();
                    dbconnection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                return result;
            }
        }

        public List<ComprasMensual> cpa_i_compras_mensual(string s_CodEmp)
        {
            List<ComprasMensual> result = new List<ComprasMensual>();
            try
            {
                using (IDbConnection dbconnection = Connection)
                {
                    dbconnection.Open();
                    result = dbconnection.Query<ComprasMensual>("[dbo].[cpa_i_compras_mensual]", new { s_CodEmp = s_CodEmp }, commandType: CommandType.StoredProcedure).ToList();
                    dbconnection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                return result;
            }
        }
        public List<UsuariosConectados> seg_i_usuarios()
        {
            List<UsuariosConectados> result = new List<UsuariosConectados>();
            try
            {
                using (IDbConnection dbconnection = Connection)
                {
                    dbconnection.Open();
                    result = dbconnection.Query<UsuariosConectados>("[dbo].[seg_i_usuarios]", commandType: CommandType.StoredProcedure).ToList();
                    dbconnection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                return result;
            }
        }

        public List<EmpleadosSueldos> nom_i_empleados()
        {
            List<EmpleadosSueldos> result = new List<EmpleadosSueldos>();
            try
            {
                using (IDbConnection dbconnection = Connection)
                {
                    dbconnection.Open();
                    result = dbconnection.Query<EmpleadosSueldos>("[dbo].[nom_i_empleados]", commandType: CommandType.StoredProcedure).ToList();
                    dbconnection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                return result;
            }
        }

        public List<Importaciones> im_i_importaciones()
        {
            List<Importaciones> result = new List<Importaciones>();
            try
            {
                using (IDbConnection dbconnection = Connection)
                {
                    dbconnection.Open();
                    result = dbconnection.Query<Importaciones>("[dbo].[im_i_importaciones]", commandType: CommandType.StoredProcedure).ToList();
                    dbconnection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                return result;
            }
        }
        public List<Kardex> inv_i_kardex()
        {
            List<Kardex> result = new List<Kardex>();
            try
            {
                using (IDbConnection dbconnection = Connection)
                {
                    dbconnection.Open();
                    result = dbconnection.Query<Kardex>("[dbo].[inv_i_kardex]", commandType: CommandType.StoredProcedure).ToList();
                    dbconnection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                return result;
            }
        }
        public List<Cheques> con_i_cheques()
        {
            List<Cheques> result = new List<Cheques>();
            try
            {
                using (IDbConnection dbconnection = Connection)
                {
                    dbconnection.Open();
                    result = dbconnection.Query<Cheques>("[dbo].[con_i_cheques]", commandType: CommandType.StoredProcedure).ToList();
                    dbconnection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                return result;
            }
        }


        //Funciones del modulo Informes Gerenciales
        public List<InformesGerenciales> PVT_S_DASHBOARD_EXISTENCIA(string codemp, string codgru, string codalm, string codcla, string codfam, string codart, string desart, string nomart)
        {
            List<InformesGerenciales> result = new List<InformesGerenciales>();
            try
            {
                using (IDbConnection dbconnection = Connection)
                {
                    dbconnection.Open();
                    result = dbconnection.Query<InformesGerenciales>("[dbo].[PVT_S_DASHBOARD_EXISTENCIA]", new { CODEMP = codemp, codgru = codgru, codalm = codalm, codcla = codcla, codfam = codfam, codart = codart, desart = desart, nomart = nomart }, commandType: CommandType.StoredProcedure).ToList();
                    dbconnection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            { 
                string errMsg = ex.Message;
                return result;
            }

        }

        public List<InformesGerenciales> PVT_S_DASHBOARD_EXISTENCIA_alm(string CODEMP, string codart)
        {
            List<InformesGerenciales> result = new List<InformesGerenciales>();
            try
            {
                using (IDbConnection dbconnection = Connection)
                {
                    dbconnection.Open();
                    result = dbconnection.Query<InformesGerenciales>("[dbo].[PVT_S_DASHBOARD_EXISTENCIA_alm]", new { CODEMP = CODEMP, codart = codart }, commandType: CommandType.StoredProcedure).ToList();
                    dbconnection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                return result;
            }

        }
        public List<InformesGerenciales> PVT_S_DASHBOARD_EXISTENCIA_IMG (string CODEMP, string codart, int exiact)
        {
            List<InformesGerenciales> result = new List<InformesGerenciales>();
            try
            {
                using (IDbConnection dbconnection = Connection)
                {
                    dbconnection.Open();
                    result = dbconnection.Query<InformesGerenciales>("[dbo].[PVT_S_DASHBOARD_EXISTENCIA_IMG]", new { CODEMP = CODEMP, codart = codart, exiact = exiact }, commandType: CommandType.StoredProcedure).ToList();
                    dbconnection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                return result;
            }

        }

        //Funcion del modulo Puntos de ventas - facturas


        public List<PuntosVentas> PV_FACTURAS_resumido(string codemp, string numini, string numfin, string cliini, string clifin, string claini, string clafin, DateTime fecini, DateTime fecfin, string venini, string venfin, string estado, string codmon,  string almini, string almfin, string ejeini, string ejefin, string usuini, string usufin, string ttardes)
        {
            List<PuntosVentas> result = new List<PuntosVentas>();
            try
            {
                using (IDbConnection dbconnection = Connection)
                {
                    dbconnection.Open();
                    result = dbconnection.Query<PuntosVentas>("[dbo].[PV_FACTURAS_resumido]", new { CODEMP = codemp, NUMINI = numini, NUMFIN = numfin, CLIINI = cliini, CLIFIN = clifin, CLAINI = claini, CLAFIN = clafin, FECINI = fecini, FECFIN = fecfin, VENINI = venini, VENFIN = venfin, ESTADO = estado, CODMON = codmon, ALMINI = almini, ALMFIN = almfin, EJEINI = ejeini, EJEFIN = ejefin, USUINI = usuini, USUFIN = usufin, TTARDES = ttardes }, commandType: CommandType.StoredProcedure).ToList();
                    dbconnection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                return result;
            }

        }

  

        //Funciones del modulo inventarios

        public List<Inventarios> INV_I_RESEXI_CLA(string codemp, DateTime fecini, string codini, string codfin, string claini, string clafin, string almini, string almfin, string famini, string famfin, string estado, string marart)
        {
            List<Inventarios> result = new List<Inventarios>();
            try
            {
                using (IDbConnection dbconnection = Connection)
                {
                    dbconnection.Open();
                    result = dbconnection.Query<Inventarios>("[dbo].[INV_I_RESEXI_CLA]", new { CODEMP = codemp, FECINI = fecini, CODINI = codini, CODFIN = codfin, CLAINI = claini, CLAFIN = clafin, ALMINI = almini, ALMFIN = almfin, FAMINI = famini, FAMFIN = famfin, ESTADO = estado, MARART = marart }, commandType: CommandType.StoredProcedure).ToList();
                    dbconnection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                return result;
            }

        }

    }

    public interface IReportsServices
    {
        //Funciones del dashboard
        public List<Ventas> pvt_i_ventas(string s_CodEmp);
        public List<Compras> cpa_i_compras(string s_CodEmp);
        public List<Activos> ACT_I_ACTIVOS(string s_CodEmp);
        public List<VentasMensual> pvt_i_ventas_mensual(string s_CodEmp);
        public List<ComprasMensual> cpa_i_compras_mensual(string s_CodEmp);
        public List<UsuariosConectados> seg_i_usuarios();
        public List<EmpleadosSueldos> nom_i_empleados();
        public List<Importaciones> im_i_importaciones();
        public List<Kardex> inv_i_kardex();
        public List<Cheques> con_i_cheques();

        //Funciones del modulo Informes Gerenciales
        public List<InformesGerenciales> PVT_S_DASHBOARD_EXISTENCIA(string codemp, string codgru, string codalm, string codcla, string codfam, string codart, string desart, string nomart);
        public List<InformesGerenciales> PVT_S_DASHBOARD_EXISTENCIA_alm(string CODEMP, string codart);
        public List<InformesGerenciales> PVT_S_DASHBOARD_EXISTENCIA_IMG(string CODEMP, string codart, int exiact);

        ////Funcion del modulo Puntos de ventas - facturas
        public List<PuntosVentas> PV_FACTURAS_resumido(string codemp, string numini, string numfin, string cliini, string clifin, string claini, string clafin, DateTime fecini, DateTime fecfin, string venini, string venfin, string estado, string codmon, string almini, string almfin, string ejeini, string ejefin, string usuini, string usufin, string ttardes);

        //Funciones del modulo inventarios
        public List<Inventarios> INV_I_RESEXI_CLA(string CODEMP, DateTime fecini, string codini, string codfin, string claini, string clafin, string almini, string almfin, string famini, string famfin, string estado, string marart);
    }
}
