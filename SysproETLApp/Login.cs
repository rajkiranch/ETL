using SysproIntegration.Library.Configuration;
using SysproIntegration.Library.Infrastructure;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                Logger<Form>.LogInfo("test sucess");
                throw new ArgumentException("test exception");
            }
            catch (Exception ex)
            {
                Logger<Form>.LogException(ex);
                throw;
            }
        }
        
        private void btnTestFileConfig_Click(object sender, EventArgs e)
        {
            var fileElement = DatabaseConfiguration.DatabaseFileSettings["DefaultQuickBooksFileConnection"];            
            //Change the config
            var newElement = new FileElement
            {
                Key = "DefaultQuickBooksFileConnection",
                Path = @"c:\test"
            };
            DatabaseConfiguration.SaveDatabaseFileSettings(newElement);            
            System.Diagnostics.Process.Start(System.Reflection.Assembly.GetEntryAssembly().Location);
            this.Close();
            


        }

        private void btnServiceConfig_Click(object sender, EventArgs e)
        {
            var serviceElement = DatabaseConfiguration.DatabaseServiceSettings["DefaultAcumaticaServiceConnection"];
            MessageBox.Show(serviceElement.Url);
        }

        private void btnOpenQBToAcumatica_Click(object sender, EventArgs e)
        {            
            var  newfrm=  CompositionRoot.Resolve<FrmExportInvoice>();
            newfrm.Show();
        }
    }
}
