using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Laboratory_Monitoring_System.LoginForm
{
    public partial class UserLogin : UserControl
    {
        public event EventHandler ShowOtherControlRequested;
        public UserLogin()
        {
            InitializeComponent();

        }

        public void AdminLoginButton_Click(object sender, EventArgs e)
        {
            ShowOtherControlRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
