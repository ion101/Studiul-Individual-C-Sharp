using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_ENTER
{
    public partial class Products : UserControl
    {
        private string connectionString = "Data Source = DESKTOP-1JARFUU; Initial Catalog = ENTER; Integrated Security = True";

        public Products()
        {
            InitializeComponent();
        }

        private void ClearInsertControls()
        {
            // Resetați valorile din controalele de inserare pentru a pregăti pentru un nou produs
            txtIDProdus.Text = "";
            txtDenumire.Text = "";
            txtDescriere.Text = "";
            txtPret.Text = "";
            comboBoxCategoria.SelectedIndex = -1;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            // Extrageți valorile introduse de utilizator din controalele TextBox și ComboBox
            string id = txtIDProdus.Text;
            string denumire = txtDenumire.Text;
            string descriere = txtDescriere.Text;
            decimal pret = Convert.ToDecimal(txtPret.Text);
            string categorieId = comboBoxCategoria.SelectedItem.ToString();

            // Construiți comanda SQL pentru inserarea unui nou produs
            string query = @"INSERT INTO Produse (ID_Produs, Denumire, Descriere_Produs, Pret, Categoria)
                     VALUES (@IDProdus, @Denumire, @Descriere, @Pret, @Categoria)";

            // Conexiunea către baza de date
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Deschideți conexiunea
                connection.Open();

                // Creați un obiect SqlCommand și setați proprietatea CommandText cu comanda SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Adăugați parametrii necesari la comandă
                    command.Parameters.AddWithValue("@IDProdus", id);
                    command.Parameters.AddWithValue("@Denumire", denumire);
                    command.Parameters.AddWithValue("@Descriere", descriere);
                    command.Parameters.AddWithValue("@Pret", pret);
                    command.Parameters.AddWithValue("@Categoria", categorieId);

                    // Executați comanda pentru a insera produsul în baza de date
                    int rowsAffected = command.ExecuteNonQuery();

                    // Verificați dacă inserarea s-a efectuat cu succes
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Produsul a fost adăugat cu succes în baza de date.");
                    }
                    else
                    {
                        MessageBox.Show("Inserarea produsului a eșuat. Vă rugăm să verificați datele introduse.");
                    }
                }
            }

            // Resetați valorile controalelor de inserare pentru a pregăti pentru un nou produs
            ClearInsertControls();
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            // Conexiunea către baza de date
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Comanda SQL pentru selectarea tuturor produselor
                string query = "SELECT Produse.ID_Produs, Produse.Denumire, Produse.Descriere_Produs, Produse.Pret, Categorii.Denumire AS Categorie FROM Produse JOIN Categorii ON Produse.Categoria = Categorii.ID_Categorie;";

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
                    dataGridViewProducts.DataSource = dataTable;
                }
                else
                {
                    // Dacă nu există rânduri, afișați un mesaj că nu s-au găsit produse
                    MessageBox.Show("Nu s-au găsit produse.");
                }

                // Închiderea obiectului pentru citirea rezultatelor
                reader.Close();
            }
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificăm dacă a fost selectată o celulă validă din coloana de ID_Produs
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obținem rândul care a fost selectat
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];

                // Extragem datele despre produsul selectat și le afișăm în controalele corespunzătoare
                txtIDProdus.Text = row.Cells["ID_Produs"].Value.ToString();
                txtDenumire.Text = row.Cells["Denumire"].Value.ToString();
                txtDescriere.Text = row.Cells["Descriere_Produs"].Value.ToString();
                txtPret.Text = row.Cells["Pret"].Value.ToString();
                comboBoxCategoria.SelectedItem = row.Cells["Categorie"].Value.ToString();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            // Verificăm dacă a fost selectat un produs în DataGridView
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                // Obținem rândul selectat
                DataGridViewRow row = dataGridViewProducts.SelectedRows[0];

                // Extragem ID-ul produsului selectat
                int idProdus;
                if (int.TryParse(row.Cells["ID_Produs"].Value.ToString(), out idProdus))
                {
                    // Extragem datele actualizate din controalele de mai sus
                    string denumire = txtDenumire.Text;
                    string descriere = txtDescriere.Text;
                    decimal pret = Convert.ToDecimal(txtPret.Text);

                    // Verificăm dacă a fost selectată o categorie în ComboBox
                    if (comboBoxCategoria.SelectedItem != null)
                    {
                        string categorieId = comboBoxCategoria.SelectedItem.ToString(); // Extragem direct valoarea selectată

                        // Construim comanda SQL pentru actualizarea datelor
                        string updateQuery = "UPDATE Produse SET Denumire=@Denumire, Descriere_Produs=@Descriere, Pret=@Pret, Categoria=@CategoriaId WHERE ID_Produs=@ID_Produs";

                        // Conexiunea către baza de date
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            // Deschiderea conexiunii
                            connection.Open();

                            // Crearea obiectului pentru comanda SQL
                            SqlCommand command = new SqlCommand(updateQuery, connection);

                            // Parametrii pentru valorile actualizate
                            command.Parameters.AddWithValue("@ID_Produs", idProdus);
                            command.Parameters.AddWithValue("@Denumire", denumire);
                            command.Parameters.AddWithValue("@Descriere", descriere);
                            command.Parameters.AddWithValue("@Pret", pret);
                            command.Parameters.AddWithValue("@CategoriaId", categorieId);

                            // Executăm comanda SQL pentru actualizare
                            int rowsAffected = command.ExecuteNonQuery();

                            // Verificăm dacă actualizarea s-a efectuat cu succes
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Datele produsului au fost actualizate cu succes.");
                            }
                            else
                            {
                                MessageBox.Show("Actualizarea datelor a eșuat. Vă rugăm să verificați datele introduse.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vă rugăm să selectați o categorie din lista afișată.");
                    }
                }
                else
                {
                    MessageBox.Show("Eroare la conversia ID-ului produsului.");
                }
            }
            else
            {
                // Dacă nu a fost selectat niciun produs în DataGridView, afișăm un mesaj corespunzător
                MessageBox.Show("Vă rugăm să selectați un produs din lista afișată pentru a actualiza datele.");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            // Verificăm dacă a fost selectat un rând în DataGridView
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                // Obținem rândul selectat
                DataGridViewRow selectedRow = dataGridViewProducts.SelectedRows[0];

                // Extragem ID-ul produsului selectat
                if (int.TryParse(selectedRow.Cells["ID_Produs"].Value.ToString(), out int idProdus))
                {
                    // Construim comanda SQL pentru ștergerea produsului din baza de date
                    string deleteQuery = "DELETE FROM Produse WHERE ID_Produs=@ID_Produs";

                    // Conexiunea către baza de date
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Deschiderea conexiunii
                        connection.Open();

                        // Crearea obiectului pentru comanda SQL
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            // Adăugăm parametrul pentru ID-ul produsului
                            command.Parameters.AddWithValue("@ID_Produs", idProdus);

                            // Executăm comanda SQL pentru ștergere
                            int rowsAffected = command.ExecuteNonQuery();

                            // Verificăm dacă ștergerea s-a efectuat cu succes
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Produsul a fost șters cu succes din baza de date.");
                            }
                            else
                            {
                                MessageBox.Show("Ștergerea produsului a eșuat. Vă rugăm să încercați din nou.");
                            }
                        }
                    }

                    // Golesc controalele pentru a pregăti pentru ștergerea altui produs
                    ClearInsertControls();

                    // Refacem interogarea pentru a actualiza DataGridView-ul
                    select_btn_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Eroare la conversia ID-ului produsului.");
                }
            }
            else
            {
                // Dacă nu a fost selectat niciun rând în DataGridView, afișăm un mesaj corespunzător
                MessageBox.Show("Vă rugăm să selectați un produs din lista afișată pentru a-l șterge.");
            }
        }


    }
}
