namespace hotel_management
{
    partial class PaasivuForm
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
            this.TervetuloaLB = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hallitseAsiakkaitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallitseVarauksiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallitseHuoneitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TervetuloaLB
            // 
            this.TervetuloaLB.AutoSize = true;
            this.TervetuloaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TervetuloaLB.Location = new System.Drawing.Point(489, 59);
            this.TervetuloaLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TervetuloaLB.Name = "TervetuloaLB";
            this.TervetuloaLB.Size = new System.Drawing.Size(163, 33);
            this.TervetuloaLB.TabIndex = 0;
            this.TervetuloaLB.Text = "Tervetuloa";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hallitseAsiakkaitaToolStripMenuItem,
            this.hallitseVarauksiaToolStripMenuItem,
            this.hallitseHuoneitaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hallitseAsiakkaitaToolStripMenuItem
            // 
            this.hallitseAsiakkaitaToolStripMenuItem.Name = "hallitseAsiakkaitaToolStripMenuItem";
            this.hallitseAsiakkaitaToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.hallitseAsiakkaitaToolStripMenuItem.Text = "Hallitse asiakkaita";
            this.hallitseAsiakkaitaToolStripMenuItem.Click += new System.EventHandler(this.hallitseAsiakkaitaToolStripMenuItem_Click);
            // 
            // hallitseVarauksiaToolStripMenuItem
            // 
            this.hallitseVarauksiaToolStripMenuItem.Name = "hallitseVarauksiaToolStripMenuItem";
            this.hallitseVarauksiaToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.hallitseVarauksiaToolStripMenuItem.Text = "Hallitse varauksia";
            this.hallitseVarauksiaToolStripMenuItem.Click += new System.EventHandler(this.hallitseVarauksiaToolStripMenuItem_Click);
            // 
            // hallitseHuoneitaToolStripMenuItem
            // 
            this.hallitseHuoneitaToolStripMenuItem.Name = "hallitseHuoneitaToolStripMenuItem";
            this.hallitseHuoneitaToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.hallitseHuoneitaToolStripMenuItem.Text = "Hallitse huoneita";
            this.hallitseHuoneitaToolStripMenuItem.Click += new System.EventHandler(this.hallitseHuoneitaToolStripMenuItem_Click);
            // 
            // PaasivuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.TervetuloaLB);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PaasivuForm";
            this.Text = "Pääsivu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PaasivuForm_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TervetuloaLB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hallitseAsiakkaitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallitseVarauksiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallitseHuoneitaToolStripMenuItem;
    }
}