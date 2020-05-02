namespace Winforms11Exercise1
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
            this.helloWorldTxt = new System.Windows.Forms.Label();
            this.bluePnl = new System.Windows.Forms.Panel();
            this.yellowPnl = new System.Windows.Forms.Panel();
            this.greenPnl = new System.Windows.Forms.Panel();
            this.redPnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloWorldTxt
            // 
            this.helloWorldTxt.AutoSize = true;
            this.helloWorldTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.helloWorldTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.helloWorldTxt.Location = new System.Drawing.Point(100, 29);
            this.helloWorldTxt.Name = "helloWorldTxt";
            this.helloWorldTxt.Size = new System.Drawing.Size(230, 42);
            this.helloWorldTxt.TabIndex = 0;
            this.helloWorldTxt.Text = "Hello World !";
            // 
            // bluePnl
            // 
            this.bluePnl.BackColor = System.Drawing.Color.Blue;
            this.bluePnl.Location = new System.Drawing.Point(84, 176);
            this.bluePnl.Name = "bluePnl";
            this.bluePnl.Size = new System.Drawing.Size(134, 87);
            this.bluePnl.TabIndex = 0;
            this.bluePnl.Click += new System.EventHandler(this.bluePnl_Click);
            // 
            // yellowPnl
            // 
            this.yellowPnl.BackColor = System.Drawing.Color.Yellow;
            this.yellowPnl.Location = new System.Drawing.Point(224, 176);
            this.yellowPnl.Name = "yellowPnl";
            this.yellowPnl.Size = new System.Drawing.Size(134, 87);
            this.yellowPnl.TabIndex = 1;
            this.yellowPnl.Click += new System.EventHandler(this.yellowPnl_Click);
            // 
            // greenPnl
            // 
            this.greenPnl.BackColor = System.Drawing.Color.Lime;
            this.greenPnl.Location = new System.Drawing.Point(224, 83);
            this.greenPnl.Name = "greenPnl";
            this.greenPnl.Size = new System.Drawing.Size(134, 87);
            this.greenPnl.TabIndex = 1;
            this.greenPnl.Click += new System.EventHandler(this.greenPnl_Click);
            // 
            // redPnl
            // 
            this.redPnl.BackColor = System.Drawing.Color.Red;
            this.redPnl.Location = new System.Drawing.Point(84, 83);
            this.redPnl.Name = "redPnl";
            this.redPnl.Size = new System.Drawing.Size(134, 87);
            this.redPnl.TabIndex = 1;
            this.redPnl.Click += new System.EventHandler(this.redPnl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(121, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Click one of the colors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(431, 326);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.redPnl);
            this.Controls.Add(this.greenPnl);
            this.Controls.Add(this.yellowPnl);
            this.Controls.Add(this.bluePnl);
            this.Controls.Add(this.helloWorldTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloWorldTxt;
        private System.Windows.Forms.Panel bluePnl;
        private System.Windows.Forms.Panel yellowPnl;
        private System.Windows.Forms.Panel greenPnl;
        private System.Windows.Forms.Panel redPnl;
        private System.Windows.Forms.Label label2;
    }
}

