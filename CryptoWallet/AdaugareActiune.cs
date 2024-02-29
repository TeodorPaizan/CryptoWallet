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

namespace Proiect
{
    public partial class AdaugareActiune : Form
    {
        public AdaugareActiune()
        {
            InitializeComponent();
        }

        private void btAdauga_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=Proiect;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                conexiune.Open();

                string denumire = tbDenumireA.Text.Trim();
                double pret = Convert.ToDouble(tbPretA.Text);
                double cantitate = Convert.ToDouble(tbCantitateA.Text);


                // Verificăm dacă există deja o acțiune cu aceeași denumire
                SqlCommand verificaExistenta = new SqlCommand("SELECT COUNT(*) FROM Actiuni WHERE DenumireActiune = @denumire", conexiune);
                verificaExistenta.Parameters.AddWithValue("@denumire", denumire);

                int count = (int)verificaExistenta.ExecuteScalar();

                if (count > 0)
                {
                    // Dacă există deja o acțiune cu aceeași denumire, actualizăm cantitatea și pretul

                    // Obținem cantitatea și pretul existente pentru acțiunea respectivă
                    SqlCommand select = new SqlCommand("SELECT Pret, Cantitate FROM Actiuni WHERE DenumireActiune = @denumire", conexiune);
                    select.Parameters.AddWithValue("@denumire", denumire);

                    SqlDataReader reader = select.ExecuteReader();

                    if (reader.Read())
                    {
                        double pretActual = Convert.ToDouble(reader["Pret"]);
                        double cantitateActuala = Convert.ToDouble(reader["Cantitate"]);

                        // Calculăm media ponderată a prețurilor pentru a obține noul preț
                        double pretNou = (pretActual * cantitateActuala + pret * cantitate) / (cantitateActuala + cantitate);

                        // Actualizăm cantitatea și prețul pentru acțiunea existentă
                        SqlCommand update = new SqlCommand("UPDATE Actiuni SET Cantitate = @cantitate, Pret = @pret WHERE DenumireActiune = @denumire", conexiune);
                        update.Parameters.AddWithValue("@cantitate", cantitateActuala + cantitate);
                        update.Parameters.AddWithValue("@pret", pretNou);
                        update.Parameters.AddWithValue("@denumire", denumire);

                        reader.Close();

                        update.ExecuteNonQuery();
                    }
                }
                else
                {
                    // Dacă nu există deja o acțiune cu aceeași denumire, inserăm acțiunea în baza de date
                    SqlCommand inserare = new SqlCommand("INSERT INTO Actiuni (DenumireActiune, Pret, Cantitate) VALUES (@denumire, @pret, @cantitate)", conexiune);
                    inserare.Parameters.AddWithValue("@denumire", denumire);
                    inserare.Parameters.AddWithValue("@pret", pret);
                    inserare.Parameters.AddWithValue("@cantitate", cantitate);

                    inserare.ExecuteNonQuery();
                }

                tbCantitateA.Clear();
                tbDenumireA.Clear();
                tbPretA.Clear();

                MessageBox.Show("Acțiunea a fost adăugată în baza de date.");
                conexiune.Close();
            }
        }

    }
}
