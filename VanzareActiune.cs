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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect
{
    public partial class VanzareActiune : Form
    {
        public VanzareActiune()
        {
            InitializeComponent();
            LoadActiuni();
        }

        private void LoadActiuni()
        {
            string interogare = "SELECT DenumireActiune FROM Actiuni";

            using (SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=Proiect;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                conexiune.Open();
                SqlCommand command = new SqlCommand(interogare, conexiune);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string denumire = (string)reader["DenumireActiune"];
                    cbSelectareActiuni.Items.Add(denumire);
                }

                reader.Close();
                conexiune.Close();
            }
        }

        private void btVinde_Click(object sender, EventArgs e)
        {
            string denumireActiune = cbSelectareActiuni.SelectedItem.ToString();
            double pretVanzare = Convert.ToDouble(tbPretV.Text);

            string interogareStergere = "DELETE FROM Actiuni WHERE DenumireActiune = @DenumireActiune";
            string interogareAdaugare = "INSERT INTO ActiuniVandute (Id, Denumire, Pret) VALUES (@Id, @DenumireActiune, @PretVanzare)";
            string interogareMaxId = "SELECT MAX(Id) FROM ActiuniVandute";
            int ultimulId = 0;

            using (SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=Proiect;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                conexiune.Open();

                SqlCommand commandMaxId = new SqlCommand(interogareMaxId, conexiune);
                object rezultat = commandMaxId.ExecuteScalar();
                if (rezultat != null && rezultat != DBNull.Value)
                {
                    ultimulId = Convert.ToInt32(rezultat);
                }

                conexiune.Close();
            }

            // Incrementarea ID-ului cu 1 pentru a obține noul ID
            int noulId = ultimulId + 1;

            using (SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=Proiect;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                conexiune.Open();

                // Șterge acțiunea din tabela "Actiuni"
                SqlCommand commandStergere = new SqlCommand(interogareStergere, conexiune);
                commandStergere.Parameters.AddWithValue("@DenumireActiune", denumireActiune);
                commandStergere.ExecuteNonQuery();

                // Adaugă acțiunea în tabela "ActiuniVandute"
                SqlCommand commandAdaugare = new SqlCommand(interogareAdaugare, conexiune);
                commandAdaugare.Parameters.AddWithValue("@Id", noulId);
                commandAdaugare.Parameters.AddWithValue("@DenumireActiune", denumireActiune);
                commandAdaugare.Parameters.AddWithValue("@PretVanzare", pretVanzare);
                commandAdaugare.ExecuteNonQuery();

                conexiune.Close();

                tbPretV.Clear();
                cbSelectareActiuni.DataSource = null;
                cbSelectareActiuni.Items.Clear();
                LoadActiuni(); // Încarcă din nou acțiunile în ComboBox
            }
        }


        private void VanzareActiune_Load(object sender, EventArgs e)
        {

        }
    }
}
