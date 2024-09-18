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
    public partial class Admin_Form : Form
    {
        
        Admin admin = null;
        public Admin_Form()
        {
            InitializeComponent();

            admin = new Admin();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (admin.save())
            {
                MessageBox.Show("Admin Inserted Successfully");
                Admin_Load(this,EventArgs.Empty);   
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (admin.update())
            {
                MessageBox.Show("Admin Updated Successfully");
                Admin_Load(this, EventArgs.Empty);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (admin.delete())
            {
                MessageBox.Show("Admin Deleted Successfully");
                Admin_Load(this, EventArgs.Empty);
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            admin.loadDataInGridView(load_table);
        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {
            admin.Name = name_box.Text; 
        }

        private void address_box_TextChanged(object sender, EventArgs e)
        {
            admin.Address = address_box.Text;
        }

        private void mobile_box_TextChanged(object sender, EventArgs e)
        {
            admin.Mobile_number = mobile_box.Text;
        }

        private void username_box_TextChanged(object sender, EventArgs e)
        {
            admin.User_name = username_box.Text;
        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {
            admin.Password = password_box.Text;
        }

        private void load_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Rowindex = e.RowIndex;
            admin.Id = int.Parse(load_table.Rows[Rowindex].Cells["Id"].Value.ToString());
            name_box.Text = load_table.Rows[Rowindex].Cells["Name"].Value.ToString();
            address_box.Text = load_table.Rows[Rowindex].Cells["Address"].Value.ToString();
            mobile_box.Text = load_table.Rows[Rowindex].Cells["Mobile"].Value.ToString();
            username_box.Text = load_table.Rows[Rowindex].Cells["Username"].Value.ToString();
            password_box.Text = load_table.Rows[Rowindex].Cells["Password"].Value.ToString();
        }

        private void back_page_Click(object sender, EventArgs e)
        {
           
        }

        private void load_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
