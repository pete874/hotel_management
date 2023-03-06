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
            this.SuspendLayout();
            // 
            // SalasanaLB
            // 
            this.SalasanaLB.AutoSize = true;
            this.SalasanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaLB.Location = new System.Drawing.Point(549, 201);
            this.SalasanaLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalasanaLB.Name = "SalasanaLB";
            this.SalasanaLB.Size = new System.Drawing.Size(100, 24);
            this.SalasanaLB.TabIndex = 0;
            this.SalasanaLB.Text = "Salasana:";
            // 
            // KayttajatunnusLB
            // 
            this.KayttajatunnusLB.AutoSize = true;
            this.KayttajatunnusLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajatunnusLB.Location = new System.Drawing.Point(522, 122);
            this.KayttajatunnusLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KayttajatunnusLB.Name = "KayttajatunnusLB";
            this.KayttajatunnusLB.Size = new System.Drawing.Size(150, 24);
            this.KayttajatunnusLB.TabIndex = 1;
            this.KayttajatunnusLB.Text = "Käyttäjätunnus:";
            // 
            // KayttajatunnusTB
            // 
            this.KayttajatunnusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajatunnusTB.Location = new System.Drawing.Point(491, 149);
            this.KayttajatunnusTB.Name = "KayttajatunnusTB";
            this.KayttajatunnusTB.Size = new System.Drawing.Size(212, 29);
            this.KayttajatunnusTB.TabIndex = 2;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaTB.Location = new System.Drawing.Point(491, 228);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(212, 29);
            this.SalasanaTB.TabIndex = 3;
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtsikkoLB.Location = new System.Drawing.Point(442, 31);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(327, 33);
            this.OtsikkoLB.TabIndex = 4;
            this.OtsikkoLB.Text = "Kirjaudu järjestelmään";
            // 
            // KirjauduBT
            // 
            this.KirjauduBT.BackColor = System.Drawing.Color.MediumAquamarine;
            this.KirjauduBT.Location = new System.Drawing.Point(526, 289);
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
            this.VirheviestiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirheviestiLB.ForeColor = System.Drawing.Color.Red;
            this.VirheviestiLB.Location = new System.Drawing.Point(444, 366);
            this.VirheviestiLB.Name = "VirheviestiLB";
            this.VirheviestiLB.Size = new System.Drawing.Size(315, 24);
            this.VirheviestiLB.TabIndex = 6;
            this.VirheviestiLB.Text = "Väärä käyttäjätunnus tai salasana";
            this.VirheviestiLB.Visible = false;
            // 
            // KirjauduForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
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
    }
}

