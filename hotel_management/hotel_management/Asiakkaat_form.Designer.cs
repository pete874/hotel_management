namespace hotel_management
{
    partial class Asiakkaat_form
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
            this.AsiakkaatLB = new System.Windows.Forms.Label();
            this.AsiakkaatDG = new System.Windows.Forms.DataGridView();
            this.EtunimiLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EtunimiTB = new System.Windows.Forms.TextBox();
            this.SukunimiTB = new System.Windows.Forms.TextBox();
            this.LahiosoiteTB = new System.Windows.Forms.TextBox();
            this.PostinumeroTB = new System.Windows.Forms.TextBox();
            this.PToimipaikkaTB = new System.Windows.Forms.TextBox();
            this.KayttajatunnusTB = new System.Windows.Forms.TextBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.LisaaBT = new System.Windows.Forms.Button();
            this.MuokkaaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.AsiakkaatDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AsiakkaatLB
            // 
            this.AsiakkaatLB.AutoSize = true;
            this.AsiakkaatLB.Font = new System.Drawing.Font("Baskerville Old Face", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakkaatLB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AsiakkaatLB.Location = new System.Drawing.Point(3, 15);
            this.AsiakkaatLB.Name = "AsiakkaatLB";
            this.AsiakkaatLB.Size = new System.Drawing.Size(427, 54);
            this.AsiakkaatLB.TabIndex = 0;
            this.AsiakkaatLB.Text = "Asiakkaiden hallinta";
            // 
            // AsiakkaatDG
            // 
            this.AsiakkaatDG.BackgroundColor = System.Drawing.Color.Linen;
            this.AsiakkaatDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AsiakkaatDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsiakkaatDG.Location = new System.Drawing.Point(-6, 72);
            this.AsiakkaatDG.Name = "AsiakkaatDG";
            this.AsiakkaatDG.Size = new System.Drawing.Size(785, 359);
            this.AsiakkaatDG.TabIndex = 1;
            this.AsiakkaatDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AsiakkaatDG_CellClick);
            // 
            // EtunimiLB
            // 
            this.EtunimiLB.AutoSize = true;
            this.EtunimiLB.Location = new System.Drawing.Point(66, 44);
            this.EtunimiLB.Name = "EtunimiLB";
            this.EtunimiLB.Size = new System.Drawing.Size(66, 20);
            this.EtunimiLB.TabIndex = 2;
            this.EtunimiLB.Text = "Etunimi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sukunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lähiosoite:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Postinumero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Postitoimipaikka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Käyttäjätunnus:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Salasana:";
            // 
            // EtunimiTB
            // 
            this.EtunimiTB.Location = new System.Drawing.Point(216, 43);
            this.EtunimiTB.Name = "EtunimiTB";
            this.EtunimiTB.Size = new System.Drawing.Size(174, 26);
            this.EtunimiTB.TabIndex = 9;
            // 
            // SukunimiTB
            // 
            this.SukunimiTB.Location = new System.Drawing.Point(216, 85);
            this.SukunimiTB.Name = "SukunimiTB";
            this.SukunimiTB.Size = new System.Drawing.Size(174, 26);
            this.SukunimiTB.TabIndex = 10;
            // 
            // LahiosoiteTB
            // 
            this.LahiosoiteTB.Location = new System.Drawing.Point(216, 126);
            this.LahiosoiteTB.Name = "LahiosoiteTB";
            this.LahiosoiteTB.Size = new System.Drawing.Size(174, 26);
            this.LahiosoiteTB.TabIndex = 11;
            // 
            // PostinumeroTB
            // 
            this.PostinumeroTB.Location = new System.Drawing.Point(216, 168);
            this.PostinumeroTB.Name = "PostinumeroTB";
            this.PostinumeroTB.Size = new System.Drawing.Size(174, 26);
            this.PostinumeroTB.TabIndex = 12;
            // 
            // PToimipaikkaTB
            // 
            this.PToimipaikkaTB.Location = new System.Drawing.Point(216, 210);
            this.PToimipaikkaTB.Name = "PToimipaikkaTB";
            this.PToimipaikkaTB.Size = new System.Drawing.Size(174, 26);
            this.PToimipaikkaTB.TabIndex = 13;
            // 
            // KayttajatunnusTB
            // 
            this.KayttajatunnusTB.Location = new System.Drawing.Point(216, 251);
            this.KayttajatunnusTB.Name = "KayttajatunnusTB";
            this.KayttajatunnusTB.ReadOnly = true;
            this.KayttajatunnusTB.Size = new System.Drawing.Size(174, 26);
            this.KayttajatunnusTB.TabIndex = 14;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(216, 294);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.ReadOnly = true;
            this.SalasanaTB.Size = new System.Drawing.Size(174, 26);
            this.SalasanaTB.TabIndex = 15;
            // 
            // LisaaBT
            // 
            this.LisaaBT.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.LisaaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LisaaBT.Location = new System.Drawing.Point(17, 346);
            this.LisaaBT.Name = "LisaaBT";
            this.LisaaBT.Size = new System.Drawing.Size(93, 31);
            this.LisaaBT.TabIndex = 16;
            this.LisaaBT.Text = "Lisää asiakas";
            this.LisaaBT.UseVisualStyleBackColor = false;
            this.LisaaBT.Click += new System.EventHandler(this.LisaaBT_Click);
            // 
            // MuokkaaBT
            // 
            this.MuokkaaBT.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MuokkaaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuokkaaBT.Location = new System.Drawing.Point(116, 346);
            this.MuokkaaBT.Name = "MuokkaaBT";
            this.MuokkaaBT.Size = new System.Drawing.Size(93, 31);
            this.MuokkaaBT.TabIndex = 17;
            this.MuokkaaBT.Text = "Muokkaa";
            this.MuokkaaBT.UseVisualStyleBackColor = false;
            this.MuokkaaBT.Click += new System.EventHandler(this.MuokkaaBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.BackColor = System.Drawing.Color.IndianRed;
            this.PoistaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PoistaBT.Location = new System.Drawing.Point(315, 346);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(92, 31);
            this.PoistaBT.TabIndex = 18;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = false;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TyhjennaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TyhjennaBT.Location = new System.Drawing.Point(216, 346);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(93, 31);
            this.TyhjennaBT.TabIndex = 19;
            this.TyhjennaBT.Text = "Tyhjennä";
            this.TyhjennaBT.UseVisualStyleBackColor = false;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 193);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.splitContainer1.Panel1.Controls.Add(this.TyhjennaBT);
            this.splitContainer1.Panel1.Controls.Add(this.PoistaBT);
            this.splitContainer1.Panel1.Controls.Add(this.MuokkaaBT);
            this.splitContainer1.Panel1.Controls.Add(this.LisaaBT);
            this.splitContainer1.Panel1.Controls.Add(this.SalasanaTB);
            this.splitContainer1.Panel1.Controls.Add(this.KayttajatunnusTB);
            this.splitContainer1.Panel1.Controls.Add(this.PostinumeroTB);
            this.splitContainer1.Panel1.Controls.Add(this.PToimipaikkaTB);
            this.splitContainer1.Panel1.Controls.Add(this.LahiosoiteTB);
            this.splitContainer1.Panel1.Controls.Add(this.SukunimiTB);
            this.splitContainer1.Panel1.Controls.Add(this.EtunimiTB);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.EtunimiLB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Linen;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer1.Panel2.Controls.Add(this.AsiakkaatLB);
            this.splitContainer1.Panel2.Controls.Add(this.AsiakkaatDG);
            this.splitContainer1.Size = new System.Drawing.Size(1210, 422);
            this.splitContainer1.SplitterDistance = 417;
            this.splitContainer1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hotel_management.Properties.Resources.asiakkaat_backg1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1204, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 180);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1203, 16);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // Asiakkaat_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1200, 611);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Asiakkaat_form";
            this.Text = "Hallitse asiakkaita";
            this.Load += new System.EventHandler(this.Asiakkaat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AsiakkaatDG)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AsiakkaatLB;
        private System.Windows.Forms.DataGridView AsiakkaatDG;
        private System.Windows.Forms.Label EtunimiLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EtunimiTB;
        private System.Windows.Forms.TextBox SukunimiTB;
        private System.Windows.Forms.TextBox LahiosoiteTB;
        private System.Windows.Forms.TextBox PostinumeroTB;
        private System.Windows.Forms.TextBox PToimipaikkaTB;
        private System.Windows.Forms.TextBox KayttajatunnusTB;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.Button LisaaBT;
        private System.Windows.Forms.Button MuokkaaBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}