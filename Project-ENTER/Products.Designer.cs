namespace Project_ENTER
{
    partial class Products
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
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.select_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDProdus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "1001",
            "1002",
            "1003",
            "1004",
            "1005",
            "1006",
            "1007",
            "1008",
            "1009",
            "1010"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(522, 105);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(156, 24);
            this.comboBoxCategoria.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(413, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 64;
            this.label9.Text = "Categoria";
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(522, 60);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(156, 22);
            this.txtPret.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 22);
            this.label5.TabIndex = 59;
            this.label5.Text = "Pret";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(196, 103);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(154, 22);
            this.txtDenumire.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 53;
            this.label3.Text = "Descriere";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 52;
            this.label1.Text = "Denumire";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.Coral;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(50, 345);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.Size = new System.Drawing.Size(640, 195);
            this.dataGridViewProducts.TabIndex = 50;
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellClick);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(557, 281);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(133, 37);
            this.delete_btn.TabIndex = 49;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = false;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(391, 281);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(133, 37);
            this.update_btn.TabIndex = 48;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // select_btn
            // 
            this.select_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.select_btn.FlatAppearance.BorderSize = 0;
            this.select_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_btn.Location = new System.Drawing.Point(221, 281);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(133, 37);
            this.select_btn.TabIndex = 47;
            this.select_btn.Text = "SELECT";
            this.select_btn.UseVisualStyleBackColor = false;
            this.select_btn.Click += new System.EventHandler(this. select_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.insert_btn.FlatAppearance.BorderSize = 0;
            this.insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.Location = new System.Drawing.Point(50, 281);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(133, 37);
            this.insert_btn.TabIndex = 46;
            this.insert_btn.Text = "INSERT";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(196, 148);
            this.txtDescriere.Multiline = true;
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(482, 98);
            this.txtDescriere.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 51;
            this.label2.Text = "ID_Produs";
            // 
            // txtIDProdus
            // 
            this.txtIDProdus.Location = new System.Drawing.Point(196, 60);
            this.txtIDProdus.Name = "txtIDProdus";
            this.txtIDProdus.Size = new System.Drawing.Size(154, 22);
            this.txtIDProdus.TabIndex = 55;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.txtIDProdus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.insert_btn);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(741, 601);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDProdus;
    }
}
