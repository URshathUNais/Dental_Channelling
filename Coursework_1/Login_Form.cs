using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_1
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            string UserName = User_Name_Box.Text;
            string Password = Password_Box.Text;

            if (UserName == "urshath" && Password == "0000")
            {

                this.Hide();

                Dashboard_Form dashboard = new Dashboard_Form();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Login Field !");
            }
        }
    }
}
