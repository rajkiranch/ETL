using SysproIntegration.Library.Models.QuickBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;

namespace SysproIntegration.Library.DataAccess.QuickBooks
{
    internal class QuickBooksDBConverter
    {
        public static IList<QbInvoice>  ConvertXmlToInvoiceData(string xml)
        {


            

            if (!string.IsNullOrEmpty(xml))
            {
                XmlDocument xmlResult = new XmlDocument();
                xmlResult.InnerXml = xml;
                DataSet ds = new DataSet();
                ds.ReadXml(new XmlNodeReader(xmlResult));
            }

            //todo:write Conversion logic

            return  new List<QbInvoice>()
            {
                new QbInvoice(){Column1 = "1",Column2 = "desc1"},
                new QbInvoice(){Column1 = "2",Column2 = ""},

            };
        }
    }
}
