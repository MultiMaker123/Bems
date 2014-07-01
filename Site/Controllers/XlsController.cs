using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class XlsController : Controller
    {
        //
        // GET: /Xls/

        public ActionResult Index()
        {
            //XlsOutput.Convert(Environment.GetEnvironmentVariable("HOMEDRIVE") + Environment.GetEnvironmentVariable("HOMEPATH") + "Sites/Bems/XLS/invoice.xlsx");

            return View();
        }

    }
}
