namespace Login
{
    partial class Admin_Booking
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
            this.btnAM = new System.Windows.Forms.Button();
            this.btnRE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAM
            // 
            this.btnAM.Location = new System.Drawing.Point(194, 179);
            this.btnAM.Name = "btnAM";
            this.btnAM.Size = new System.Drawing.Size(132, 75);
            this.btnAM.TabIndex = 0;
            this.btnAM.Text = "Add Matches";
            this.btnAM.UseVisualStyleBackColor = true;
            this.btnAM.Click += new System.EventHandler(this.btnAM_Click);
            // 
            // btnRE
            // 
            this.btnRE.Location = new System.Drawing.Point(509, 179);
            this.btnRE.Name = "btnRE";
            this.btnRE.Size = new System.Drawing.Size(122, 75);
            this.btnRE.TabIndex = 1;
            this.btnRE.Text = "Return";
            this.btnRE.UseVisualStyleBackColor = true;
            this.btnRE.Click += new System.EventHandler(this.btnRE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "STARS 2024";
            // 
            // Admin_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRE);
            this.Controls.Add(this.btnAM);
            this.Name = "Admin_Booking";
            this.Text = "Admin_Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAM;
        private System.Windows.Forms.Button btnRE;
        private System.Windows.Forms.Label label1;
    }
}