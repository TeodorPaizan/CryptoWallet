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
    public partial class ContNou : Form
    {
        public ContNou()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string utilizator = tbUtilizatorNou.Text;
            string parola = tbParolaNoua.Text;

            using(SqlConnection conexiune  = new SqlConnection("Data Source = (localdb)\\ProjectModels; Initial Catalog = Proiect; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                try
                {
                    conexiune.Open();
                    string interogare = "Insert into LogIn (UserName, Password) values (@UserName, @Password)";
                    SqlCommand cmd = new SqlCommand(interogare, conexiune);
                    cmd.Parameters.AddWithValue("@UserName", utilizator);
                    cmd.Parameters.AddWithValue("@Password", parola);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contul a fost adăugat cu succes în baza de date!");
                    conexiune.Close();
                } catch(Exception ex)
                {
                    MessageBox.Show("Nu s-a putut adauga contul in baza de date" + ex.Message);
                }
            }
            this.Close();
        }
    }
}
