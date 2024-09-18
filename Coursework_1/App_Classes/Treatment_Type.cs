using Coursework_1.DBClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_1.App_Classes
{
    internal class Treatment_Type
    {
        private static int lastInsertedID = 6;
        internal int ID { get; set; }
        internal string Name { get; set; }
        internal string Amount { get; set; }

        internal Treatment_Type()
        {

        }

        internal Treatment_Type(int id, string name, string amount)
        {
            ID = id;
            Name = name;
            Amount = amount;
        }

        internal bool save()
        {
            try
            {
                this.ID = lastInsertedID++;
                DB.treatment_types.Add(new Treatment_Type(this.ID , this.Name , this.Amount));
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
                    foreach (Treatment_Type tr_type in DB.treatment_types)
                    {
                        if (tr_type.ID == this.ID)
                        {
                            tr_type.Name = this.Name;
                            tr_type.Amount = this.Amount;
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
                    foreach (Treatment_Type tr_type in DB.treatment_types)
                    {
                        if (tr_type.ID == this.ID)
                        {
                            DB.treatment_types.Remove(tr_type);
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
            dt.Columns.Add("Amount");

            foreach (Treatment_Type treatment_type in DB.treatment_types)
            {
                dt.Rows.Add(new Object[]
                {
                   treatment_type.ID, treatment_type.Name, treatment_type.Amount
                });;
            }

            return dt;
        }

        internal static void loadFk(ComboBox fkBox)
        {
            fkBox.DisplayMember = "Name";
            fkBox.ValueMember = "Id";
            fkBox.DataSource = new Treatment_Type().generateDataTable();
        }

        internal static Treatment_Type getObjectByID(string id)
        {
            int _id = int.Parse(id);

            foreach (Treatment_Type treatment_Type in DB.treatment_types)
            {
                if (treatment_Type.ID == _id)
                {
                    return treatment_Type;
                }
            }

            return null;
        }
    }
}
