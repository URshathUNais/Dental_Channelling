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
    internal class Appoainment 
    {
        private static int lastInsertedID = 4;
        internal int ID { get; set; }
        internal string Date { get; set; }
        internal string Registration_Fees { get; set; }
        internal Front_Officer Created_By { get; set; }
        internal Patient Patient { get; set; }
        internal Surgeon Surgeon_Name { get; set; }
        internal Treatment_Type Treatment { get; set; }

        internal Appoainment() { }

        internal Appoainment(int id, string date, string registration_fees, Front_Officer created_by, Patient patient, Surgeon surgeon_name, Treatment_Type treatment)
        {
            ID = id;
            Date = date;
            Registration_Fees = registration_fees;
            Created_By = created_by;
            Patient = patient;
            Surgeon_Name = surgeon_name;
            Treatment = treatment;
        }

        internal bool save()
        {
            try
            {
                this.ID = lastInsertedID++;
                DB.appoainments.Add(new Appoainment(this.ID, this.Date, this.Registration_Fees, this.Created_By, this.Patient, this.Surgeon_Name, this.Treatment));
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
                    foreach (Appoainment appoainment in DB.appoainments)
                    {
                        if (appoainment.ID == this.ID)
                        {
                            appoainment.Date = this.Date;
                            appoainment.Registration_Fees = this.Registration_Fees;
                            appoainment.Created_By = this.Created_By;
                            appoainment.Patient = this.Patient;
                            appoainment.Surgeon_Name = this.Surgeon_Name;
                            appoainment.Treatment = this.Treatment;
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
                    foreach (Appoainment appoainment in DB.appoainments)
                    {
                        if (appoainment.ID == this.ID)
                        {
                            DB.appoainments.Remove(appoainment);
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
            dt.Columns.Add("Date");
            dt.Columns.Add("Registration Fees");
            dt.Columns.Add("Enter Register");
            dt.Columns.Add("Patient");
            dt.Columns.Add("Surgeon");
            dt.Columns.Add("Treatment");


            foreach (Appoainment appoainment in DB.appoainments)
            {
                dt.Rows.Add(new Object[]
                {
                   appoainment.ID, appoainment.Date, appoainment.Registration_Fees, appoainment.Created_By.Name, appoainment.Patient.Name, appoainment.Surgeon_Name.Name, appoainment.Treatment.Name,
                }); ;
            }

            return dt;
        }

        internal static void loadFk(ComboBox fkBox)
        {
            fkBox.DisplayMember = "Name";
            fkBox.ValueMember = "Id";
            fkBox.DataSource = new Appoainment().generateDataTable();
        }

        internal static Appoainment getObjectByID(string id)
        {
            int _id = int.Parse(id);

            foreach (Appoainment appoainment in DB.appoainments)
            {
                if (appoainment.ID == _id)
                {
                    return appoainment;
                }
            }

            return null;
        }
    }
}
