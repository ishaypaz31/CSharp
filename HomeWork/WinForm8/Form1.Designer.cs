namespace WinForm8
{
    partial class Form1
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
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Narkisim", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.Color.Red;
            this.FirstName.Location = new System.Drawing.Point(109, 81);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(119, 47);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "Ishay";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Narkisim", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LastName.ForeColor = System.Drawing.Color.Blue;
            this.LastName.Location = new System.Drawing.Point(123, 128);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(79, 47);
            this.LastName.TabIndex = 1;
            this.LastName.Text = "Paz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 379);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Name = "Form1";
            this.Text = "FirstNLastName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
    }
}

