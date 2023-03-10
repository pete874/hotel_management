namespace hotel_management
{
    partial class KirjauduForm
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
            this.SalasanaLB = new System.Windows.Forms.Label();
            this.KayttajatunnusLB = new System.Windows.Forms.Label();
            this.KayttajatunnusTB = new System.Windows.Forms.TextBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.KirjauduBT = new System.Windows.Forms.Button();
            this.VirheviestiLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalasanaLB
            // 
            this.SalasanaLB.AutoSize = true;
            this.SalasanaLB.BackColor = System.Drawing.Color.Transparent;
            this.SalasanaLB.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaLB.Location = new System.Drawing.Point(239, 216);
            this.SalasanaLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalasanaLB.Name = "SalasanaLB";
            this.SalasanaLB.Size = new System.Drawing.Size(103, 25);
            this.SalasanaLB.TabIndex = 0;
            this.SalasanaLB.Text = "Salasana:";
            // 
            // KayttajatunnusLB
            // 
            this.KayttajatunnusLB.AutoSize = true;
            this.KayttajatunnusLB.BackColor = System.Drawing.Color.Transparent;
            this.KayttajatunnusLB.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajatunnusLB.Location = new System.Drawing.Point(216, 147);
            this.KayttajatunnusLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KayttajatunnusLB.Name = "KayttajatunnusLB";
            this.KayttajatunnusLB.Size = new System.Drawing.Size(159, 25);
            this.KayttajatunnusLB.TabIndex = 1;
            this.KayttajatunnusLB.Text = "Käyttäjätunnus:";
            // 
            // KayttajatunnusTB
            // 
            this.KayttajatunnusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajatunnusTB.Location = new System.Drawing.Point(186, 175);
            this.KayttajatunnusTB.Name = "KayttajatunnusTB";
            this.KayttajatunnusTB.Size = new System.Drawing.Size(212, 29);
            this.KayttajatunnusTB.TabIndex = 2;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaTB.Location = new System.Drawing.Point(186, 244);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(212, 29);
            this.SalasanaTB.TabIndex = 3;
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.BackColor = System.Drawing.Color.Transparent;
            this.OtsikkoLB.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtsikkoLB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.OtsikkoLB.Location = new System.Drawing.Point(138, 96);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(0, 35);
            this.OtsikkoLB.TabIndex = 4;
            // 
            // KirjauduBT
            // 
            this.KirjauduBT.BackColor = System.Drawing.Color.MediumAquamarine;
            this.KirjauduBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KirjauduBT.Location = new System.Drawing.Point(221, 279);
            this.KirjauduBT.Name = "KirjauduBT";
            this.KirjauduBT.Size = new System.Drawing.Size(133, 38);
            this.KirjauduBT.TabIndex = 5;
            this.KirjauduBT.Text = "Kirjaudu";
            this.KirjauduBT.UseVisualStyleBackColor = false;
            this.KirjauduBT.Click += new System.EventHandler(this.KirjauduBT_Click);
            // 
            // VirheviestiLB
            // 
            this.VirheviestiLB.AutoSize = true;
            this.VirheviestiLB.BackColor = System.Drawing.SystemColors.Info;
            this.VirheviestiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirheviestiLB.ForeColor = System.Drawing.Color.OrangeRed;
            this.VirheviestiLB.Location = new System.Drawing.Point(133, 393);
            this.VirheviestiLB.Name = "VirheviestiLB";
            this.VirheviestiLB.Size = new System.Drawing.Size(315, 24);
            this.VirheviestiLB.TabIndex = 6;
            this.VirheviestiLB.Text = "Väärä käyttäjätunnus tai salasana";
            this.VirheviestiLB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 73);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hotellin hallinta";
            // 
            // KirjauduForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hotel_management.Properties.Resources.kirjaudu_backg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(597, 747);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VirheviestiLB);
            this.Controls.Add(this.KirjauduBT);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.SalasanaTB);
            this.Controls.Add(this.KayttajatunnusTB);
            this.Controls.Add(this.KayttajatunnusLB);
            this.Controls.Add(this.SalasanaLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KirjauduForm";
            this.Text = "Kirjautumislomake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SalasanaLB;
        private System.Windows.Forms.Label KayttajatunnusLB;
        private System.Windows.Forms.TextBox KayttajatunnusTB;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.Label OtsikkoLB;
        private System.Windows.Forms.Button KirjauduBT;
        private System.Windows.Forms.Label VirheviestiLB;
        private System.Windows.Forms.Label label1;
    }
}

