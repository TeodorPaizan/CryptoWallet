using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect
{
    public partial class Meniu : Form
    {
        List<Actiune> listaActiuni;
        public Meniu()
        {
            InitializeComponent();
            listaActiuni = new List<Actiune>();
        }

        private void Meniu_Load(object sender, EventArgs e)
        {
            lvDateActiuni.MouseClick += lvDateActiuni_MouseClick;
        }

        private void lvDateActiuni_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem clickedItem = lvDateActiuni.GetItemAt(e.X, e.Y);
            if (clickedItem != null)
            {
                tbDenumire.Text = clickedItem.Text;
            }
        }

        private void btIesire_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn logIn = Application.OpenForms["LogIn"] as LogIn;
            logIn.Close();
        }

        private void btArataPortofoliu_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=Proiect;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DenumireActiune, Pret, Cantitate FROM Actiuni";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    lvDateActiuni.Items.Clear();
                    while (reader.Read())
                    {
                        string denumire = reader["DenumireActiune"].ToString();
                        double pret = Convert.ToDouble(reader["Pret"]);
                        double cantitate = Convert.ToDouble(reader["Cantitate"]);
                        double valoare = pret * cantitate;

                        Actiune actiune = new Actiune(denumire, pret,cantitate);
                        listaActiuni.Add(actiune);

                        ListViewItem item = new ListViewItem(denumire);
                        item.SubItems.Add(pret.ToString());
                        item.SubItems.Add(cantitate.ToString());
                        item.SubItems.Add(valoare.ToString());
                        lvDateActiuni.Items.Add(item);
                    }
                    connection.Close();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu se pot prelua datele din baza de date!" + ex.Message);
                   
                }
            }
        }

        private void btValoarePortofoliu_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=Proiect;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Pret, Cantitate FROM Actiuni";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    double valoare = 0;

                    while (reader.Read())
                    {
                        double pret = Convert.ToDouble(reader["Pret"]);
                        double cantitate = Convert.ToDouble(reader["Cantitate"]);
                        valoare = valoare + pret * cantitate;
                    }
                    MessageBox.Show("Valoarea portofoliului este de: " + valoare);
                    connection.Close();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu se pot prelua datele din baza de date!" + ex.Message);

                }
            }
        }

        private void btAdaugaActiune_Click(object sender, EventArgs e)
        {
            AdaugareActiune adaugareActiune = new AdaugareActiune();
            adaugareActiune.Show();
        }

        private void btVindeActiune_Click(object sender, EventArgs e)
        {
            VanzareActiune vanzareActiune = new VanzareActiune();
            vanzareActiune.Show();
        }

        private void tXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvareDateInTxt();
        }

        private void SalvareDateInTxt()
        {
            string interogare = "SELECT DenumireActiune, Pret, Cantitate FROM Actiuni";

            using (SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=Proiect;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                conexiune.Open();
                SqlCommand command = new SqlCommand(interogare, conexiune);
                SqlDataReader reader = command.ExecuteReader();

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Fișier text (*.txt)|*.txt";
                    saveFileDialog.Title = "Salvare date în fișier text";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string numeFisier = saveFileDialog.FileName;

                        using (StreamWriter sw = new StreamWriter(numeFisier))
                        {
                            while (reader.Read())
                            {
                                string denumire = reader["DenumireActiune"].ToString();
                                double pret = Convert.ToDouble(reader["Pret"]);
                                double cantitate = Convert.ToDouble(reader["Cantitate"]);

                                string linie = $"{denumire},{pret},{cantitate}";
                                sw.WriteLine(linie);
                            }
                        }

                        MessageBox.Show("Datele au fost salvate cu succes în fișierul text!");
                    }
                }

                reader.Close();
                conexiune.Close();
            }
        }

        private void tXTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeschidereFisierTxt();
        }
        private void DeschidereFisierTxt()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Fișier text (*.txt)|*.txt";
                openFileDialog.Title = "Deschidere fișier text";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string numeFisier = openFileDialog.FileName;

                    // Golirea ListView-ului înainte de încărcarea datelor noi
                    lvDateActiuni.Items.Clear();

                    using (StreamReader sr = new StreamReader(numeFisier))
                    {
                        string linie;
                        while ((linie = sr.ReadLine()) != null)
                        {
                            string[] elemente = linie.Split(',');
                            if (elemente.Length >= 3)
                            {
                                string denumire = elemente[0];
                                double pret = Convert.ToDouble(elemente[1]);
                                double cantitate = Convert.ToDouble(elemente[2]);
                                double valoare = pret * cantitate;

                                ListViewItem item = new ListViewItem(denumire);
                                item.SubItems.Add(pret.ToString());
                                item.SubItems.Add(cantitate.ToString());
                                item.SubItems.Add(valoare.ToString());
                                lvDateActiuni.Items.Add(item);
                            }
                        }
                    }

                    MessageBox.Show("Fișierul a fost deschis cu succes și datele au fost încărcate în ListView!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfisareGrafic afisareGrafic = new AfisareGrafic();
            afisareGrafic.Show();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crearea unui obiect XmlDocument
            XmlDocument xmlDoc = new XmlDocument();

            // Crearea elementului radacină
            XmlElement rootElement = xmlDoc.CreateElement("Actiuni");
            xmlDoc.AppendChild(rootElement);

            // Conectarea la baza de date
            using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=Proiect;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DenumireActiune, Pret, Cantitate FROM Actiuni";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Iterarea prin înregistrările din baza de date
                    while (reader.Read())
                    {
                        // Crearea unui element pentru fiecare înregistrare
                        XmlElement actiuneElement = xmlDoc.CreateElement("Actiune");
                        rootElement.AppendChild(actiuneElement);

                        // Adăugarea atributelor pentru denumire, pret și cantitate
                        XmlAttribute denumireAttribute = xmlDoc.CreateAttribute("Denumire");
                        denumireAttribute.Value = reader["DenumireActiune"].ToString();
                        actiuneElement.Attributes.Append(denumireAttribute);

                        XmlAttribute pretAttribute = xmlDoc.CreateAttribute("Pret");
                        pretAttribute.Value = reader["Pret"].ToString();
                        actiuneElement.Attributes.Append(pretAttribute);

                        XmlAttribute cantitateAttribute = xmlDoc.CreateAttribute("Cantitate");
                        cantitateAttribute.Value = reader["Cantitate"].ToString();
                        actiuneElement.Attributes.Append(cantitateAttribute);
                    }

                    connection.Close();
                    reader.Close();

                    // Salvarea documentului XML într-un fișier
                    xmlDoc.Save("actiuni.xml");

                    MessageBox.Show("Datele au fost salvate cu succes în fișierul XML!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu se pot prelua datele din baza de date! " + ex.Message);
                }
            }
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Verificarea existenței fișierului XML
            if (File.Exists("actiuni.xml"))
            {
                // Crearea unui nou XmlDocument
                XmlDocument xmlDoc = new XmlDocument();

                try
                {
                    // Încărcarea fișierului XML
                    xmlDoc.Load("actiuni.xml");

                    // Golirea ListView-ului înainte de încărcarea datelor noi
                    lvDateActiuni.Items.Clear();

                    // Obținerea elementului radacină
                    XmlNode rootElement = xmlDoc.DocumentElement;

                    // Iterarea prin elementele "Actiune"
                    foreach (XmlNode actiuneNode in rootElement.ChildNodes)
                    {
                        if (actiuneNode is XmlElement actiuneElement)
                        {
                            string denumire = actiuneElement.GetAttribute("Denumire");
                            double pret = Convert.ToDouble(actiuneElement.GetAttribute("Pret"));
                            double cantitate = Convert.ToDouble(actiuneElement.GetAttribute("Cantitate"));
                            double valoare = pret * cantitate;

                            ListViewItem item = new ListViewItem(denumire);
                            item.SubItems.Add(pret.ToString());
                            item.SubItems.Add(cantitate.ToString());
                            item.SubItems.Add(valoare.ToString());
                            lvDateActiuni.Items.Add(item);
                        }
                    }

                    MessageBox.Show("Datele au fost restaurate cu succes din fișierul XML!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la restaurarea datelor din fișierul XML! " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Fișierul XML nu există!");
            }
        }
    }
}
