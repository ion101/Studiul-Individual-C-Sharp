namespace Project_ENTER
{
    partial class Employees
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.insert_btn = new System.Windows.Forms.Button();
            this.select_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataAngajarii = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalariu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.eNTERDataSet = new Project_ENTER.ENTERDataSet();
            this.locatiiFilialeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locatii_FilialeTableAdapter = new Project_ENTER.ENTERDataSetTableAdapters.Locatii_FilialeTableAdapter();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.comboBoxFiliale = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNTERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatiiFilialeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.insert_btn.FlatAppearance.BorderSize = 0;
            this.insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.Location = new System.Drawing.Point(51, 305);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(133, 37);
            this.insert_btn.TabIndex = 19;
            this.insert_btn.Text = "INSERT";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // select_btn
            // 
            this.select_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.select_btn.FlatAppearance.BorderSize = 0;
            this.select_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_btn.Location = new System.Drawing.Point(222, 305);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(133, 37);
            this.select_btn.TabIndex = 20;
            this.select_btn.Text = "SELECT";
            this.select_btn.UseVisualStyleBackColor = false;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(392, 305);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(133, 37);
            this.update_btn.TabIndex = 21;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(558, 305);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(133, 37);
            this.delete_btn.TabIndex = 22;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Coral;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 369);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(640, 195);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Numele";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Prenumele";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Data nașterii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Data angajării";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(197, 84);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(154, 22);
            this.txtNume.TabIndex = 29;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(197, 127);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(154, 22);
            this.txtPrenume.TabIndex = 30;
            this.txtPrenume.TextChanged += new System.EventHandler(this.txtPrenume_TextChanged);
            // 
            // dateTimePickerDataNasterii
            // 
            this.dateTimePickerDataNasterii.Location = new System.Drawing.Point(197, 170);
            this.dateTimePickerDataNasterii.Name = "dateTimePickerDataNasterii";
            this.dateTimePickerDataNasterii.Size = new System.Drawing.Size(154, 22);
            this.dateTimePickerDataNasterii.TabIndex = 33;
            this.dateTimePickerDataNasterii.ValueChanged += new System.EventHandler(this.dateTimePickerDataNasterii_ValueChanged);
            // 
            // dateTimePickerDataAngajarii
            // 
            this.dateTimePickerDataAngajarii.Location = new System.Drawing.Point(197, 215);
            this.dateTimePickerDataAngajarii.Name = "dateTimePickerDataAngajarii";
            this.dateTimePickerDataAngajarii.Size = new System.Drawing.Size(154, 22);
            this.dateTimePickerDataAngajarii.TabIndex = 34;
            this.dateTimePickerDataAngajarii.ValueChanged += new System.EventHandler(this.dateTimePickerDataAngajarii_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = "Salariul";
            // 
            // txtSalariu
            // 
            this.txtSalariu.Location = new System.Drawing.Point(523, 84);
            this.txtSalariu.Name = "txtSalariu";
            this.txtSalariu.Size = new System.Drawing.Size(156, 22);
            this.txtSalariu.TabIndex = 36;
            this.txtSalariu.TextChanged += new System.EventHandler(this.txtSalariu_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(414, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 37;
            this.label6.Text = "Adresa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(414, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 22);
            this.label7.TabIndex = 38;
            this.label7.Text = "Telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(414, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 22);
            this.label8.TabIndex = 39;
            this.label8.Text = "E-mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(276, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 22);
            this.label9.TabIndex = 40;
            this.label9.Text = "ID Filiala";
            // 
            // eNTERDataSet
            // 
            this.eNTERDataSet.DataSetName = "ENTERDataSet";
            this.eNTERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locatiiFilialeBindingSource
            // 
            this.locatiiFilialeBindingSource.DataMember = "Locatii_Filiale";
            this.locatiiFilialeBindingSource.DataSource = this.eNTERDataSet;
            // 
            // locatii_FilialeTableAdapter
            // 
            this.locatii_FilialeTableAdapter.ClearBeforeFill = true;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(523, 127);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(156, 22);
            this.txtAdresa.TabIndex = 42;
            this.txtAdresa.TextChanged += new System.EventHandler(this.txtAdresa_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(523, 172);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(156, 22);
            this.txtTelefon.TabIndex = 43;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(523, 217);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 22);
            this.txtEmail.TabIndex = 44;
            // 
            // comboBoxFiliale
            // 
            this.comboBoxFiliale.FormattingEnabled = true;
            this.comboBoxFiliale.Items.AddRange(new object[] {
            "1111",
            "1112",
            "1113",
            "1114",
            "1115",
            "1116",
            "1117",
            "1118",
            "1119",
            "1120",
            "1121",
            "1122",
            "1123",
            "1124",
            "1125",
            "1126",
            "1127",
            "1128",
            "1129",
            "1130",
            "1131",
            "1132",
            "1133"});
            this.comboBoxFiliale.Location = new System.Drawing.Point(377, 258);
            this.comboBoxFiliale.Name = "comboBoxFiliale";
            this.comboBoxFiliale.Size = new System.Drawing.Size(97, 24);
            this.comboBoxFiliale.TabIndex = 45;
            this.comboBoxFiliale.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiliale_SelectedIndexChanged);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.comboBoxFiliale);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSalariu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDataAngajarii);
            this.Controls.Add(this.dateTimePickerDataNasterii);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.insert_btn);
            this.Name = "Employees";
            this.Size = new System.Drawing.Size(741, 601);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNTERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatiiFilialeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNasterii;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataAngajarii;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalariu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource locatiiFilialeBindingSource;
        private ENTERDataSet eNTERDataSet;
        private ENTERDataSetTableAdapters.Locatii_FilialeTableAdapter locatii_FilialeTableAdapter;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox comboBoxFiliale;
    }
}
