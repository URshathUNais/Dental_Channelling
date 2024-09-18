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
    public partial class Patient_Form : Form
    {
        Patient patient = null;
        public Patient_Form()
        {
            InitializeComponent();

            patient = new Patient();
        }

        private void Patient_Form_Load(object sender, EventArgs e)
        {
            patient.loadDataInGridView(load_table);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (patient.save())
            {
                MessageBox.Show("Patient Inserted Successfully");
                Patient_Form_Load(this, EventArgs.Empty);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (patient.update())
            {
                MessageBox.Show("Patient Updated Successfully");
                Patient_Form_Load(this, EventArgs.Empty);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (patient.delete())
            {
                MessageBox.Show("Patient Deleted Successfully");
                Patient_Form_Load(this, EventArgs.Empty);
            }
        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {
            patient.Name = name_box.Text;
        }

        private void address_box_TextChanged(object sender, EventArgs e)
        {
            patient.Address = address_box.Text;
        }

        private void mobile_box_TextChanged(object sender, EventArgs e)
        {
            patient.Mobile_number = mobile_box.Text;
        }

        private void gender_box_TextChanged(object sender, EventArgs e)
        {
            patient.Gender = gender_box.Text;
        }

        private void age_box_TextChanged(object sender, EventArgs e)
        {
            patient.Age = age_box.Text;
        }

        private void load_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Rowindex = e.RowIndex;
            patient.ID = int.Parse(load_table.Rows[Rowindex].Cells["Id"].Value.ToString());
            name_box.Text = load_table.Rows[Rowindex].Cells["Name"].Value.ToString();
            address_box.Text = load_table.Rows[Rowindex].Cells["Address"].Value.ToString();
            mobile_box.Text = load_table.Rows[Rowindex].Cells["Mobile"].Value.ToString();
            gender_box.Text = load_table.Rows[Rowindex].Cells["Gender"].Value.ToString();
            age_box.Text = load_table.Rows[Rowindex].Cells["Age"].Value.ToString();
        }
    }
}
