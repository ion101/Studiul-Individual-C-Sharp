using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ENTER
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            SidePanel.Height = HOME_btn.Height;
            SidePanel.Top = HOME_btn.Top;
            home1.BringToFront();
        }

        private void catalog_Click(object sender, EventArgs e)
        {

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Delog_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void HOME_btn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HOME_btn.Height;
            SidePanel.Top = HOME_btn.Top;
            home1.BringToFront();

        }

        private void shopingcart_btn_Click(object sender, EventArgs e)
        {
            SidePanel.Height=shopingcart_btn.Height;
            SidePanel.Top = shopingcart_btn.Top;
            shopingCart1.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employees_btn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = employees_btn.Height;
            SidePanel.Top = employees_btn.Top;
            employees1.BringToFront();
        }

        private void products_btn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = products_btn.Height;
            SidePanel.Top = products_btn.Top;
            products1.BringToFront();

        }

        private void contacts_btn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = contacts_btn.Height;
            SidePanel.Top = contacts_btn.Top;
            contacts1.BringToFront();
        }

        private void review_btn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = review_btn.Height;
            SidePanel.Height = review_btn.Top;
            review1.BringToFront();
            
        }
    }
}
