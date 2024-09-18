using Coursework_1.DBClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Coursework_1.App_Classes
{
    internal class Surgeon
    {
        private static int lastInsertedID = 3;
        internal int ID { get; set; }
        internal string Name { get; set; }
        internal string Address { get; set; }
        internal string Mobile_Number { get; set;}

        internal Surgeon() { }

        internal Surgeon(int id, string name, string address, string mobile_number)
        {
            ID = id;
            Name = name;
            Address = address;
            Mobile_Number = mobile_number;
        }

        internal bool save()
        {
            try
            {
                this.ID = lastInsertedID++;
                DB.surgeons.Add(new Surgeon(this.ID , this.Name , this.Address , this.Mobile_Number));
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
                    foreach (Surgeon sur in DB.surgeons)
                    {
                        if (sur.ID == this.ID)
                        {
                            sur.Name = this.Name;
                            sur.Address = this.Address;
                            sur.Mobile_Number = this.Mobile_Number;
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
                    foreach (Surgeon sur in DB.surgeons)
                    {
                        if (sur.ID == this.ID)
                        {
                            DB.surgeons.Remove(sur);
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

            foreach (Surgeon surgeon in DB.surgeons)
            {
                dt.Rows.Add(new Object[]
                {
                   surgeon.ID, surgeon.Name, surgeon.Address, surgeon.Mobile_Number
                });
            }

            return dt;
        }

        internal static void loadFk(ComboBox fkBox)
        {
            fkBox.DisplayMember = "Name";
            fkBox.ValueMember = "Id";
            fkBox.DataSource = new Surgeon().generateDataTable();
        }

        internal static Surgeon getObjectByID(string id)
        {
            int _id = int.Parse(id);

            foreach (Surgeon surgeon in DB.surgeons)
            {
                if (surgeon.ID == _id)
                {
                    return surgeon;
                }
            }

            return null;
        }
    }
}
