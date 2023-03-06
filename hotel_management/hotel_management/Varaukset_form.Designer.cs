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
            // Varaukset_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.VarauksetLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Varaukset_form";
            this.Text = "Varaukset_form";
            this.Load += new System.EventHandler(this.Varaukset_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VarauksetLB;
    }
}