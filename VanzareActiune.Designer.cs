namespace Proiect
{
    partial class VanzareActiune
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPretV = new System.Windows.Forms.TextBox();
            this.btVinde = new System.Windows.Forms.Button();
            this.cbSelectareActiuni = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectare actiune";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pret vanzare";
            // 
            // tbPretV
            // 
            this.tbPretV.Location = new System.Drawing.Point(199, 85);
            this.tbPretV.Name = "tbPretV";
            this.tbPretV.Size = new System.Drawing.Size(178, 20);
            this.tbPretV.TabIndex = 4;
            // 
            // btVinde
            // 
            this.btVinde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVinde.Location = new System.Drawing.Point(199, 131);
            this.btVinde.Name = "btVinde";
            this.btVinde.Size = new System.Drawing.Size(178, 23);
            this.btVinde.TabIndex = 6;
            this.btVinde.Text = "Vinde";
            this.btVinde.UseVisualStyleBackColor = true;
            this.btVinde.Click += new System.EventHandler(this.btVinde_Click);
            // 
            // cbSelectareActiuni
            // 
            this.cbSelectareActiuni.FormattingEnabled = true;
            this.cbSelectareActiuni.Location = new System.Drawing.Point(199, 35);
            this.cbSelectareActiuni.Name = "cbSelectareActiuni";
            this.cbSelectareActiuni.Size = new System.Drawing.Size(178, 21);
            this.cbSelectareActiuni.TabIndex = 8;
            // 
            // VanzareActiune
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect.Properties.Resources.investment_1920_x_1080_picture_5hwafvfxw4zba2ac;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(427, 190);
            this.Controls.Add(this.cbSelectareActiuni);
            this.Controls.Add(this.btVinde);
            this.Controls.Add(this.tbPretV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VanzareActiune";
            this.Text = "VanzareActiune";
            this.Load += new System.EventHandler(this.VanzareActiune_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPretV;
        private System.Windows.Forms.Button btVinde;
        private System.Windows.Forms.ComboBox cbSelectareActiuni;
    }
}