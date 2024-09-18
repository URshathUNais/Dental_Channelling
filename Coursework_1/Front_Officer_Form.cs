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
    public partial class Front_Officer_Form : Form
    {
        Front_Officer front_officer;
        public Front_Officer_Form()
        {
            InitializeComponent();

            front_officer = new Front_Officer();
        }

        private void Front_Officer_Form_Load(object sender, EventArgs e)
        {
            Admin.loadFk(Created_By_CmBox);
            front_officer.loadDataInGridView(load_table);
        }

        private void Created_By_CmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Admin SelectedAdmin = Admin.getObjectByID(Created_By_CmBox.SelectedValue.ToString());
            front_officer.Created_By = SelectedAdmin;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (front_officer.save())
            {
                MessageBox.Show("Front Officer Inserted Successfully");
                Front_Officer_Form_Load(this, EventArgs.Empty);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (front_officer.update())
            {
                MessageBox.Show("Front Officer Updated Successfully");
                Front_Officer_Form_Load(this, EventArgs.Empty);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (front_officer.delete())
            {
                MessageBox.Show("Front Officer Deleted Successfully");
                Front_Officer_Form_Load(this, EventArgs.Empty);
            }
        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {
            front_officer.Name = name_box.Text;
        }

        private void address_box_TextChanged(object sender, EventArgs e)
        {
            front_officer.Address = address_box.Text;
        }

        private void mobile_box_TextChanged(object sender, EventArgs e)
        {
            front_officer.Mobile_number = mobile_box.Text;
        }

        private void username_box_TextChanged(object sender, EventArgs e)
        {
            front_officer.User_name = username_box.Text;
        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {
            front_officer.Password = password_box.Text;
        }

        private void load_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Rowindex = e.RowIndex;
            front_officer.ID = int.Parse(load_table.Rows[Rowindex].Cells["Id"].Value.ToString());
            name_box.Text = load_table.Rows[Rowindex].Cells["Name"].Value.ToString();
            address_box.Text = load_table.Rows[Rowindex].Cells["Address"].Value.ToString();
            mobile_box.Text = load_table.Rows[Rowindex].Cells["Mobile"].Value.ToString();
            username_box.Text = load_table.Rows[Rowindex].Cells["Username"].Value.ToString();
            password_box.Text = load_table.Rows[Rowindex].Cells["Password"].Value.ToString();
            Created_By_CmBox.Text = load_table.Rows[Rowindex].Cells["Created By"].Value.ToString();
        }
    }
}
