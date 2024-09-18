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
    public partial class Surgeon_Form : Form
    {
        Surgeon surgeon = null;
        public Surgeon_Form()
        {
            InitializeComponent();

            surgeon = new Surgeon();
        }

        private void Surgeon_Form_Load(object sender, EventArgs e)
        {
            surgeon.loadDataInGridView(load_table);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (surgeon.save())
            {
                MessageBox.Show("Surgeon Inserted Successfully");
                Surgeon_Form_Load(this, EventArgs.Empty);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (surgeon.update())
            {
                MessageBox.Show("Surgeon Updated Successfully");
                Surgeon_Form_Load(this, EventArgs.Empty);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (surgeon.delete())
            {
                MessageBox.Show("Surgeon Deleted Successfully");
                Surgeon_Form_Load(this, EventArgs.Empty);
            }
        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {
            surgeon.Name = name_box.Text;
        }

        private void address_box_TextChanged(object sender, EventArgs e)
        {
            surgeon.Address = address_box.Text;
        }

        private void mobile_box_TextChanged(object sender, EventArgs e)
        {
            surgeon.Mobile_Number = mobile_box.Text;
        }

        private void load_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Rowindex = e.RowIndex;
            surgeon.ID = int.Parse(load_table.Rows[Rowindex].Cells["Id"].Value.ToString());
            name_box.Text = load_table.Rows[Rowindex].Cells["Name"].Value.ToString();
            address_box.Text = load_table.Rows[Rowindex].Cells["Address"].Value.ToString();
            mobile_box.Text = load_table.Rows[Rowindex].Cells["Mobile"].Value.ToString();
        }
    }
}
