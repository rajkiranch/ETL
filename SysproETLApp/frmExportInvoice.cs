using SysproIntegration.Library.BusinessLogic;
using SysproIntegration.Library.Interfaces.Services;
using SysproIntegration.Library.Interfaces.Views;
using SysproIntegration.Library.Models.QuickBooks;
using SysproIntegration.Library.Presenters;
using SysproIntegration.Library.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysproETLApp
{
    public partial class FrmExportInvoice : Form, IInvoiceExportQbToAcumaticaView
    {
        private readonly IQuickBooksService _quickBooksService;
        private readonly IAcumaticaService _acumaticaService;
        private InvoiceExportQBToAcumaticaPresenter invoiceExportQBToAcumaticaPresenter;
        IList<QBToAcumaticaInvoicesExportVM> qbInvoices = new List<QBToAcumaticaInvoicesExportVM>();
        
        public FrmExportInvoice(IQuickBooksService quickBooksService, IAcumaticaService acumaticaService)
        {
            this._acumaticaService = acumaticaService;
            this._quickBooksService = quickBooksService;
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            invoiceExportQBToAcumaticaPresenter.ExportToAcumatica();
        }

        private void FrmExportInvoice_Load(object sender, EventArgs e)
        {
            invoiceExportQBToAcumaticaPresenter = new InvoiceExportQBToAcumaticaPresenter(this, _acumaticaService, _quickBooksService);
            invoiceExportQBToAcumaticaPresenter.LoadInvoices();
        }

        public IList<QBToAcumaticaInvoicesExportVM> QbInvoices
        {
            get
            {
                
                for (int rows = 0; rows < qbInvoices.Count; rows++)
                {                                         
                        if(Convert.ToBoolean(grdQBInvoices.Rows[rows].Cells["Export"].Value.ToString()))
                        {
                            qbInvoices[rows].Export = true;
                        }  
                    else
                        {
                            qbInvoices[rows].Export = false;
                        }
                } 
                return qbInvoices;
            }
            set
            {
                qbInvoices=value;
                grdQBInvoices.DataSource = qbInvoices;                
            }
        }       
        public string Message
        {           
            set
            {
                lblMessage.Text = value;
            }
        }
    }
}
