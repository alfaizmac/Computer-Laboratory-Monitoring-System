using Computer_Laboratory_Monitoring_System.LoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace Computer_Laboratory_Monitoring_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UserLoginForm();

        }




        private void UserLoginForm()
        {
            // Create an instance of your UserControl
            UserLogin myControl = new UserLogin();

            // Clear any existing controls in the panel (optional, if you want to replace the contents)
            LoginFormPanel.Controls.Clear();

            // Set the Dock style of the UserControl to Fill, making it expand to fit the panel
            myControl.Dock = DockStyle.Fill;

            // Add the UserControl to the panel
            LoginFormPanel.Controls.Add(myControl);
        }

    }
}
