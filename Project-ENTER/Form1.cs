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
    public partial class Form1 : Form
    {
        // am facut conectarea cu Baza de Date SQL
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ionmu\OneDrive\Documente\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void login_password_TextChanged(object sender, EventArgs e){}
        private void login_username_TextChanged(object sender, EventArgs e){}
        private void label5_Click(object sender, EventArgs e){}

        // butonul din partea dreapta sus, care ne ajuta sa inchidem programul
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Ascundem Forma data si o afisam pe cea cu Inregistrare a contului
        private void login_SignUp_btn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        // Ne ajuta sa afisam Parola sau sa o criptam
        private void login_Show_Pass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_Show_Pass.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // Verificam ca toate campurile sa fie completate de catre utilizator
            if(login_username.Text == ""
                || login_password.Text == "")
            {
                // Afisam un mesaj de eroare
                MessageBox.Show("Va rugam sa completati toate campurile!",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        // Deschidem conextiunea cu DB in care sunt stocati utilizatorii
                        connect.Open();

                        string selectData = "SELECT * FROM users WHERE username = @username " +
                            "AND password = @password";

                        // verificam in consola daca valorile sunt cele asteptate
                        Console.WriteLine("Username value: " + login_username.Text.Trim());
                        Console.WriteLine("Password value: " + login_password.Text.Trim());

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());
                           
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            // Verificam daca exista vriun utilizator cu aceste date in baza de date
                            if(table.Rows.Count >= 1)
                            {
                                // Daca exista, afisam un mesaj corespunzator si intram in aplicatia propriu-zisa (Forma HomePage)
                                MessageBox.Show("Logat cu succes!"
                                    , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                HomePage mForm = new HomePage();
                                mForm.Show();
                            }
                            else
                            {
                                // Altfel, afisam un mesaj de eroare corespunzator
                                MessageBox.Show("Nume de utilizator/Parola incorecta"
                                    , "Error Mesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
