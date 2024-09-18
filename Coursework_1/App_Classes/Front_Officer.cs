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
    internal class Front_Officer
    {
        private static int lastInsertedID = 4 ;
        internal int ID { get ; set;}
        internal string Name { get ; set;}
        internal string Address { get ; set; }
        internal string Mobile_number { get ; set;}
        internal string User_name { get ; set;}
        internal string Password { get ; set;}
        internal Admin Created_By { get; set;}

        internal Front_Officer() { }

        internal Front_Officer(int id, string name, string address, string mobile_number, string user_name, string password , Admin created_by)
        {
            ID = id;
            Name = name;
            Address = address;
            Mobile_number = mobile_number;
            User_name = user_name;
            Password = password;
            Created_By = created_by;
        }

        internal bool save()
        {
            try
            {
                this.ID = lastInsertedID++;
                DB.front_officers.Add(new Front_Officer(this.ID , this.Name , this.Address , this.Mobile_number , this.User_name , this.Password , this.Created_By));
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        internal bool update()
        {
            try
            {
                if (MessageBox.Show("Update Confirmation", "Do you want to update ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (Front_Officer fr_officer in DB.front_officers)
                    {
                        if (fr_officer.ID == this.ID)
                        {
                            fr_officer.Name = this.Name;
                            fr_officer.Address = this.Address;
                            fr_officer.Mobile_number = this.Mobile_number;
                            fr_officer.User_name = this.User_name;
                            fr_officer.Password = this.Password;
                            fr_officer.Created_By = this.Created_By;
                            return true;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        internal bool delete()
        {
            try
            {
                if (MessageBox.Show("Delete Confirmation", "Do you want to Delete ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (Front_Officer fr_officer in DB.front_officers)
                    {
                        if (fr_officer.ID == this.ID)
                        {
                            DB.front_officers.Remove(fr_officer);
                            return true;
                        }
                    }
                }

            }
            catch (Exception ex)
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
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Address");
            dt.Columns.Add("Mobile");
            dt.Columns.Add("Username");
            dt.Columns.Add("Password");
            dt.Columns.Add("Created By");


            foreach (Front_Officer fr_officer in DB.front_officers)
            {
                dt.Rows.Add(new Object[]
                {
                   fr_officer.ID, fr_officer.Name, fr_officer.Address, fr_officer.Mobile_number, fr_officer.User_name, fr_officer.Password, fr_officer.Created_By.Name, 
                });;
            }

            return dt;
        }

        internal static void loadFk(ComboBox fkBox)
        {
            fkBox.DisplayMember = "Name";
            fkBox.ValueMember = "Id";
            fkBox.DataSource = new Front_Officer().generateDataTable();
        }

        internal static Front_Officer getObjectByID(string id)
        {
            int _id = int.Parse(id);

            foreach (Front_Officer front_Officer in DB.front_officers)
            {
                if (front_Officer.ID == _id)
                {
                    return front_Officer;
                }
            }

            return null;
        }
    }
}
