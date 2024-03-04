using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Admin_Booking : Form
    {
        public Admin_Booking()
        {
            InitializeComponent();
        }

        private void btnAM_Click(object sender, EventArgs e)
        {
            User_Booking f1=new User_Booking();
            this.Visible = false;
            f1.ShowDialog();

        }

        private void btnRE_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            this.Visible = false;
            f1.Show();

        }
    }
}
