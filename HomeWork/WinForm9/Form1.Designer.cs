namespace WinForm9
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.zerofyBtn = new System.Windows.Forms.Button();
            this.lowerLimitTxtBx = new System.Windows.Forms.TextBox();
            this.upperLimitTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(137, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "lowerNumber";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(137, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "upperNumber";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.my_click);
            // 
            // zerofyBtn
            // 
            this.zerofyBtn.Location = new System.Drawing.Point(107, 241);
            this.zerofyBtn.Name = "zerofyBtn";
            this.zerofyBtn.Size = new System.Drawing.Size(150, 42);
            this.zerofyBtn.TabIndex = 2;
            this.zerofyBtn.Text = "Click to reset";
            this.zerofyBtn.UseVisualStyleBackColor = true;
            this.zerofyBtn.Click += new System.EventHandler(this.zerofyBtn_Click);
            // 
            // lowerLimitTxtBx
            // 
            this.lowerLimitTxtBx.Location = new System.Drawing.Point(91, 90);
            this.lowerLimitTxtBx.Name = "lowerLimitTxtBx";
            this.lowerLimitTxtBx.Size = new System.Drawing.Size(191, 20);
            this.lowerLimitTxtBx.TabIndex = 3;
            // 
            // upperLimitTxtBx
            // 
            this.upperLimitTxtBx.Location = new System.Drawing.Point(91, 161);
            this.upperLimitTxtBx.Name = "upperLimitTxtBx";
            this.upperLimitTxtBx.Size = new System.Drawing.Size(191, 20);
            this.upperLimitTxtBx.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(71, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Result";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Location = new System.Drawing.Point(91, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 48);
            this.button3.TabIndex = 6;
            this.button3.Text = "Click to get a random number";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(374, 374);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upperLimitTxtBx);
            this.Controls.Add(this.lowerLimitTxtBx);
            this.Controls.Add(this.zerofyBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button zerofyBtn;
        private System.Windows.Forms.TextBox lowerLimitTxtBx;
        private System.Windows.Forms.TextBox upperLimitTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}

