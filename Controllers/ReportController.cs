using KohinorData.Models;
using KohinorData.Services;
using KohinorERP.Models;
using Microsoft.AspNetCore.Mvc;
using Raven.Database.Bundles.Encryption;
using System.Configuration;
using System.Diagnostics;
using static Azure.Core.HttpHeader;
using System.Security.Claims;
using static KohinorData.ViewModels.ReportsModel;

namespace KohinorERP.Controllers
{
    public class ReportController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IReportsServices _reportsServices;
        private readonly ILogger<ReportController> _logger;

        public ReportController(ILogger<ReportController> logger, IConfiguration configuration, IReportsServices reportsServices)
        {
            _logger = logger;
            _configuration = configuration;
            _reportsServices = reportsServices;
        }

        public IActionResult Reports()
        {
            return View();
        }

        [HttpGet]
        public JsonResult PVT_S_DASHBOARD_EXISTENCIA(string codemp, string codgru, string codalm, string codcla, string codfam, string codart, string desart, string nomart)
        {
            return Json(_reportsServices.PVT_S_DASHBOARD_EXISTENCIA(codemp, codgru, codalm, codcla, codfam, codart, desart, nomart).ToList());
        }
        [HttpGet]
        public JsonResult dashboard_existencia_alm_img(string CODEMP, string codart, int exiact)
        {
            InformesGerencialesModel model = new InformesGerencialesModel();
            model.PVT_S_DASHBOARD_EXISTENCIA_alm = _reportsServices.PVT_S_DASHBOARD_EXISTENCIA_alm(CODEMP, codart).ToList();
            model.PVT_S_DASHBOARD_EXISTENCIA_IMG = _reportsServices.PVT_S_DASHBOARD_EXISTENCIA_IMG(CODEMP, codart, exiact).ToList();
            return Json(model);
        }
        [HttpGet]
        public JsonResult PV_FACTURAS_resumido(string codemp, string numini, string numfin, string cliini, string clifin, string claini, string clafin, DateTime fecini, DateTime fecfin, string venini, string venfin, string estado, string codmon, string almini, string almfin, string ejeini, string ejefin, string usuini, string usufin, string ttardes)
        {

            return Json(_reportsServices.PV_FACTURAS_resumido(codemp, numini, numfin, cliini, clifin, claini, clafin, fecini, fecfin, venini, venfin, estado, codmon, almini, almfin, ejeini, ejefin, usuini, usufin, ttardes).ToList());
        }
        [HttpGet]
        public JsonResult INV_I_RESEXI_CLA(string codemp, DateTime fecini, string codini, string codfin, string claini, string clafin, string almini, string almfin, string famini, string famfin, string estado, string marart)
        {
            return Json(_reportsServices.INV_I_RESEXI_CLA(codemp, fecini, codini, codfin, claini, clafin, almini, almfin, famini, famfin, estado, marart).ToList());
        }
      


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}