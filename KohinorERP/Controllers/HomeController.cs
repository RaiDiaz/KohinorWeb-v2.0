using KohinorData.Models;
using KohinorData.Services;
using KohinorData.ViewModels;
using KohinorERP.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
//using Raven.Database.Bundles.Encryption;
using System.Configuration.Provider;
using System.Diagnostics;
using System.Net;
using static KohinorData.ViewModels.ReportsModel;

namespace KohinorERP.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IReportsServices _reportsServices;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration, IReportsServices reportsServices)
        {
            _logger = logger;
            _configuration = configuration;
            _reportsServices = reportsServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult MenuList()
        {
            TestMenu testmenu = new TestMenu();
            testmenu.MenuList = new List<Menu>();

            string xmlfilepath = Path.Combine(Directory.GetCurrentDirectory(), "XML", "TestMenu.xml");
            string xmlstring = System.IO.File.ReadAllText(xmlfilepath);
            var stringReader = new StringReader(xmlstring);
            var dsSet = new System.Data.DataSet();

            dsSet.ReadXml(stringReader);
            for (int i = 0; i < dsSet.Tables[0].Rows.Count; i++)
            {
                testmenu.MenuList.Add(new Menu
                {
                    id = Convert.ToInt32(dsSet.Tables[0].Rows[i][0]),
                    nameMenu = dsSet.Tables[0].Rows[i][1].ToString(),
                    url = dsSet.Tables[0].Rows[i][2].ToString(),
                    icon = dsSet.Tables[0].Rows[i][3].ToString()
                });
            }

            return Json(testmenu);

        }

        [HttpGet]
        public JsonResult DataDashboard()
        {
            string s_CodEmp = "01";

            //Paras mejorar en el futuro dar accesso dependiendo losmodulos activos crear una lista de cada uno de los reportes q vamos a ver ene l dashboard 
            //de esa manera se va a poder contar cuantos modulos tenemos y dependiendo eso se crear el carosel 

            
            AllModels model = new AllModels();

            model.pvt_i_ventas = _reportsServices.pvt_i_ventas(s_CodEmp).ToList();
            model.cpa_i_compras = _reportsServices.cpa_i_compras(s_CodEmp).ToList();
            model.ACT_I_ACTIVOS = _reportsServices.ACT_I_ACTIVOS(s_CodEmp).ToList();
            model.nom_i_empleados = _reportsServices.nom_i_empleados().ToList();
            model.im_i_importaciones = _reportsServices.im_i_importaciones().ToList();
            model.inv_i_kardex = _reportsServices.inv_i_kardex().ToList();
            model.con_i_cheques = _reportsServices.con_i_cheques().ToList();

            return Json(model);
        }

        public JsonResult GraphDashboard()
        {
            string s_CodEmp = "01";

            AllModels model = new AllModels();
            model.cpa_i_compras_mensual = _reportsServices.cpa_i_compras_mensual(s_CodEmp).ToList();
            model.pvt_i_ventas_mensual = _reportsServices.pvt_i_ventas_mensual(s_CodEmp).ToList();

            return Json(model);
        } 
        
        public JsonResult UserDashboard()
        {
            

            AllModels model = new AllModels();
            model.seg_i_usuarios = _reportsServices.seg_i_usuarios().ToList();

            return Json(model);
        }

        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddYears(1) });

            return Redirect(Request.Headers["Referer"].ToString());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}