namespace Proiect
{
    partial class AfisareGrafic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareGraficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficPieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficDesenatBarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficBarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareBMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareCuloareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.modificareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incarcaDateToolStripMenuItem,
            this.afisareGraficToolStripMenuItem,
            this.salvareBMPToolStripMenuItem,
            this.printPreviewToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // incarcaDateToolStripMenuItem
            // 
            this.incarcaDateToolStripMenuItem.Name = "incarcaDateToolStripMenuItem";
            this.incarcaDateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.incarcaDateToolStripMenuItem.Text = "Incarca date";
            this.incarcaDateToolStripMenuItem.Click += new System.EventHandler(this.incarcaDateToolStripMenuItem_Click);
            // 
            // afisareGraficToolStripMenuItem
            // 
            this.afisareGraficToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficPieToolStripMenuItem,
            this.graficDesenatBarsToolStripMenuItem,
            this.graficBarsToolStripMenuItem});
            this.afisareGraficToolStripMenuItem.Name = "afisareGraficToolStripMenuItem";
            this.afisareGraficToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.afisareGraficToolStripMenuItem.Text = "Afisare Grafic";
            // 
            // graficPieToolStripMenuItem
            // 
            this.graficPieToolStripMenuItem.Name = "graficPieToolStripMenuItem";
            this.graficPieToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.graficPieToolStripMenuItem.Text = "Grafic pie";
            this.graficPieToolStripMenuItem.Click += new System.EventHandler(this.graficPieToolStripMenuItem_Click);
            // 
            // graficDesenatBarsToolStripMenuItem
            // 
            this.graficDesenatBarsToolStripMenuItem.Name = "graficDesenatBarsToolStripMenuItem";
            this.graficDesenatBarsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.graficDesenatBarsToolStripMenuItem.Text = "Grafic desenat bars";
            this.graficDesenatBarsToolStripMenuItem.Click += new System.EventHandler(this.graficDesenatBarsToolStripMenuItem_Click);
            // 
            // graficBarsToolStripMenuItem
            // 
            this.graficBarsToolStripMenuItem.Name = "graficBarsToolStripMenuItem";
            this.graficBarsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.graficBarsToolStripMenuItem.Text = "Grafic bars";
            this.graficBarsToolStripMenuItem.Click += new System.EventHandler(this.graficBarsToolStripMenuItem_Click);
            // 
            // salvareBMPToolStripMenuItem
            // 
            this.salvareBMPToolStripMenuItem.Name = "salvareBMPToolStripMenuItem";
            this.salvareBMPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvareBMPToolStripMenuItem.Text = "Salvare BMP";
            this.salvareBMPToolStripMenuItem.Click += new System.EventHandler(this.salvareBMPToolStripMenuItem_Click);
            // 
            // modificareToolStripMenuItem
            // 
            this.modificareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificareCuloareToolStripMenuItem,
            this.modificareFontToolStripMenuItem});
            this.modificareToolStripMenuItem.Name = "modificareToolStripMenuItem";
            this.modificareToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.modificareToolStripMenuItem.Text = "Modificare";
            // 
            // modificareCuloareToolStripMenuItem
            // 
            this.modificareCuloareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barsToolStripMenuItem,
            this.textToolStripMenuItem});
            this.modificareCuloareToolStripMenuItem.Name = "modificareCuloareToolStripMenuItem";
            this.modificareCuloareToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.modificareCuloareToolStripMenuItem.Text = "Modificare culoare";
            // 
            // barsToolStripMenuItem
            // 
            this.barsToolStripMenuItem.Name = "barsToolStripMenuItem";
            this.barsToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.barsToolStripMenuItem.Text = "Bars";
            this.barsToolStripMenuItem.Click += new System.EventHandler(this.barsToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // modificareFontToolStripMenuItem
            // 
            this.modificareFontToolStripMenuItem.Name = "modificareFontToolStripMenuItem";
            this.modificareFontToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.modificareFontToolStripMenuItem.Text = "Modificare font";
            this.modificareFontToolStripMenuItem.Click += new System.EventHandler(this.modificareFontToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 426);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Valoare Actiuni";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(797, 423);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // AfisareGrafic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AfisareGrafic";
            this.Text = "AfisareGrafic";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareGraficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficPieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficDesenatBarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficBarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareBMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareCuloareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareFontToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
    }
}