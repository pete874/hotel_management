namespace hotel_management
{
    partial class Varaukset_form
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
            this.VarauksetLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VarausnroTB = new System.Windows.Forms.TextBox();
            this.TyontekijaCB = new System.Windows.Forms.ComboBox();
            this.HuonetyyppiCB = new System.Windows.Forms.ComboBox();
            this.HuonenroCB = new System.Windows.Forms.ComboBox();
            this.SisaanDTP = new System.Windows.Forms.DateTimePicker();
            this.UlosDTP = new System.Windows.Forms.DateTimePicker();
            this.LisaaBT = new System.Windows.Forms.Button();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.MuokkaaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.VarauksetDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VarauksetDG)).BeginInit();
            this.SuspendLayout();
            // 
            // VarauksetLB
            // 
            this.VarauksetLB.AutoSize = true;
            this.VarauksetLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarauksetLB.Location = new System.Drawing.Point(484, 38);
            this.VarauksetLB.Name = "VarauksetLB";
            this.VarauksetLB.Size = new System.Drawing.Size(155, 33);
            this.VarauksetLB.TabIndex = 0;
            this.VarauksetLB.Text = "Varaukset";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Varaus Nro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Työntekijä:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Huonetyyppi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Huone Nro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sisään:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ulos:";
            // 
            // VarausnroTB
            // 
            this.VarausnroTB.Location = new System.Drawing.Point(175, 118);
            this.VarausnroTB.Name = "VarausnroTB";
            this.VarausnroTB.ReadOnly = true;
            this.VarausnroTB.Size = new System.Drawing.Size(174, 26);
            this.VarausnroTB.TabIndex = 7;
            // 
            // TyontekijaCB
            // 
            this.TyontekijaCB.FormattingEnabled = true;
            this.TyontekijaCB.Location = new System.Drawing.Point(175, 159);
            this.TyontekijaCB.Name = "TyontekijaCB";
            this.TyontekijaCB.Size = new System.Drawing.Size(172, 28);
            this.TyontekijaCB.TabIndex = 8;
            // 
            // HuonetyyppiCB
            // 
            this.HuonetyyppiCB.FormattingEnabled = true;
            this.HuonetyyppiCB.Location = new System.Drawing.Point(175, 202);
            this.HuonetyyppiCB.Name = "HuonetyyppiCB";
            this.HuonetyyppiCB.Size = new System.Drawing.Size(172, 28);
            this.HuonetyyppiCB.TabIndex = 9;
            // 
            // HuonenroCB
            // 
            this.HuonenroCB.FormattingEnabled = true;
            this.HuonenroCB.Location = new System.Drawing.Point(175, 245);
            this.HuonenroCB.Name = "HuonenroCB";
            this.HuonenroCB.Size = new System.Drawing.Size(172, 28);
            this.HuonenroCB.TabIndex = 10;
            // 
            // SisaanDTP
            // 
            this.SisaanDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SisaanDTP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SisaanDTP.Location = new System.Drawing.Point(175, 288);
            this.SisaanDTP.Name = "SisaanDTP";
            this.SisaanDTP.Size = new System.Drawing.Size(172, 26);
            this.SisaanDTP.TabIndex = 11;
            this.SisaanDTP.Value = new System.DateTime(2023, 3, 7, 13, 13, 23, 0);
            // 
            // UlosDTP
            // 
            this.UlosDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.UlosDTP.Location = new System.Drawing.Point(175, 329);
            this.UlosDTP.Name = "UlosDTP";
            this.UlosDTP.Size = new System.Drawing.Size(172, 26);
            this.UlosDTP.TabIndex = 12;
            // 
            // LisaaBT
            // 
            this.LisaaBT.Location = new System.Drawing.Point(12, 398);
            this.LisaaBT.Name = "LisaaBT";
            this.LisaaBT.Size = new System.Drawing.Size(96, 29);
            this.LisaaBT.TabIndex = 13;
            this.LisaaBT.Text = "Lisää";
            this.LisaaBT.UseVisualStyleBackColor = true;
            this.LisaaBT.Click += new System.EventHandler(this.LisaaBT_Click);
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Location = new System.Drawing.Point(217, 398);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(98, 29);
            this.TyhjennaBT.TabIndex = 14;
            this.TyhjennaBT.Text = "Tyhjennä";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // MuokkaaBT
            // 
            this.MuokkaaBT.Location = new System.Drawing.Point(114, 398);
            this.MuokkaaBT.Name = "MuokkaaBT";
            this.MuokkaaBT.Size = new System.Drawing.Size(97, 29);
            this.MuokkaaBT.TabIndex = 15;
            this.MuokkaaBT.Text = "Muokkaa";
            this.MuokkaaBT.UseVisualStyleBackColor = true;
            this.MuokkaaBT.Click += new System.EventHandler(this.MuokkaaBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.Location = new System.Drawing.Point(321, 398);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(97, 29);
            this.PoistaBT.TabIndex = 16;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = true;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // VarauksetDG
            // 
            this.VarauksetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VarauksetDG.Location = new System.Drawing.Point(424, 118);
            this.VarauksetDG.Name = "VarauksetDG";
            this.VarauksetDG.Size = new System.Drawing.Size(764, 309);
            this.VarauksetDG.TabIndex = 17;
            this.VarauksetDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VarauksetDG_CellClick);
            // 
            // Varaukset_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.VarauksetDG);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.MuokkaaBT);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.LisaaBT);
            this.Controls.Add(this.UlosDTP);
            this.Controls.Add(this.SisaanDTP);
            this.Controls.Add(this.HuonenroCB);
            this.Controls.Add(this.HuonetyyppiCB);
            this.Controls.Add(this.TyontekijaCB);
            this.Controls.Add(this.VarausnroTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VarauksetLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Varaukset_form";
            this.Text = "Varaukset_form";
            this.Load += new System.EventHandler(this.Varaukset_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VarauksetDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VarauksetLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox VarausnroTB;
        private System.Windows.Forms.ComboBox TyontekijaCB;
        private System.Windows.Forms.ComboBox HuonetyyppiCB;
        private System.Windows.Forms.ComboBox HuonenroCB;
        private System.Windows.Forms.DateTimePicker SisaanDTP;
        private System.Windows.Forms.DateTimePicker UlosDTP;
        private System.Windows.Forms.Button LisaaBT;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Button MuokkaaBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.DataGridView VarauksetDG;
    }
}