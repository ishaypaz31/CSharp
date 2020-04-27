namespace WindowsFormsApp1
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
            this.displayTimeBtn = new System.Windows.Forms.Button();
            this.timeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayTimeBtn
            // 
            this.displayTimeBtn.Location = new System.Drawing.Point(55, 68);
            this.displayTimeBtn.Name = "displayTimeBtn";
            this.displayTimeBtn.Size = new System.Drawing.Size(141, 86);
            this.displayTimeBtn.TabIndex = 0;
            this.displayTimeBtn.Text = "Click for timer";
            this.displayTimeBtn.UseVisualStyleBackColor = true;
            this.displayTimeBtn.Click += new System.EventHandler(this.displayTimeBtn_Click);
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(63, 204);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(107, 20);
            this.timeLbl.TabIndex = 1;
            this.timeLbl.Text = "I\'m Waiting.....";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 328);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.displayTimeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayTimeBtn;
        private System.Windows.Forms.Label timeLbl;

    }
}

