namespace Coursework_1
{
    partial class Appoainment_Form
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
            this.label6 = new System.Windows.Forms.Label();
            this.Register_Fee_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.load_table = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Appoainment_Date_Box = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Patient_CmBox = new System.Windows.Forms.ComboBox();
            this.Treatment_CmBox = new System.Windows.Forms.ComboBox();
            this.Surgeon_CmBox = new System.Windows.Forms.ComboBox();
            this.front_officer_CmBox = new System.Windows.Forms.ComboBox();
            this.back_page = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.delete_btn.TabIndex = 19;
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
            this.update_btn.TabIndex = 20;
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
            this.save_btn.TabIndex = 21;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Front Officer : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Surgeon : ";
            // 
            // Register_Fee_Box
            // 
            this.Register_Fee_Box.BackColor = System.Drawing.Color.Gainsboro;
            this.Register_Fee_Box.Location = new System.Drawing.Point(230, 114);
            this.Register_Fee_Box.Name = "Register_Fee_Box";
            this.Register_Fee_Box.Size = new System.Drawing.Size(257, 22);
            this.Register_Fee_Box.TabIndex = 16;
            this.Register_Fee_Box.TextChanged += new System.EventHandler(this.Register_Fee_Box_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Register Fee : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Patient : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date : ";
            // 
            // load_table
            // 
            this.load_table.AllowUserToAddRows = false;
            this.load_table.AllowUserToDeleteRows = false;
            this.load_table.BackgroundColor = System.Drawing.Color.LightGray;
            this.load_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.load_table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.load_table.Location = new System.Drawing.Point(109, 306);
            this.load_table.Name = "load_table";
            this.load_table.ReadOnly = true;
            this.load_table.RowHeadersWidth = 51;
            this.load_table.RowTemplate.Height = 24;
            this.load_table.Size = new System.Drawing.Size(784, 334);
            this.load_table.TabIndex = 7;
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
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 34);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tooth Care Appoainment Page";
            // 
            // Appoainment_Date_Box
            // 
            this.Appoainment_Date_Box.Location = new System.Drawing.Point(230, 74);
            this.Appoainment_Date_Box.Name = "Appoainment_Date_Box";
            this.Appoainment_Date_Box.Size = new System.Drawing.Size(255, 22);
            this.Appoainment_Date_Box.TabIndex = 23;
            this.Appoainment_Date_Box.ValueChanged += new System.EventHandler(this.Appoainment_Date_Box_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Treatment : ";
            // 
            // Patient_CmBox
            // 
            this.Patient_CmBox.BackColor = System.Drawing.Color.Gainsboro;
            this.Patient_CmBox.FormattingEnabled = true;
            this.Patient_CmBox.Location = new System.Drawing.Point(230, 189);
            this.Patient_CmBox.Name = "Patient_CmBox";
            this.Patient_CmBox.Size = new System.Drawing.Size(257, 24);
            this.Patient_CmBox.TabIndex = 24;
            this.Patient_CmBox.SelectedIndexChanged += new System.EventHandler(this.Patient_CmBox_SelectedIndexChanged);
            // 
            // Treatment_CmBox
            // 
            this.Treatment_CmBox.BackColor = System.Drawing.Color.Gainsboro;
            this.Treatment_CmBox.FormattingEnabled = true;
            this.Treatment_CmBox.Location = new System.Drawing.Point(230, 267);
            this.Treatment_CmBox.Name = "Treatment_CmBox";
            this.Treatment_CmBox.Size = new System.Drawing.Size(257, 24);
            this.Treatment_CmBox.TabIndex = 24;
            this.Treatment_CmBox.SelectedIndexChanged += new System.EventHandler(this.Treatment_CmBox_SelectedIndexChanged);
            // 
            // Surgeon_CmBox
            // 
            this.Surgeon_CmBox.BackColor = System.Drawing.Color.Gainsboro;
            this.Surgeon_CmBox.FormattingEnabled = true;
            this.Surgeon_CmBox.Location = new System.Drawing.Point(230, 227);
            this.Surgeon_CmBox.Name = "Surgeon_CmBox";
            this.Surgeon_CmBox.Size = new System.Drawing.Size(255, 24);
            this.Surgeon_CmBox.TabIndex = 25;
            this.Surgeon_CmBox.SelectedIndexChanged += new System.EventHandler(this.Surgeon_CmBox_SelectedIndexChanged);
            // 
            // front_officer_CmBox
            // 
            this.front_officer_CmBox.BackColor = System.Drawing.Color.Gainsboro;
            this.front_officer_CmBox.FormattingEnabled = true;
            this.front_officer_CmBox.Location = new System.Drawing.Point(230, 150);
            this.front_officer_CmBox.Name = "front_officer_CmBox";
            this.front_officer_CmBox.Size = new System.Drawing.Size(255, 24);
            this.front_officer_CmBox.TabIndex = 26;
            this.front_officer_CmBox.SelectedIndexChanged += new System.EventHandler(this.front_officer_CmBox_SelectedIndexChanged);
            // 
            // back_page
            // 
            this.back_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.back_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_page.ForeColor = System.Drawing.Color.White;
            this.back_page.Location = new System.Drawing.Point(611, 262);
            this.back_page.Name = "back_page";
            this.back_page.Size = new System.Drawing.Size(282, 38);
            this.back_page.TabIndex = 27;
            this.back_page.Text = "Back To the Page";
            this.back_page.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(681, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(616, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Search : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(803, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 38);
            this.button1.TabIndex = 30;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Appoainment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coursework_1.Properties.Resources.a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.back_page);
            this.Controls.Add(this.front_officer_CmBox);
            this.Controls.Add(this.Surgeon_CmBox);
            this.Controls.Add(this.Treatment_CmBox);
            this.Controls.Add(this.Patient_CmBox);
            this.Controls.Add(this.Appoainment_Date_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Register_Fee_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.load_table);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appoainment_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appoainment";
            this.Load += new System.EventHandler(this.Appoainment_Load);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Register_Fee_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView load_table;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Appoainment_Date_Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Patient_CmBox;
        private System.Windows.Forms.ComboBox Treatment_CmBox;
        private System.Windows.Forms.ComboBox Surgeon_CmBox;
        private System.Windows.Forms.ComboBox front_officer_CmBox;
        private System.Windows.Forms.Button back_page;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}