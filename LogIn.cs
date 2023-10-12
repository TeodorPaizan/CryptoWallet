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
    public partial class LogIn : Form
    {
        SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=Proiect;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public LogIn()
        {
            InitializeComponent();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            string utilizator = tbUserName.Text;
            string parola = tbPassword.Text;

            // Verificarea utilizatorului și parolei în baza de date
            if (Autentificare(utilizator, parola))
            {
                new Meniu().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Autentificare eșuată. Vă rugăm să verificați utilizatorul și parola.");
            }
        }

        private bool Autentificare(string utilizator, string parola)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=Proiect;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM LogIn WHERE UserName = @Utilizator AND Password = @Parola";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Utilizator", utilizator);
                    command.Parameters.AddWithValue("@Parola", parola);
                    int numarUtilizatori = (int)command.ExecuteScalar();
                    connection.Close();
                    return numarUtilizatori > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare la autentificare: " + ex.Message);
                    return false;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContNou contNou = new ContNou();
            contNou.Show();
        }
    }
}
