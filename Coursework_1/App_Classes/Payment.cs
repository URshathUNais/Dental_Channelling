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
    internal class Payment
    {
        private static int lastInsertedID = 1;
        internal int ID { get; set; }
        internal string Date { get; set; }
        internal Patient Patient_Name { get; set; }
        internal Surgeon Surgeon_Name { get; set; }
        internal Treatment_Type Treatment { get; set; }
        internal Treatment_Type Amount { get; set; }

        internal Payment() { }

        internal Payment(int id, string date, Patient patient_name, Surgeon surgeon_name, Treatment_Type treatment, Treatment_Type amount)
        {
            ID = id;
            Date = date;
            Patient_Name = patient_name;
            Surgeon_Name = surgeon_name;
            Treatment = treatment;
            Amount = amount;
        }

        internal bool save()
        {
            try
            {
                this.ID = lastInsertedID++;
                DB.payments.Add(new Payment(this.ID , this.Date , this.Patient_Name , this.Surgeon_Name , this.Treatment , this.Amount));
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
                    foreach (Payment pay in DB.payments)
                    {
                        if (pay.ID == this.ID)
                        {
                            pay.Date = this.Date;
                            pay.Patient_Name = this.Patient_Name;
                            pay.Surgeon_Name = this.Surgeon_Name;
                            pay.Treatment = this.Treatment;
                            pay.Amount = this.Amount;
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
                    foreach (Payment pay in DB.payments)
                    {
                        if (pay.ID == this.ID)
                        {
                            DB.payments.Remove(pay);
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
            dt.Columns.Add("Patient");
            dt.Columns.Add("Surgeon");
            dt.Columns.Add("Treatment");
            dt.Columns.Add("Amount");

            foreach (Payment payment in DB.payments)
            {
                dt.Rows.Add(new Object[]
                {
                   payment.ID, payment.Date, payment.Patient_Name.Name, payment.Surgeon_Name.Name, payment.Treatment.Name, payment.Amount.Amount,
                }); ;
            }

            return dt;
        }

        internal static void loadFk(ComboBox fkBox)
        {
            fkBox.DisplayMember = "Name";
            fkBox.ValueMember = "Id";
            fkBox.DataSource = new Payment().generateDataTable();
        }

        internal static Payment getObjectByID(string id)
        {
            int _id = int.Parse(id);

            foreach (Payment payment in DB.payments)
            {
                if (payment.ID == _id)
                {
                    return payment;
                }
            }
            return null;
        }
    }
}
