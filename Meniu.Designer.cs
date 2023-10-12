namespace Proiect
{
    partial class Meniu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareCaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschidereFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvDateActiuni = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btArataPortofoliu = new System.Windows.Forms.Button();
            this.btValoarePortofoliu = new System.Windows.Forms.Button();
            this.btAdaugaActiune = new System.Windows.Forms.Button();
            this.btVindeActiune = new System.Windows.Forms.Button();
            this.btIesire = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareCaToolStripMenuItem,
            this.deschidereFisierToolStripMenuItem,
            this.imprimareToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // salvareCaToolStripMenuItem
            // 
            this.salvareCaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tXTToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.salvareCaToolStripMenuItem.Name = "salvareCaToolStripMenuItem";
            this.salvareCaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvareCaToolStripMenuItem.Text = "Salvare ca";
            // 
            // tXTToolStripMenuItem
            // 
            this.tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.tXTToolStripMenuItem.Text = "TXT";
            this.tXTToolStripMenuItem.Click += new System.EventHandler(this.tXTToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // deschidereFisierToolStripMenuItem
            // 
            this.deschidereFisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tXTToolStripMenuItem1,
            this.xMLToolStripMenuItem1});
            this.deschidereFisierToolStripMenuItem.Name = "deschidereFisierToolStripMenuItem";
            this.deschidereFisierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deschidereFisierToolStripMenuItem.Text = "Deschidere fisier";
            // 
            // tXTToolStripMenuItem1
            // 
            this.tXTToolStripMenuItem1.Name = "tXTToolStripMenuItem1";
            this.tXTToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tXTToolStripMenuItem1.Text = "TXT";
            this.tXTToolStripMenuItem1.Click += new System.EventHandler(this.tXTToolStripMenuItem1_Click);
            // 
            // imprimareToolStripMenuItem
            // 
            this.imprimareToolStripMenuItem.Name = "imprimareToolStripMenuItem";
            this.imprimareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimareToolStripMenuItem.Text = "Imprimare";
            // 
            // lvDateActiuni
            // 
            this.lvDateActiuni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDateActiuni.HideSelection = false;
            this.lvDateActiuni.Location = new System.Drawing.Point(214, 53);
            this.lvDateActiuni.Name = "lvDateActiuni";
            this.lvDateActiuni.Size = new System.Drawing.Size(695, 319);
            this.lvDateActiuni.TabIndex = 2;
            this.lvDateActiuni.UseCompatibleStateImageBehavior = false;
            this.lvDateActiuni.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Denumire";
            this.columnHeader1.Width = 185;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pret";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 171;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cantitate";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 172;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Valoare";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 161;
            // 
            // btArataPortofoliu
            // 
            this.btArataPortofoliu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btArataPortofoliu.Location = new System.Drawing.Point(29, 97);
            this.btArataPortofoliu.Name = "btArataPortofoliu";
            this.btArataPortofoliu.Size = new System.Drawing.Size(154, 47);
            this.btArataPortofoliu.TabIndex = 3;
            this.btArataPortofoliu.Text = "Arata portofoliu";
            this.btArataPortofoliu.UseVisualStyleBackColor = true;
            this.btArataPortofoliu.Click += new System.EventHandler(this.btArataPortofoliu_Click);
            // 
            // btValoarePortofoliu
            // 
            this.btValoarePortofoliu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValoarePortofoliu.Location = new System.Drawing.Point(29, 172);
            this.btValoarePortofoliu.Name = "btValoarePortofoliu";
            this.btValoarePortofoliu.Size = new System.Drawing.Size(154, 51);
            this.btValoarePortofoliu.TabIndex = 4;
            this.btValoarePortofoliu.Text = "Valoare portofoliu";
            this.btValoarePortofoliu.UseVisualStyleBackColor = true;
            this.btValoarePortofoliu.Click += new System.EventHandler(this.btValoarePortofoliu_Click);
            // 
            // btAdaugaActiune
            // 
            this.btAdaugaActiune.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btAdaugaActiune.Location = new System.Drawing.Point(29, 250);
            this.btAdaugaActiune.Name = "btAdaugaActiune";
            this.btAdaugaActiune.Size = new System.Drawing.Size(154, 46);
            this.btAdaugaActiune.TabIndex = 5;
            this.btAdaugaActiune.Text = "Adauga actiune";
            this.btAdaugaActiune.UseVisualStyleBackColor = true;
            this.btAdaugaActiune.Click += new System.EventHandler(this.btAdaugaActiune_Click);
            // 
            // btVindeActiune
            // 
            this.btVindeActiune.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVindeActiune.Location = new System.Drawing.Point(29, 326);
            this.btVindeActiune.Name = "btVindeActiune";
            this.btVindeActiune.Size = new System.Drawing.Size(154, 46);
            this.btVindeActiune.TabIndex = 6;
            this.btVindeActiune.Text = "Vinde actiune";
            this.btVindeActiune.UseVisualStyleBackColor = true;
            this.btVindeActiune.Click += new System.EventHandler(this.btVindeActiune_Click);
            // 
            // btIesire
            // 
            this.btIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIesire.Location = new System.Drawing.Point(755, 401);
            this.btIesire.Name = "btIesire";
            this.btIesire.Size = new System.Drawing.Size(154, 46);
            this.btIesire.TabIndex = 7;
            this.btIesire.Text = "IESIRE";
            this.btIesire.UseVisualStyleBackColor = true;
            this.btIesire.Click += new System.EventHandler(this.btIesire_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generare grafic";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(12, 53);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(189, 20);
            this.tbDenumire.TabIndex = 9;
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.xMLToolStripMenuItem1.Text = "XML";
            this.xMLToolStripMenuItem1.Click += new System.EventHandler(this.xMLToolStripMenuItem1_Click);
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect.Properties.Resources.istockphoto_1292425551_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(921, 459);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btIesire);
            this.Controls.Add(this.btVindeActiune);
            this.Controls.Add(this.btAdaugaActiune);
            this.Controls.Add(this.btValoarePortofoliu);
            this.Controls.Add(this.btArataPortofoliu);
            this.Controls.Add(this.lvDateActiuni);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Meniu";
            this.Load += new System.EventHandler(this.Meniu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareCaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschidereFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imprimareToolStripMenuItem;
        private System.Windows.Forms.ListView lvDateActiuni;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btArataPortofoliu;
        private System.Windows.Forms.Button btValoarePortofoliu;
        private System.Windows.Forms.Button btAdaugaActiune;
        private System.Windows.Forms.Button btVindeActiune;
        private System.Windows.Forms.Button btIesire;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
    }
}