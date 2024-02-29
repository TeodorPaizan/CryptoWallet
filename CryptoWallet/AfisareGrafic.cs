using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class AfisareGrafic : Form
    {
        List<Actiune> listaActiuni;

        const int margine = 10;
        Color culoareBars = Color.Green;
        Font fontText = new Font(FontFamily.GenericSerif, 12, FontStyle.Bold);
        Color culoareText = Color.Black;

        bool dateIncarcare = false;
        public AfisareGrafic()
        {
            InitializeComponent();
            listaActiuni = new List<Actiune>();
        }


        private void IncarcaDate()
        {
            listaActiuni.Clear();

            using (SqlConnection connection = new SqlConnection("Data Source = (localdb)\\ProjectModels; Initial Catalog = Proiect; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                string query = "SELECT DenumireActiune, Pret, Cantitate FROM Actiuni";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Actiune actiune = new Actiune();
                        actiune.Denumire = reader["DenumireActiune"].ToString();
                        actiune.PretUnitar = (double)reader["Pret"];
                        actiune.Cantitate = (double)reader["Cantitate"];

                        listaActiuni.Add(actiune);
                    }

                    reader.Close();
                }
            }
        }


        private void incarcaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncarcaDate();
            dateIncarcare = true;
            MessageBox.Show("Date incarcate");
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            chart1.Visible = false;
            if (dateIncarcare)
            {
                Graphics g = e.Graphics;
                Rectangle rectangle = new Rectangle(panel1.ClientRectangle.X + margine, panel1.ClientRectangle.Y + 4 * margine,
                    panel1.ClientRectangle.Width - 2 * margine, panel1.ClientRectangle.Height - 5 * margine);
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rectangle);

                double latime = rectangle.Width / listaActiuni.Count / 3;
                double distanta = (rectangle.Width - listaActiuni.Count * latime) / (listaActiuni.Count + 1);
                double vMax = listaActiuni.Max(max => max.CalculValoare());

                Brush brBars = new SolidBrush(culoareBars);
                Brush brFont = new SolidBrush(culoareText);

                Rectangle[] rectangles = new Rectangle[listaActiuni.Count];
                for (int i = 0; i < rectangles.Length; i++)
                {
                    rectangles[i] = new Rectangle((int)(rectangle.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rectangle.Location.Y + rectangle.Height - listaActiuni[i].CalculValoare() / vMax * rectangle.Height),
                        (int)latime,
                        (int)(listaActiuni[i].CalculValoare() / vMax * rectangle.Height));

                    g.DrawString(listaActiuni[i].returnStringValoare(), fontText, brFont, new Point((int)(rectangles[i].Location.X),
                        (int)(rectangles[i].Location.Y - fontText.Height)));
                }
                g.FillRectangles(brBars, rectangles);

                for (int i = 0; i < listaActiuni.Count - 1; i++)
                {
                    g.DrawLine(pen, new Point((int)(rectangles[i].Location.X + rectangles[i].Width / 2), (int)(rectangles[i].Location.Y)),
                         new Point((int)(rectangles[i + 1].Location.X + rectangles[i + 1].Width / 2), (int)(rectangles[i + 1].Location.Y)));

                }
            }
        }

        private void graficDesenatBarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dateIncarcare)
            {
                chart1.Visible = false;
                panel1.Invalidate();
            }
            else
            {
                MessageBox.Show("Datele nu au fost incarcate");
            }
        }

        private void graficBarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dateIncarcare == true)
            {
                chart1.Series["Valoare Actiuni"].Points.Clear();
                chart1.Titles.Clear();
                chart1.Visible = true;
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                for (int i = 0; i < listaActiuni.Count; i++)
                {
                    chart1.Series["Valoare Actiuni"].Points.AddXY(listaActiuni[i].Denumire, listaActiuni[i].returnStringValoare());
                }
                chart1.Titles.Add("Pondere actiuni portofoliu");
            }
            else
            {
                MessageBox.Show("Datele nu au fost incarcate");
            }
        }

        private void graficPieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dateIncarcare == true)
            {
                chart1.Series["Valoare Actiuni"].Points.Clear();
                chart1.Titles.Clear();
                chart1.Visible = true;
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                for (int i = 0; i < listaActiuni.Count; i++)
                {
                    chart1.Series["Valoare Actiuni"].Points.AddXY(listaActiuni[i].Denumire, listaActiuni[i].returnStringValoare());
                }
                chart1.Titles.Add("Pondere actiuni portofoliu");
            }
            else
            {
                MessageBox.Show("Datele nu au fost incarcate");
            }
        }

        private void salvareBMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvare_bmp(panel1, "Grafic_" + DateTime.Now.ToString("dd-MM-yyyy") + ".bmp");
            MessageBox.Show("S-a salvat imaginea!");
        }

        private void salvare_bmp(Control c, string nume_fisier)
        {
            Bitmap img = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(img, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y,
                c.ClientRectangle.Width, c.ClientRectangle.Height));
            img.Save(nume_fisier);
            img.Dispose();
        }

        private void barsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                culoareBars = cd.Color;
            }
            panel1.Invalidate();
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                culoareText = cd.Color;
            }
            panel1.Invalidate();
        }

        private void modificareFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fontText = fd.Font;
            }
            panel1.Invalidate();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pp);
            PrintPreviewDialog pdlg = new PrintPreviewDialog
            {
                Document = pd
            };
            pdlg.ShowDialog();
        }

        private void pp(object sender, PrintPageEventArgs e)
        {
            if (dateIncarcare)
            {
                Graphics g = e.Graphics;
                Rectangle rectangle = new Rectangle(e.PageBounds.X + margine, e.PageBounds.Y + 4 * margine,
                    e.PageBounds.Width - 2 * margine, e.PageBounds.Height - 5 * margine);
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rectangle);

                double latime = rectangle.Width / listaActiuni.Count / 3;
                double distanta = (rectangle.Width - listaActiuni.Count * latime) / (listaActiuni.Count + 1);
                double vMax = listaActiuni.Max(max => max.CalculValoare());

                Brush brBars = new SolidBrush(culoareBars);
                Brush brFont = new SolidBrush(culoareText);

                Rectangle[] rectangles = new Rectangle[listaActiuni.Count];
                for (int i = 0; i < rectangles.Length; i++)
                {
                    rectangles[i] = new Rectangle((int)(rectangle.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rectangle.Location.Y + rectangle.Height - listaActiuni[i].CalculValoare() / vMax * rectangle.Height),
                        (int)latime,
                        (int)(listaActiuni[i].CalculValoare() / vMax * rectangle.Height));

                    g.DrawString(listaActiuni[i].returnStringValoare(), fontText, brFont, new Point((int)(rectangles[i].Location.X),
                        (int)(rectangles[i].Location.Y - fontText.Height)));
                }
                g.FillRectangles(brBars, rectangles);

                for (int i = 0; i < listaActiuni.Count - 1; i++)
                {
                    g.DrawLine(pen, new Point((int)(rectangles[i].Location.X + latime / 2), (int)(rectangles[i].Location.Y)),
                        new Point((int)(rectangles[i + 1].Location.X + latime / 2), (int)(rectangles[i + 1].Location.Y)));
                }
            }
        }
    }
}
