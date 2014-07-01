using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Aspose.Pdf;
using Aspose.Pdf.Generator;
using System.Net;

namespace PDF
{
    public class BemsPdf
    {
        public static void ReceivePdf(string SendUrl, string PdfUrl)
        {
            Pdf ReceivedPdf = new Pdf();
            HttpWebRequest request = WebRequest.CreateHttp(SendUrl);
            request.Timeout = 10000; // 10,000 ms = 10 secs

            using (HttpWebResponse localWebResponse = (HttpWebResponse)request.GetResponse())
            {
                Encoding encoding = Encoding.GetEncoding(1252);

                using (StreamReader localResponseStream = new StreamReader(localWebResponse.GetResponseStream(), encoding))
                {
                    Section section = ReceivedPdf.Sections.Add();
                    Text PageText = new Text(section, localResponseStream.ReadToEnd());
                    PageText.IsHtmlTagSupported = true;

                    section.Paragraphs.Add(PageText);

                    ReceivedPdf.Save(PdfUrl);
                }
            }

            //License license = new License();
            //License.SetLicense("lic");

            
        }
    }
}
