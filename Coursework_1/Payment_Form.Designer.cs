namespace Coursework_1
{
    partial class Payment_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.load_table = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Amount_CmBox = new System.Windows.Forms.ComboBox();
            this.payment_date_box = new System.Windows.Forms.DateTimePicker();
            this.Appoainment_ID_CmBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Treatment_CmBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Amount2_CmBox = new System.Windows.Forms.ComboBox();
            this.back_page = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.load_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(803, 218);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(90, 38);
            this.delete_btn.TabIndex = 53;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(707, 218);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(90, 38);
            this.update_btn.TabIndex = 54;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Blue;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(611, 218);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(90, 38);
            this.save_btn.TabIndex = 55;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 43;
            this.label4.Text = "Surgeon : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Patient : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "Date : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 34);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tooth Care Payment Page";
            // 
            // load_table
            // 
            this.load_table.AllowUserToAddRows = false;
            this.load_table.AllowUserToDeleteRows = false;
            this.load_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.load_table.BackgroundColor = System.Drawing.Color.LightGray;
            this.load_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.load_table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.load_table.Location = new System.Drawing.Point(109, 306);
            this.load_table.Name = "load_table";
            this.load_table.ReadOnly = true;
            this.load_table.RowHeadersWidth = 51;
            this.load_table.RowTemplate.Height = 24;
            this.load_table.Size = new System.Drawing.Size(784, 334);
            this.load_table.TabIndex = 41;
            this.load_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.load_table_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Coursework_1.Properties.Resources.Blue_Dental_Clinic_Logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(864, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 121);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // Amount_CmBox
            // 
            this.Amount_CmBox.BackColor = System.Drawing.Color.Gainsboro;
            this.Amount_CmBox.FormattingEnabled = true;
            this.Amount_CmBox.Location = new System.Drawing.Point(287, 171);
            this.Amount_CmBox.Name = "Amount_CmBox";
            this.Amount_CmBox.Size = new System.Drawing.Size(254, 24);
            this.Amount_CmBox.TabIndex = 56;
            this.Amount_CmBox.SelectedIndexChanged += new System.EventHandler(this.Amount_CmBox_SelectedIndexChanged);
            // 
            // payment_date_box
            // 
            this.payment_date_box.Location = new System.Drawing.Point(287, 96);
            this.payment_date_box.Name = "payment_date_box";
            this.payment_date_box.Size = new System.Drawing.Size(254, 22);
            this.payment_date_box.TabIndex = 57;
            this.payment_date_box.ValueChanged += new System.EventHandler(this.payment_date_box_ValueChanged);
            // 
            // Appoainment_ID_CmBox
            // 
            this.Appoainment_ID_CmBox.BackColor = System.Drawing.Color.Gainsboro;
            this.Appoainment_ID_CmBox.FormattingEnabled = true;
            this.Appoainment_ID_CmBox.Location = new System.Drawing.Point(287, 132);
            this.Appoainment_ID_CmBox.Name = "Appoainment_ID_CmBox";
            this.Appoainment_ID_CmBox.Size = new System.Drawing.Size(254, 24);
            this.Appoainment_ID_CmBox.TabIndex = 56;
            this.Appoainment_ID_CmBox.SelectedIndexChanged += new System.EventHandler(this.Appoainment_ID_CmBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "Treatment : ";
            // 
            // Treatment_CmBox
            // 
            this.Treatment_CmBox.BackColor = System.Drawing.Color.Gainsboro;
            this.Treatment_CmBox.FormattingEnabled = true;
            this.Treatment_CmBox.Location = new System.Drawing.Point(287, 210);
            this.Treatment_CmBox.Name = "Treatment_CmBox";
            this.Treatment_CmBox.Size = new System.Drawing.Size(254, 24);
            this.Treatment_CmBox.TabIndex = 58;
            this.Treatment_CmBox.SelectedIndexChanged += new System.EventHandler(this.Treatment_CmBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "Amount : ";
            // 
            // Amount2_CmBox
            // 
            this.Amount2_CmBox.BackColor = System.Drawing.Color.Gainsboro;
            this.Amount2_CmBox.FormattingEnabled = true;
            this.Amount2_CmBox.Location = new System.Drawing.Point(287, 249);
            this.Amount2_CmBox.Name = "Amount2_CmBox";
            this.Amount2_CmBox.Size = new System.Drawing.Size(254, 24);
            this.Amount2_CmBox.TabIndex = 58;
            this.Amount2_CmBox.SelectedIndexChanged += new System.EventHandler(this.Amount2_CmBox_SelectedIndexChanged);
            // 
            // back_page
            // 
            this.back_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.back_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_page.ForeColor = System.Drawing.Color.White;
            this.back_page.Location = new System.Drawing.Point(611, 262);
            this.back_page.Name = "back_page";
            this.back_page.Size = new System.Drawing.Size(282, 38);
            this.back_page.TabIndex = 59;
            this.back_page.Text = "Back To the Page";
            this.back_page.UseVisualStyleBackColor = false;
            // 
            // Payment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coursework_1.Properties.Resources.a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.back_page);
            this.Controls.Add(this.Amount2_CmBox);
            this.Controls.Add(this.Treatment_CmBox);
            this.Controls.Add(this.payment_date_box);
            this.Controls.Add(this.Appoainment_ID_CmBox);
            this.Controls.Add(this.Amount_CmBox);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.load_table);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.load_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView load_table;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Amount_CmBox;
        private System.Windows.Forms.DateTimePicker payment_date_box;
        private System.Windows.Forms.ComboBox Appoainment_ID_CmBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Treatment_CmBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Amount2_CmBox;
        private System.Windows.Forms.Button back_page;
    }
}