namespace Proiect
{
    partial class AdaugareActiune
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbDenumireA = new System.Windows.Forms.TextBox();
            this.tbCantitateA = new System.Windows.Forms.TextBox();
            this.tbPretA = new System.Windows.Forms.TextBox();
            this.btAdauga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denumire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantitate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pret";
            // 
            // tbDenumireA
            // 
            this.tbDenumireA.Location = new System.Drawing.Point(198, 30);
            this.tbDenumireA.Name = "tbDenumireA";
            this.tbDenumireA.Size = new System.Drawing.Size(136, 20);
            this.tbDenumireA.TabIndex = 3;
            // 
            // tbCantitateA
            // 
            this.tbCantitateA.Location = new System.Drawing.Point(198, 117);
            this.tbCantitateA.Name = "tbCantitateA";
            this.tbCantitateA.Size = new System.Drawing.Size(136, 20);
            this.tbCantitateA.TabIndex = 4;
            // 
            // tbPretA
            // 
            this.tbPretA.Location = new System.Drawing.Point(198, 74);
            this.tbPretA.Name = "tbPretA";
            this.tbPretA.Size = new System.Drawing.Size(136, 20);
            this.tbPretA.TabIndex = 5;
            // 
            // btAdauga
            // 
            this.btAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdauga.Location = new System.Drawing.Point(219, 161);
            this.btAdauga.Name = "btAdauga";
            this.btAdauga.Size = new System.Drawing.Size(95, 26);
            this.btAdauga.TabIndex = 6;
            this.btAdauga.Text = "Adauga ";
            this.btAdauga.UseVisualStyleBackColor = true;
            this.btAdauga.Click += new System.EventHandler(this.btAdauga_Click);
            // 
            // AdaugareActiune
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect.Properties.Resources.investment_1920_x_1080_picture_5hwafvfxw4zba2ac;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(411, 221);
            this.Controls.Add(this.btAdauga);
            this.Controls.Add(this.tbPretA);
            this.Controls.Add(this.tbCantitateA);
            this.Controls.Add(this.tbDenumireA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugareActiune";
            this.Text = "AdaugareActiune";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDenumireA;
        private System.Windows.Forms.TextBox tbCantitateA;
        private System.Windows.Forms.TextBox tbPretA;
        private System.Windows.Forms.Button btAdauga;
    }
}