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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool blnValidPass = true;
            int intInvPass = 0;
            blnValidPass = ValidatePassword(blnValidPass);
            if (blnValidPass == true)
            {
                // declares a new instance of the Admin form (which, by default, is not visible)
                Admin_Booking f1 = new Admin_Booking();
                // makes the current form “invisible”
                this.Visible = false;
                // shows the new instance of the Admin form
                f1.ShowDialog();

            }
            else
            {
                intInvPass += 1;
               
            }
            if (intInvPass == 3)
            {
                Application.Exit();
            }
        }
        private bool ValidatePassword(bool blnValidPass)
        {
            if (txtPassword.Text != "FAN" && txtPassword.Text != "ADMIN")
            {
                blnValidPass = false;
                MessageBox.Show("Invalid password ,You only have 2 attempts remaining", "Invalid Password");
            }
            return blnValidPass;
        }
    }
}
