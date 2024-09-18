using Coursework_1.App_Classes;
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
    public partial class Dashboard_Form : Form
    {
        Admin_Form Admin = new Admin_Form();
        Appoainment_Form Appoainment = new Appoainment_Form();
        Front_Officer_Form Front_Officer = new Front_Officer_Form();
        Patient_Form Patient = new Patient_Form();
        Payment_Form Payment = new Payment_Form();
        Surgeon_Form Surgeon = new Surgeon_Form();
        Treatment_Type_Form Treatment = new Treatment_Type_Form();

        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void Admin_Btn_Click(object sender, EventArgs e)
        {
            Admin.Show();
            this.Hide();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Front_Officer_Btn_Click(object sender, EventArgs e)
        {
            Front_Officer.Show();
            this.Hide();
        }

        private void Surgeon_Btn_Click(object sender, EventArgs e)
        {
            Surgeon.Show();
            this.Hide();
        }

        private void Patient_Btn_Click(object sender, EventArgs e)
        {
            Patient.Show();
            this.Hide();
        }

        private void Appoainment_Btn_Click(object sender, EventArgs e)
        {
            Appoainment.Show();
            this.Hide();
        }

        private void Treatment_Type_Btn_Click(object sender, EventArgs e)
        {
            Treatment.Show();
            this.Hide();
        }

        private void Channelling_Date_Btn_Click(object sender, EventArgs e)
        {
            
        }

        private void Payment_Btn_Click(object sender, EventArgs e)
        {
            Payment.Show();
            this.Hide();
        }
    }
}
