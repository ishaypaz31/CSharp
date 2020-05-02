namespace Winforms11Exercise3
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
            this.yellowPanel1 = new System.Windows.Forms.Panel();
            this.greenPanel3 = new System.Windows.Forms.Panel();
            this.redPanel0 = new System.Windows.Forms.Panel();
            this.bluePanel2 = new System.Windows.Forms.Panel();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yellowPanel1
            // 
            this.yellowPanel1.BackColor = System.Drawing.Color.Yellow;
            this.yellowPanel1.Location = new System.Drawing.Point(218, 0);
            this.yellowPanel1.Name = "yellowPanel1";
            this.yellowPanel1.Size = new System.Drawing.Size(201, 177);
            this.yellowPanel1.TabIndex = 0;
            this.yellowPanel1.Click += new System.EventHandler(this.yellowPanel1_Click);
            // 
            // greenPanel3
            // 
            this.greenPanel3.BackColor = System.Drawing.Color.Lime;
            this.greenPanel3.Location = new System.Drawing.Point(218, 183);
            this.greenPanel3.Name = "greenPanel3";
            this.greenPanel3.Size = new System.Drawing.Size(201, 166);
            this.greenPanel3.TabIndex = 1;
            this.greenPanel3.Click += new System.EventHandler(this.greenPanel3_Click);
            // 
            // redPanel0
            // 
            this.redPanel0.BackColor = System.Drawing.Color.Red;
            this.redPanel0.Location = new System.Drawing.Point(3, 0);
            this.redPanel0.Name = "redPanel0";
            this.redPanel0.Size = new System.Drawing.Size(201, 177);
            this.redPanel0.TabIndex = 1;
            this.redPanel0.Click += new System.EventHandler(this.redPanel0_Click);
            // 
            // bluePanel2
            // 
            this.bluePanel2.BackColor = System.Drawing.Color.Blue;
            this.bluePanel2.Location = new System.Drawing.Point(3, 183);
            this.bluePanel2.Name = "bluePanel2";
            this.bluePanel2.Size = new System.Drawing.Size(201, 166);
            this.bluePanel2.TabIndex = 2;
            this.bluePanel2.Click += new System.EventHandler(this.bluePanel2_Click);
            // 
            // startGameBtn
            // 
            this.startGameBtn.Location = new System.Drawing.Point(142, 380);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(127, 53);
            this.startGameBtn.TabIndex = 3;
            this.startGameBtn.Text = "START";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(368, 378);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(51, 55);
            this.scoreLbl.TabIndex = 4;
            this.scoreLbl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 434);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.bluePanel2);
            this.Controls.Add(this.redPanel0);
            this.Controls.Add(this.greenPanel3);
            this.Controls.Add(this.yellowPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel yellowPanel1;
        private System.Windows.Forms.Panel greenPanel3;
        private System.Windows.Forms.Panel redPanel0;
        private System.Windows.Forms.Panel bluePanel2;
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Label scoreLbl;
    }
}

