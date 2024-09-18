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
    public partial class Payment_Form : Form
    {
        Payment payment;
        public Payment_Form()
        {
            InitializeComponent();

            payment = new Payment();
        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {
            Patient.loadFk(Appoainment_ID_CmBox);
            Surgeon.loadFk(Amount_CmBox);
            Treatment_Type.loadFk(Treatment_CmBox);
            Treatment_Type.loadFk(Amount2_CmBox);
            payment.loadDataInGridView(load_table);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (payment.save())
            {
                MessageBox.Show("Payment Inserted Successfully");
                Payment_Form_Load(this, EventArgs.Empty);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (payment.update())
            {
                MessageBox.Show("Payment Updated Successfully");
                Payment_Form_Load(this, EventArgs.Empty);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (payment.delete())
            {
                MessageBox.Show("Payment Deleted Successfully");
                Payment_Form_Load(this, EventArgs.Empty);
            }
        }

        private void payment_date_box_ValueChanged(object sender, EventArgs e)
        {
            payment.Date = payment_date_box.Text;
        }

        private void Appoainment_ID_CmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Patient SelectedAdmin = Patient.getObjectByID(Appoainment_ID_CmBox.SelectedValue.ToString());
            payment.Patient_Name = SelectedAdmin;
        }

        private void Amount_CmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Surgeon SelectedAdmin = Surgeon.getObjectByID(Amount_CmBox.SelectedValue.ToString());
            payment.Surgeon_Name = SelectedAdmin;
        }

        private void load_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Rowindex = e.RowIndex;
            payment.ID = int.Parse(load_table.Rows[Rowindex].Cells["Id"].Value.ToString());
            payment_date_box.Text = load_table.Rows[Rowindex].Cells["Date"].Value.ToString();
            Appoainment_ID_CmBox.Text = load_table.Rows[Rowindex].Cells["Appoainment ID"].Value.ToString();
            Amount_CmBox.Text = load_table.Rows[Rowindex].Cells["Amount"].Value.ToString();
        }

        private void Treatment_CmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Treatment_Type SelectedAdmin = Treatment_Type.getObjectByID(Amount_CmBox.SelectedValue.ToString());
            payment.Treatment = SelectedAdmin;
        }

        private void Amount2_CmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Treatment_Type SelectedAdmin = Treatment_Type.getObjectByID(Amount_CmBox.SelectedValue.ToString());
            payment.Amount = SelectedAdmin;
        }
    }
}
