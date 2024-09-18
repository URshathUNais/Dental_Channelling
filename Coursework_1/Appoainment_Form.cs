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
    public partial class Appoainment_Form : Form
    {
        Appoainment appoainment;
        public Appoainment_Form()
        {
            InitializeComponent();

            appoainment = new Appoainment();
        }

        private void Appoainment_Load(object sender, EventArgs e)
        {
            Front_Officer.loadFk(front_officer_CmBox);
            Patient.loadFk(Patient_CmBox);
            Surgeon.loadFk(Surgeon_CmBox);
            Treatment_Type.loadFk(Treatment_CmBox);
            appoainment.loadDataInGridView(load_table);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (appoainment.save())
            {
                MessageBox.Show("Appoainment Inserted Successfully");
                Appoainment_Load(this, EventArgs.Empty);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (appoainment.update())
            {
                MessageBox.Show("Appoainment Updated Successfully");
                Appoainment_Load(this, EventArgs.Empty);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (appoainment.delete())
            {
                MessageBox.Show("Appoainment Deleted Successfully");
                Appoainment_Load(this, EventArgs.Empty);
            }
        }

        private void Appoainment_Date_Box_ValueChanged(object sender, EventArgs e)
        {
            appoainment.Date = Appoainment_Date_Box.Text;
        }

        private void Register_Fee_Box_TextChanged(object sender, EventArgs e)
        {
            appoainment.Registration_Fees = Register_Fee_Box.Text;
        }

        private void front_officer_CmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Front_Officer SelectedAdmin = Front_Officer.getObjectByID(front_officer_CmBox.SelectedValue.ToString());
            appoainment.Created_By = SelectedAdmin;
        }

        private void Patient_CmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Patient SelectedAdmin = Patient.getObjectByID(Patient_CmBox.SelectedValue.ToString());
            appoainment.Patient = SelectedAdmin;
        }

        private void Treatment_CmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Treatment_Type SelectedAdmin = Treatment_Type.getObjectByID(Treatment_CmBox.SelectedValue.ToString());
            appoainment.Treatment = SelectedAdmin;
        }

        private void Surgeon_CmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Surgeon SelectedAdmin = Surgeon.getObjectByID(Surgeon_CmBox.SelectedValue.ToString());
            appoainment.Surgeon_Name = SelectedAdmin;
        }

        private void load_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Rowindex = e.RowIndex;
            appoainment.ID = int.Parse(load_table.Rows[Rowindex].Cells["Id"].Value.ToString());
            Appoainment_Date_Box.Text = load_table.Rows[Rowindex].Cells["Date"].Value.ToString();
            Register_Fee_Box.Text = load_table.Rows[Rowindex].Cells["Registration Fees"].Value.ToString();
            front_officer_CmBox.Text = load_table.Rows[Rowindex].Cells["Enter Register"].Value.ToString();
            Patient_CmBox.Text = load_table.Rows[Rowindex].Cells["Patient"].Value.ToString();
            Surgeon_CmBox.Text = load_table.Rows[Rowindex].Cells["Surgeon"].Value.ToString();
            Treatment_CmBox.Text = load_table.Rows[Rowindex].Cells["Treatment"].Value.ToString();
        }
    }
}
