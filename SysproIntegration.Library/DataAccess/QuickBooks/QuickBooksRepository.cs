using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysproIntegration.Library.External;
using SysproIntegration.Library.Interfaces;
using SysproIntegration.Library.Models.QuickBooks;
using SysproIntegration.Library.Interfaces.Repositories;
using SysproIntegration.Library.Configuration;
using System.Xml;
using SysproIntegration.Library.Infrastructure;

namespace SysproIntegration.Library.DataAccess.QuickBooks
{
    public class QuickBooksInvoiceRepository : QuickBooksBaseRepository,IQbInvoiceRepository
    {
        public QuickBooksContext QBContext { get; private set; }
        private QuickBooksXml _quickBooksXml;
        private XmlDocument _xmlDoc;

        public QuickBooksInvoiceRepository()
            : this(new SysproConfig(Constants.DefaultQbFileConnectionKey).GetFileConfiguration())
        {
           
        }

        public QuickBooksInvoiceRepository(FileElement fileElement )
        {
            base.FileElement = fileElement;
            this.QBContext = new QuickBooksContext(fileElement);
        }

        public IList<QbInvoice> GetInvoices()
        {
            
            //:Todo

            List<QbInvoice> qbInvoices=new List<QbInvoice>();

            XmlDocument xmlInputDoc = new XmlDocument();
            //write logic here
            _xmlDoc = xmlInputDoc;


            string outputXml;


            using (var context = new QuickBooksContext())
            {
                outputXml = QBContext.Connect(_xmlDoc).InnerXml;
            }

            return QuickBooksDBConverter.ConvertXmlToInvoiceData(outputXml);
        }

      
    }
}
