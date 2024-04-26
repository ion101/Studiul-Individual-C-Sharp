using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Project_ENTER
{
    public partial class RegisterForm : Form
    {
        // am facut conectarea cu Baza de Date SQL
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ionmu\OneDrive\Documente\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        // butonul din partea stanga sus, care ne ajuta sa inchidem programul
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Ascundem Forma data si o afisam pe cea cu Logare a contului
        private void signup_login_btn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        // Ne ajuta sa afisam Parola sau sa o criptam
        private void signup_Show_Pass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_Show_Pass.Checked ? '\0' : '*';
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if(signup_username.Text == ""
                || signup_password.Text == "")
            {
                // Daca utilizatorul nu a completat unul dintre campuri, afisam un text corespunzator
                MessageBox.Show(signup_username.Text.Trim() + " Va rugam sa completati toate campurile!", 
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open)
                {
                    try
                    {
                        // Deschidem conextiunea
                        connect.Open();
                        //Pentru a verifica daca utilizatorul exista deja
                        string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @username";

                        using(SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count >= 1) 
                            {
                                MessageBox.Show("Exista deja!",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // Luam ca data, data curenta, pentru a vedea data in care a fost creat un cont
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO users " +
                                    "(username, password, date_register) " +
                                    "VALUES(@username, @password, @date_register)";

                                // Inseram inregistrarile in baza de date
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date_register", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Inregistrare cu succes!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Daca inregistrarea noului utilizator s-a facut cu succes, atunci automat afisam deja Forma cu logare in cont a utilizatorilor
                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Tratam exceptia
                        MessageBox.Show("Error: " + ex,
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Inchidem conectiunea
                        connect.Close();
                    }
                }
            }
        }

        private void signup_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
