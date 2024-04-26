using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ENTER
{
    public partial class Employees : UserControl
    {
        private string connectionString = "Data Source = DESKTOP-1JARFUU; Initial Catalog = ENTER; Integrated Security = True";
        public Employees()
        {
            InitializeComponent();
        }


        private void select_btn_Click(object sender, EventArgs e)
        {
            // Conexiunea către baza de date
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Comanda SQL pentru selectarea tuturor angajaților
                string query = "SELECT * FROM Angajati";

                // Deschiderea conexiunii
                connection.Open();

                // Crearea obiectului pentru comanda SQL
                SqlCommand command = new SqlCommand(query, connection);

                // Crearea obiectului pentru citirea rezultatelor
                SqlDataReader reader = command.ExecuteReader();

                // Verificarea dacă există rânduri în rezultatele citite
                if (reader.HasRows)
                {
                    // Crearea unui DataTable pentru a stoca rezultatele
                    DataTable dataTable = new DataTable();

                    // Umplerea DataTable cu rezultatele citite
                    dataTable.Load(reader);

                    // Afisarea rezultatelor în DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    // Dacă nu există rânduri, afișați un mesaj că nu s-au găsit angajați
                    MessageBox.Show("Nu s-au găsit angajați.");
                }

                // Închiderea obiectului pentru citirea rezultatelor
                reader.Close();
            }
        }

        private void ClearInsertControls()
        {
            // Resetați valorile din controalele de inserare
            txtNume.Text = "";
            txtPrenume.Text = "";
            dateTimePickerDataNasterii.Value = DateTime.Now;
            dateTimePickerDataAngajarii.Value = DateTime.Now;
            txtSalariu.Text = "";
            txtAdresa.Text = "";
            txtTelefon.Text = "";
            txtEmail.Text = "";
            comboBoxFiliale.SelectedIndex = -1;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            // Extrageți valorile introduse de utilizator din controalele TextBox, DateTimePicker etc.
            string nume = txtNume.Text;
            string prenume = txtPrenume.Text;
            DateTime dataNasterii = dateTimePickerDataNasterii.Value;
            DateTime dataAngajarii = dateTimePickerDataAngajarii.Value;
            string salariu = txtSalariu.Text;
            string adresa = txtAdresa.Text;
            string telefon = txtTelefon.Text;
            string email = txtEmail.Text;
            string idFiliala = comboBoxFiliale.SelectedItem.ToString();

            // Conexiunea către baza de date
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Comanda SQL pentru inserarea unui nou angajat
                string query = @"INSERT INTO Angajati (Nume, Prenume, Data_Nasterii, Data_Angajarii, Salariu, Adresa, Telefon, Email, ID_Filiala)
                         VALUES (@Nume, @Prenume, @DataNasterii, @DataAngajarii, @Salariu, @Adresa, @Telefon, @Email, @IDFiliala)";

                // Deschiderea conexiunii
                connection.Open();

                // Crearea obiectului pentru comanda SQL
                SqlCommand command = new SqlCommand(query, connection);

                // Parametrii pentru valorile introduse de utilizator
                command.Parameters.AddWithValue("@Nume", nume);
                command.Parameters.AddWithValue("@Prenume", prenume);
                command.Parameters.AddWithValue("@DataNasterii", dataNasterii);
                command.Parameters.AddWithValue("@DataAngajarii", dataAngajarii);
                command.Parameters.AddWithValue("@Salariu", salariu);
                command.Parameters.AddWithValue("@Adresa", adresa);
                command.Parameters.AddWithValue("@Telefon", telefon);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@IDFiliala", idFiliala);

                // Executarea comenzii SQL pentru inserarea angajatului
                int rowsAffected = command.ExecuteNonQuery();

                // Verificarea dacă inserarea s-a efectuat cu succes
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Angajatul a fost adăugat cu succes în baza de date.");
                }
                else
                {
                    MessageBox.Show("Inserarea angajatului a eșuat. Vă rugăm să verificați datele introduse.");
                }
            }
            ClearInsertControls();
        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrenume_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDataNasterii_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDataAngajarii_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSalariu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFiliale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificăm dacă a fost selectată o celulă validă
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obținem rândul care a fost selectat
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Extragem datele angajatului selectat din rândul DataGridView
                txtNume.Text = row.Cells["Nume"].Value.ToString();
                txtPrenume.Text = row.Cells["Prenume"].Value.ToString();
                dateTimePickerDataNasterii.Value = Convert.ToDateTime(row.Cells["Data_Nasterii"].Value);
                dateTimePickerDataAngajarii.Value = Convert.ToDateTime(row.Cells["Data_Angajarii"].Value);
                txtSalariu.Text = row.Cells["Salariu"].Value.ToString();
                txtAdresa.Text = row.Cells["Adresa"].Value.ToString();
                txtTelefon.Text = row.Cells["Telefon"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                comboBoxFiliale.SelectedItem = row.Cells["ID_Filiala"].Value.ToString();
            }
        }



        private void update_btn_Click(object sender, EventArgs e)
        {
            // Verificăm dacă a fost selectat un angajat în DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obținem rândul selectat
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Extragem ID-ul angajatului selectat
                int idAngajat = Convert.ToInt32(row.Cells["ID_Angajat"].Value);

                // Extragem datele actualizate din controalele de mai sus
                string nume = txtNume.Text;
                string prenume = txtPrenume.Text;
                DateTime dataNasterii = dateTimePickerDataNasterii.Value;
                DateTime dataAngajarii = dateTimePickerDataAngajarii.Value;
                string salariu = txtSalariu.Text;
                string adresa = txtAdresa.Text;
                string telefon = txtTelefon.Text;
                string email = txtEmail.Text;
                string idFiliala = comboBoxFiliale.SelectedItem.ToString();



                // Construim comanda SQL pentru actualizarea datelor
                string updateQuery = "UPDATE Angajati SET Nume=@Nume, Prenume=@Prenume, Data_Nasterii=@Data_Nasterii, Data_Angajarii=@Data_Angajarii, Salariu=@Salariu, Adresa=@Adresa, Telefon=@Telefon, Email=@Email, ID_Filiala=@ID_Filiala WHERE ID_Angajat=@ID_Angajat";

                // Conexiunea către baza de date
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Deschiderea conexiunii
                    connection.Open();

                    // Crearea obiectului pentru comanda SQL
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    // Parametrii pentru valorile actualizate
                    command.Parameters.AddWithValue("@Nume", nume);
                    command.Parameters.AddWithValue("@Prenume", prenume);
                    command.Parameters.AddWithValue("@Data_Nasterii", dataNasterii);
                    command.Parameters.AddWithValue("@Data_Angajarii", dataAngajarii);
                    command.Parameters.AddWithValue("@Salariu", salariu);
                    command.Parameters.AddWithValue("@Adresa", adresa);
                    command.Parameters.AddWithValue("@Telefon", telefon);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@ID_Filiala", idFiliala);
                    command.Parameters.AddWithValue("@ID_Angajat", idAngajat);

                    // Executăm comanda SQL pentru actualizare
                    command.ExecuteNonQuery();

                    // Închidem conexiunea
                    connection.Close();
                }

                // Afișăm un mesaj pentru utilizator pentru a confirma succesul actualizării
                MessageBox.Show("Datele angajatului au fost actualizate cu succes.");

                // Resetați controalele pentru inserare și ComboBox-ul pentru a deselecta orice element selectat
                ClearInsertControls();
                comboBoxFiliale.SelectedIndex = -1;

                // Refacem interogarea pentru a afișa datele actualizate în DataGridView
                select_btn_Click(sender, e);
            }
            else
            {
                // Dacă nu a fost selectat niciun angajat în DataGridView, afișăm un mesaj corespunzător
                MessageBox.Show("Vă rugăm să selectați un angajat din lista afișată pentru a actualiza datele.");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            // Verificăm dacă a fost selectat un rând în DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obținem id-ul angajatului selectat
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int idAngajat = Convert.ToInt32(row.Cells["ID_Angajat"].Value);

                // Construim comanda SQL pentru ștergerea angajatului din baza de date
                string deleteQuery = "DELETE FROM Angajati WHERE ID_Angajat = @ID_Angajat";

                // Deschidem conexiunea către baza de date și executăm comanda
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        // Adăugăm parametrul pentru id-ul angajatului
                        command.Parameters.AddWithValue("@ID_Angajat", idAngajat);

                        // Deschidem conexiunea și executăm comanda
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        // Verificăm dacă ștergerea s-a efectuat cu succes
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Angajatul a fost șters cu succes din baza de date.");
                        }
                        else
                        {
                            MessageBox.Show("Ștergerea angajatului a eșuat. Vă rugăm să încercați din nou.");
                        }
                    }
                }

                // După ștergere, reîncărcăm datele în DataGridView pentru a reflecta modificările
                select_btn_Click(sender, e);

                // Golesc controalele de inserare și deselectez orice element selectat în DataGridView
                ClearInsertControls();
                dataGridView1.ClearSelection();
            }
            else
            {
                // Dacă nu a fost selectat niciun angajat în DataGridView, afișăm un mesaj corespunzător
                MessageBox.Show("Vă rugăm să selectați un angajat din lista afișată pentru a-l șterge.");
            }
        }

    }
}

