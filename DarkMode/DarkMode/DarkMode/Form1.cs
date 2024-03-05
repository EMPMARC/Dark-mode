using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkMode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeUI("UIMode");
        }

        private void InitializeUI(string key)
        {
            try
            {
                var uiMode = ConfigurationManager.AppSettings[key];
                if(uiMode == "light")
                {
                    btnProcess.Text = "Enable Dark Mode";
                    lblmsg.Text = "Light mode is enabled now";
                    this.ForeColor= Color.FromArgb(47, 54, 64);
                    this.BackColor = Color.FromArgb(245,246,250);
                    ConfigurationManager.AppSettings[key] = "dark";
                }
                else
                {
                    btnProcess.Text = "Enable Light Mode";
                    lblmsg.Text = "Dark mode is enabled now";
                    this.ForeColor = Color.FromArgb(245, 246, 250);
                    this.BackColor = Color.FromArgb(47,54,64);
                    ConfigurationManager.AppSettings[key] = "light";
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            InitializeUI("UIMode");
            //https://www.youtube.com/watch?v=X0wJusugq-E
        }
    }
}
