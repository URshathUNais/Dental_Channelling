using Coursework_1.DBClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_1.App_Classes
{
    internal class Admin
    {
        private static int lastInsertedID = 4;
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal string Address { get; set; }
        internal string Mobile_number { get; set;}
        internal string User_name { get; set;}
        internal string Password { get; set;}

        //Empty Conctructor Created
        internal Admin() {
        
        }

        internal Admin(int id , string name, string address, string mobile_number, string user_name, string password)
        {
            Id= id;
            Name = name;
            Address = address;
            Mobile_number = mobile_number;
            User_name = user_name;
            Password = password;
        }

        //Save Fuction
        internal bool save()
        {
            try
            {
                this.Id = lastInsertedID++;
                DB.admins.Add(new Admin(this.Id , this.Name, this.Address, this.Mobile_number, this.User_name, this.Password));
                return true;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        //Update Function
        internal bool update()
        {
            //Try Catch Method Use for Error Handling
            try
            {
                if(MessageBox.Show("Update Confirmation" , "Do you want to update ? " , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (Admin ad in DB.admins)
                    {
                        if (ad.Id == this.Id)
                        {
                            ad.Name = this.Name;
                            ad.Address = this.Address;
                            ad.Password = this.Password;
                            ad.Mobile_number = this.Mobile_number;
                            ad.User_name = this.User_name;
                            return true;
                        }
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        //Delete Function
        internal bool delete()
        {
            try
            {
                //Delete Confirmation Message
                if (MessageBox.Show("Delete Confirmation", "Do you want to Delete ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (Admin ad in DB.admins)
                    {
                        if (ad.Id == this.Id)
                        {
                            DB.admins.Remove(ad);
                            return true;
                        }
                    }
                }
                    

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public void loadDataInGridView(DataGridView loadTable)
        {
            loadTable.DataSource = generateDataTable();
        }

        private DataTable generateDataTable()
        {
            //Create Data Table Columns
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Address");
            dt.Columns.Add("Mobile");
            dt.Columns.Add("Username");
            dt.Columns.Add("Password");

            //ADD the Data in Data Table
            foreach (Admin admin in DB.admins)
            {
                dt.Rows.Add(new Object[]
                {
                   admin.Id, admin.Name, admin.Address, admin.Mobile_number, admin.User_name, admin.Password
                });
            }

            return dt;
        }

        //Load Foreign Key Data
        internal static void loadFk(ComboBox fkBox)
        {
            fkBox.DisplayMember = "Name";
            fkBox.ValueMember = "Id";
            fkBox.DataSource = new Admin().generateDataTable();
        }

        internal static Admin getObjectByID(string id)
        {
            int _id = int.Parse(id);
            
            foreach (Admin admin in DB.admins)
            {
                if (admin.Id == _id)
                {
                    return admin;
                }
            }

            return null;
        }

    }
}
