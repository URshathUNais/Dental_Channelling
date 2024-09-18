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
    public partial class Treatment_Type_Form : Form
    {
        Treatment_Type treatment_Type = null;
        public Treatment_Type_Form()
        {
            InitializeComponent();

            treatment_Type = new Treatment_Type();
        }

        private void Treatment_Type_Form_Load(object sender, EventArgs e)
        {
            treatment_Type.loadDataInGridView(load_table);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (treatment_Type.save())
            {
                MessageBox.Show("Treatment Type Inserted Successfully");
                Treatment_Type_Form_Load(this, EventArgs.Empty);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (treatment_Type.update())
            {
                MessageBox.Show("Treatment Type Updated Successfully");
                Treatment_Type_Form_Load(this, EventArgs.Empty);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (treatment_Type.delete())
            {
                MessageBox.Show("Treatment Type Deleted Successfully");
                Treatment_Type_Form_Load(this, EventArgs.Empty);
            }
        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {
            treatment_Type.Name = name_box.Text;
        }

        private void amount_box_TextChanged(object sender, EventArgs e)
        {
            treatment_Type.Amount = amount_box.Text;
        }

        private void load_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Rowindex = e.RowIndex;
            treatment_Type.ID = int.Parse(load_table.Rows[Rowindex].Cells["Id"].Value.ToString());
            name_box.Text = load_table.Rows[Rowindex].Cells["Name"].Value.ToString();
            amount_box.Text = load_table.Rows[Rowindex].Cells["Amount"].Value.ToString();
        }
    }
}
