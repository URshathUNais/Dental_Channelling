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
    internal class Patient
    {
        private static int lastInsertedID = 4;
        internal int ID { get; set; }
        internal string Name { get; set; }
        internal string Address { get; set; }
        internal string Mobile_number { get; set; }
        internal string Gender { get; set; }
        internal string Age { get; set; }
        

        internal Patient() { }

        internal Patient(int id, string name, string address, string mobile_number, string gender, string age)
        {
            ID = id;
            Name = name;
            Address = address;
            Mobile_number = mobile_number;
            Gender = gender;
            Age = age;
        }

        internal bool save()
        {
            try
            {
                this.ID = lastInsertedID++;
                DB.patients.Add(new Patient(this.ID , this.Name , this.Address , this.Mobile_number , this.Gender , this.Age));
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
                    foreach (Patient pat in DB.patients)
                    {
                        if (pat.ID == this.ID)
                        {
                            pat.Name = this.Name;
                            pat.Address = this.Address;
                            pat.Mobile_number = this.Mobile_number;
                            pat.Gender = this.Gender;
                            pat.Age = this.Age;
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
                    foreach (Patient pat in DB.patients)
                    {
                        if (pat.ID == this.ID)
                        {
                            DB.patients.Remove(pat);
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
            dt.Columns.Add("Gender");
            dt.Columns.Add("Age");

            foreach (Patient patient in DB.patients)
            {
                dt.Rows.Add(new Object[]
                {
                   patient.ID, patient.Name, patient.Address, patient.Mobile_number, patient.Gender, patient.Age
                });
            }

            return dt;
        }

        internal static void loadFk(ComboBox fkBox)
        {
            fkBox.DisplayMember = "Name";
            fkBox.ValueMember = "Id";
            fkBox.DataSource = new Patient().generateDataTable();
        }

        internal static Patient getObjectByID(string id)
        {
            int _id = int.Parse(id);

            foreach (Patient patient in DB.patients)
            {
                if (patient.ID == _id)
                {
                    return patient;
                }
            }

            return null;
        }
    }
}
