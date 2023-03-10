namespace hotel_management
{
    partial class Huoneet_form
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HuoneNroTB = new System.Windows.Forms.TextBox();
            this.HuoneTyyppiCB = new System.Windows.Forms.ComboBox();
            this.PuhTB = new System.Windows.Forms.TextBox();
            this.KyllaRB = new System.Windows.Forms.RadioButton();
            this.EiRB = new System.Windows.Forms.RadioButton();
            this.RadiobuttonPN = new System.Windows.Forms.Panel();
            this.HuoneetDG = new System.Windows.Forms.DataGridView();
            this.LisaaBT = new System.Windows.Forms.Button();
            this.MuokkaaBT = new System.Windows.Forms.Button();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.RadiobuttonPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HuoneetDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(505, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huoneet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Huoneen Nro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Huonetyyppi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puhelin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vapaa:";
            // 
            // HuoneNroTB
            // 
            this.HuoneNroTB.Location = new System.Drawing.Point(202, 135);
            this.HuoneNroTB.Name = "HuoneNroTB";
            this.HuoneNroTB.Size = new System.Drawing.Size(171, 26);
            this.HuoneNroTB.TabIndex = 5;
            // 
            // HuoneTyyppiCB
            // 
            this.HuoneTyyppiCB.FormattingEnabled = true;
            this.HuoneTyyppiCB.Location = new System.Drawing.Point(202, 181);
            this.HuoneTyyppiCB.Name = "HuoneTyyppiCB";
            this.HuoneTyyppiCB.Size = new System.Drawing.Size(171, 28);
            this.HuoneTyyppiCB.TabIndex = 6;
            // 
            // PuhTB
            // 
            this.PuhTB.Location = new System.Drawing.Point(202, 224);
            this.PuhTB.Name = "PuhTB";
            this.PuhTB.Size = new System.Drawing.Size(171, 26);
            this.PuhTB.TabIndex = 7;
            // 
            // KyllaRB
            // 
            this.KyllaRB.AutoSize = true;
            this.KyllaRB.Location = new System.Drawing.Point(23, 15);
            this.KyllaRB.Name = "KyllaRB";
            this.KyllaRB.Size = new System.Drawing.Size(77, 24);
            this.KyllaRB.TabIndex = 0;
            this.KyllaRB.TabStop = true;
            this.KyllaRB.Text = "KYLLÄ";
            this.KyllaRB.UseVisualStyleBackColor = true;
            // 
            // EiRB
            // 
            this.EiRB.AutoSize = true;
            this.EiRB.Location = new System.Drawing.Point(106, 15);
            this.EiRB.Name = "EiRB";
            this.EiRB.Size = new System.Drawing.Size(43, 24);
            this.EiRB.TabIndex = 1;
            this.EiRB.TabStop = true;
            this.EiRB.Text = "EI";
            this.EiRB.UseVisualStyleBackColor = true;
            // 
            // RadiobuttonPN
            // 
            this.RadiobuttonPN.BackColor = System.Drawing.Color.Tan;
            this.RadiobuttonPN.Controls.Add(this.KyllaRB);
            this.RadiobuttonPN.Controls.Add(this.EiRB);
            this.RadiobuttonPN.Location = new System.Drawing.Point(202, 256);
            this.RadiobuttonPN.Name = "RadiobuttonPN";
            this.RadiobuttonPN.Size = new System.Drawing.Size(171, 52);
            this.RadiobuttonPN.TabIndex = 9;
            // 
            // HuoneetDG
            // 
            this.HuoneetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HuoneetDG.Location = new System.Drawing.Point(430, 135);
            this.HuoneetDG.Name = "HuoneetDG";
            this.HuoneetDG.Size = new System.Drawing.Size(708, 294);
            this.HuoneetDG.TabIndex = 10;
            this.HuoneetDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HuoneetDG_CellClick);
            // 
            // LisaaBT
            // 
            this.LisaaBT.Location = new System.Drawing.Point(29, 398);
            this.LisaaBT.Name = "LisaaBT";
            this.LisaaBT.Size = new System.Drawing.Size(85, 31);
            this.LisaaBT.TabIndex = 11;
            this.LisaaBT.Text = "Lisää";
            this.LisaaBT.UseVisualStyleBackColor = true;
            this.LisaaBT.Click += new System.EventHandler(this.LisaaBT_Click);
            // 
            // MuokkaaBT
            // 
            this.MuokkaaBT.Location = new System.Drawing.Point(128, 398);
            this.MuokkaaBT.Name = "MuokkaaBT";
            this.MuokkaaBT.Size = new System.Drawing.Size(85, 31);
            this.MuokkaaBT.TabIndex = 12;
            this.MuokkaaBT.Text = "Muokkaa";
            this.MuokkaaBT.UseVisualStyleBackColor = true;
            this.MuokkaaBT.Click += new System.EventHandler(this.MuokkaaBT_Click);
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Location = new System.Drawing.Point(233, 398);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(85, 31);
            this.TyhjennaBT.TabIndex = 13;
            this.TyhjennaBT.Text = "Tyhjennä";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.Location = new System.Drawing.Point(329, 398);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(85, 31);
            this.PoistaBT.TabIndex = 14;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = true;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // Huoneet_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.MuokkaaBT);
            this.Controls.Add(this.LisaaBT);
            this.Controls.Add(this.HuoneetDG);
            this.Controls.Add(this.RadiobuttonPN);
            this.Controls.Add(this.PuhTB);
            this.Controls.Add(this.HuoneTyyppiCB);
            this.Controls.Add(this.HuoneNroTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Huoneet_form";
            this.Text = "Huoneet_form";
            this.Load += new System.EventHandler(this.Huoneet_form_Load);
            this.RadiobuttonPN.ResumeLayout(false);
            this.RadiobuttonPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HuoneetDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HuoneNroTB;
        private System.Windows.Forms.ComboBox HuoneTyyppiCB;
        private System.Windows.Forms.TextBox PuhTB;
        private System.Windows.Forms.RadioButton EiRB;
        private System.Windows.Forms.RadioButton KyllaRB;
        private System.Windows.Forms.Panel RadiobuttonPN;
        private System.Windows.Forms.DataGridView HuoneetDG;
        private System.Windows.Forms.Button LisaaBT;
        private System.Windows.Forms.Button MuokkaaBT;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Button PoistaBT;
    }
}