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
        private InvoiceExportQBToAcumaticaPresenter _invoiceExportQBToAcumaticaPresenter;
        IList<QBToAcumaticaInvoicesExportVM> _qbInvoices = new List<QBToAcumaticaInvoicesExportVM>();
        /// <summary>
        /// 
        /// </summary>
        public IList<QBToAcumaticaInvoicesExportVM> QbInvoices
        {
            get
            {

                for (int rows = 0; rows < _qbInvoices.Count; rows++)
                {
                    if (Convert.ToBoolean(grdQBInvoices.Rows[rows].Cells["Export"].Value.ToString()))
                    {
                        _qbInvoices[rows].Export = true;
                    }
                    else
                    {
                        _qbInvoices[rows].Export = false;
                    }
                }
                return _qbInvoices;
            }
            set
            {
                _qbInvoices = value;
                grdQBInvoices.DataSource = _qbInvoices;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Message
        {
            set
            {
                lblMessage.Text = value;
            }
        }
        
        public FrmExportInvoice(IQuickBooksService quickBooksService, IAcumaticaService acumaticaService)
        {
            this._acumaticaService = acumaticaService;
            this._quickBooksService = quickBooksService;
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            _invoiceExportQBToAcumaticaPresenter.ExportToAcumatica();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmExportInvoice_Load(object sender, EventArgs e)
        {
            _invoiceExportQBToAcumaticaPresenter = new InvoiceExportQBToAcumaticaPresenter(this, _acumaticaService, _quickBooksService);
            _invoiceExportQBToAcumaticaPresenter.LoadInvoices();
        }
       
    }
}
