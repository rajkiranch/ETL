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
    }
}
