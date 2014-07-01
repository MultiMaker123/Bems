using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aspose.Pdf.Generator;
using PDF;

namespace Site.Controllers
{
    public class PdfController : Controller
    {
        public ViewResult MakePdf(string FromUrl)
        {
            string PdfUrl = Environment.GetEnvironmentVariable("HOMEDRIVE") + Environment.GetEnvironmentVariable("HOMEPATH") + "/Sites/Bems/PDF/UserPdfs/users.pdf";
            BemsPdf.ReceivePdf(FromUrl, PdfUrl);

            return View();
        }

    }
}
