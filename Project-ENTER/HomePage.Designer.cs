namespace Project_ENTER
{
    partial class HomePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.Delog = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.drepturi_autor = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.review_btn = new System.Windows.Forms.Button();
            this.shopingcart_btn = new System.Windows.Forms.Button();
            this.contacts_btn = new System.Windows.Forms.Button();
            this.products_btn = new System.Windows.Forms.Button();
            this.employees_btn = new System.Windows.Forms.Button();
            this.HOME_btn = new System.Windows.Forms.Button();
            this.review1 = new Project_ENTER.Review();
            this.contacts1 = new Project_ENTER.Contacts();
            this.products1 = new Project_ENTER.Products();
            this.employees1 = new Project_ENTER.Employees();
            this.home1 = new Project_ENTER.Home();
            this.shopingCart1 = new Project_ENTER.ShopingCart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.review_btn);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.shopingcart_btn);
            this.panel1.Controls.Add(this.contacts_btn);
            this.panel1.Controls.Add(this.products_btn);
            this.panel1.Controls.Add(this.employees_btn);
            this.panel1.Controls.Add(this.HOME_btn);
            this.panel1.Controls.Add(this.Delog);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 652);
            this.panel1.TabIndex = 2;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.SidePanel.Location = new System.Drawing.Point(0, 122);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(8, 51);
            this.SidePanel.TabIndex = 1;
            // 
            // Delog
            // 
            this.Delog.BackColor = System.Drawing.Color.Red;
            this.Delog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delog.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delog.Location = new System.Drawing.Point(11, 601);
            this.Delog.Name = "Delog";
            this.Delog.Size = new System.Drawing.Size(122, 40);
            this.Delog.TabIndex = 9;
            this.Delog.Text = "SIGN OUT";
            this.Delog.UseVisualStyleBackColor = false;
            this.Delog.Click += new System.EventHandler(this.Delog_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.drepturi_autor);
            this.panel4.Controls.Add(this.exit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(237, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(741, 51);
            this.panel4.TabIndex = 4;
            // 
            // drepturi_autor
            // 
            this.drepturi_autor.AutoSize = true;
            this.drepturi_autor.Location = new System.Drawing.Point(223, 18);
            this.drepturi_autor.Name = "drepturi_autor";
            this.drepturi_autor.Size = new System.Drawing.Size(330, 16);
            this.drepturi_autor.TabIndex = 23;
            this.drepturi_autor.Text = "Copyright © 2024 Enter. Toate drepturile sunt rezervate.";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(709, 13);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 22);
            this.exit.TabIndex = 22;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Project_ENTER.Properties.Resources.telegram;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(162, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 38);
            this.button4.TabIndex = 26;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Project_ENTER.Properties.Resources.yt;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(110, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 38);
            this.button3.TabIndex = 25;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Project_ENTER.Properties.Resources.insta;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(59, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 38);
            this.button2.TabIndex = 24;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Project_ENTER.Properties.Resources.facebook;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 38);
            this.button1.TabIndex = 23;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // review_btn
            // 
            this.review_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.review_btn.FlatAppearance.BorderSize = 0;
            this.review_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.review_btn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review_btn.Image = global::Project_ENTER.Properties.Resources.review_icon;
            this.review_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.review_btn.Location = new System.Drawing.Point(7, 419);
            this.review_btn.Name = "review_btn";
            this.review_btn.Size = new System.Drawing.Size(228, 54);
            this.review_btn.TabIndex = 22;
            this.review_btn.Text = " Review";
            this.review_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.review_btn.UseVisualStyleBackColor = true;
            this.review_btn.Click += new System.EventHandler(this.review_btn_Click);
            // 
            // shopingcart_btn
            // 
            this.shopingcart_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shopingcart_btn.FlatAppearance.BorderSize = 0;
            this.shopingcart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopingcart_btn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopingcart_btn.Image = global::Project_ENTER.Properties.Resources.sc_icon;
            this.shopingcart_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shopingcart_btn.Location = new System.Drawing.Point(7, 359);
            this.shopingcart_btn.Name = "shopingcart_btn";
            this.shopingcart_btn.Size = new System.Drawing.Size(228, 54);
            this.shopingcart_btn.TabIndex = 21;
            this.shopingcart_btn.Text = " Shoping cart";
            this.shopingcart_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.shopingcart_btn.UseVisualStyleBackColor = true;
            this.shopingcart_btn.Click += new System.EventHandler(this.shopingcart_btn_Click);
            // 
            // contacts_btn
            // 
            this.contacts_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contacts_btn.FlatAppearance.BorderSize = 0;
            this.contacts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contacts_btn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacts_btn.Image = global::Project_ENTER.Properties.Resources.ctc_icon;
            this.contacts_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contacts_btn.Location = new System.Drawing.Point(7, 299);
            this.contacts_btn.Name = "contacts_btn";
            this.contacts_btn.Size = new System.Drawing.Size(228, 54);
            this.contacts_btn.TabIndex = 20;
            this.contacts_btn.Text = " Contacts";
            this.contacts_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.contacts_btn.UseVisualStyleBackColor = true;
            this.contacts_btn.Click += new System.EventHandler(this.contacts_btn_Click);
            // 
            // products_btn
            // 
            this.products_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.products_btn.FlatAppearance.BorderSize = 0;
            this.products_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products_btn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_btn.Image = global::Project_ENTER.Properties.Resources.products;
            this.products_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.products_btn.Location = new System.Drawing.Point(7, 239);
            this.products_btn.Name = "products_btn";
            this.products_btn.Size = new System.Drawing.Size(228, 54);
            this.products_btn.TabIndex = 19;
            this.products_btn.Text = " Products";
            this.products_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.products_btn.UseVisualStyleBackColor = true;
            this.products_btn.Click += new System.EventHandler(this.products_btn_Click);
            // 
            // employees_btn
            // 
            this.employees_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employees_btn.FlatAppearance.BorderSize = 0;
            this.employees_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employees_btn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employees_btn.Image = global::Project_ENTER.Properties.Resources.contacts_icon1;
            this.employees_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employees_btn.Location = new System.Drawing.Point(7, 179);
            this.employees_btn.Name = "employees_btn";
            this.employees_btn.Size = new System.Drawing.Size(228, 54);
            this.employees_btn.TabIndex = 18;
            this.employees_btn.Text = " Employees";
            this.employees_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.employees_btn.UseVisualStyleBackColor = true;
            this.employees_btn.Click += new System.EventHandler(this.employees_btn_Click);
            // 
            // HOME_btn
            // 
            this.HOME_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HOME_btn.FlatAppearance.BorderSize = 0;
            this.HOME_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HOME_btn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOME_btn.Image = global::Project_ENTER.Properties.Resources.home_icon;
            this.HOME_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HOME_btn.Location = new System.Drawing.Point(7, 119);
            this.HOME_btn.Name = "HOME_btn";
            this.HOME_btn.Size = new System.Drawing.Size(228, 54);
            this.HOME_btn.TabIndex = 17;
            this.HOME_btn.Text = " Home";
            this.HOME_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HOME_btn.UseVisualStyleBackColor = true;
            this.HOME_btn.Click += new System.EventHandler(this.HOME_btn_Click);
            // 
            // review1
            // 
            this.review1.BackColor = System.Drawing.Color.PapayaWhip;
            this.review1.Location = new System.Drawing.Point(237, 51);
            this.review1.Name = "review1";
            this.review1.Size = new System.Drawing.Size(741, 601);
            this.review1.TabIndex = 10;
            // 
            // contacts1
            // 
            this.contacts1.BackColor = System.Drawing.Color.PapayaWhip;
            this.contacts1.Location = new System.Drawing.Point(237, 51);
            this.contacts1.Name = "contacts1";
            this.contacts1.Size = new System.Drawing.Size(741, 601);
            this.contacts1.TabIndex = 9;
            // 
            // products1
            // 
            this.products1.BackColor = System.Drawing.Color.PapayaWhip;
            this.products1.Location = new System.Drawing.Point(237, 51);
            this.products1.Name = "products1";
            this.products1.Size = new System.Drawing.Size(741, 601);
            this.products1.TabIndex = 8;
            // 
            // employees1
            // 
            this.employees1.BackColor = System.Drawing.Color.PapayaWhip;
            this.employees1.Location = new System.Drawing.Point(237, 51);
            this.employees1.Name = "employees1";
            this.employees1.Size = new System.Drawing.Size(741, 601);
            this.employees1.TabIndex = 7;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.PapayaWhip;
            this.home1.Location = new System.Drawing.Point(237, 51);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(741, 601);
            this.home1.TabIndex = 6;
            // 
            // shopingCart1
            // 
            this.shopingCart1.BackColor = System.Drawing.Color.PapayaWhip;
            this.shopingCart1.Location = new System.Drawing.Point(237, 51);
            this.shopingCart1.Name = "shopingCart1";
            this.shopingCart1.Size = new System.Drawing.Size(741, 601);
            this.shopingCart1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Project_ENTER.Properties.Resources.enter_logo;
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(13, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 70);
            this.panel2.TabIndex = 12;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(978, 652);
            this.Controls.Add(this.review1);
            this.Controls.Add(this.contacts1);
            this.Controls.Add(this.products1);
            this.Controls.Add(this.employees1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.shopingCart1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Delog;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Button HOME_btn;
        private System.Windows.Forms.Button review_btn;
        private System.Windows.Forms.Button shopingcart_btn;
        private System.Windows.Forms.Button contacts_btn;
        private System.Windows.Forms.Button products_btn;
        private System.Windows.Forms.Button employees_btn;
        private System.Windows.Forms.Label drepturi_autor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel SidePanel;
        private ShopingCart shopingCart1;
        private Home home1;
        private Employees employees1;
        private Products products1;
        private Contacts contacts1;
        private Review review1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}