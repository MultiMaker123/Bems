using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Net;
using Aspose.Cells;

namespace XLS
{
    class XlsOutput
    {
        public static void Convert(string XlsUrl)
        {
            Workbook bemsXls = new Workbook(FileFormatType.Xlsx);
            bemsXls.Save(XlsUrl);
            HttpContext.Current.Response.End();
        }
    }
}
