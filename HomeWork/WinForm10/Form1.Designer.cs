namespace Winforms10
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
            this.firstTxt = new System.Windows.Forms.TextBox();
            this.secondTxt = new System.Windows.Forms.TextBox();
            this.mulBtn = new System.Windows.Forms.Button();
            this.powerBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.sqrtBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.resultsLst = new System.Windows.Forms.ListBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.randomBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstTxt
            // 
            this.firstTxt.Location = new System.Drawing.Point(32, 54);
            this.firstTxt.Name = "firstTxt";
            this.firstTxt.Size = new System.Drawing.Size(100, 20);
            this.firstTxt.TabIndex = 0;
            // 
            // secondTxt
            // 
            this.secondTxt.Location = new System.Drawing.Point(184, 54);
            this.secondTxt.Name = "secondTxt";
            this.secondTxt.Size = new System.Drawing.Size(100, 20);
            this.secondTxt.TabIndex = 1;
            // 
            // mulBtn
            // 
            this.mulBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mulBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.mulBtn.Location = new System.Drawing.Point(94, 90);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(40, 30);
            this.mulBtn.TabIndex = 3;
            this.mulBtn.Text = "*";
            this.mulBtn.UseVisualStyleBackColor = true;
            this.mulBtn.Click += new System.EventHandler(this.mulBtn_Click);
            // 
            // powerBtn
            // 
            this.powerBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.powerBtn.Location = new System.Drawing.Point(75, 125);
            this.powerBtn.Name = "powerBtn";
            this.powerBtn.Size = new System.Drawing.Size(40, 30);
            this.powerBtn.TabIndex = 4;
            this.powerBtn.Text = "Γ";
            this.powerBtn.UseVisualStyleBackColor = true;
            this.powerBtn.Click += new System.EventHandler(this.powerBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.minusBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.minusBtn.Location = new System.Drawing.Point(140, 90);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(40, 30);
            this.minusBtn.TabIndex = 5;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // sqrtBtn
            // 
            this.sqrtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sqrtBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.sqrtBtn.Location = new System.Drawing.Point(202, 126);
            this.sqrtBtn.Name = "sqrtBtn";
            this.sqrtBtn.Size = new System.Drawing.Size(40, 30);
            this.sqrtBtn.TabIndex = 6;
            this.sqrtBtn.Text = "√";
            this.sqrtBtn.UseVisualStyleBackColor = true;
            this.sqrtBtn.Click += new System.EventHandler(this.sqrtBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.divBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.divBtn.Location = new System.Drawing.Point(186, 90);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(40, 30);
            this.divBtn.TabIndex = 7;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.plusBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.plusBtn.Location = new System.Drawing.Point(138, 54);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(40, 30);
            this.plusBtn.TabIndex = 8;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = false;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // resultsLst
            // 
            this.resultsLst.FormattingEnabled = true;
            this.resultsLst.Location = new System.Drawing.Point(14, 187);
            this.resultsLst.Name = "resultsLst";
            this.resultsLst.Size = new System.Drawing.Size(295, 95);
            this.resultsLst.TabIndex = 9;
            // 
            // clearBtn
            // 
            this.clearBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.clearBtn.Location = new System.Drawing.Point(121, 158);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // randomBtn
            // 
            this.randomBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.randomBtn.Location = new System.Drawing.Point(121, 129);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(75, 23);
            this.randomBtn.TabIndex = 11;
            this.randomBtn.Text = "Random";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(103, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(321, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.resultsLst);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.sqrtBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.powerBtn);
            this.Controls.Add(this.mulBtn);
            this.Controls.Add(this.secondTxt);
            this.Controls.Add(this.firstTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstTxt;
        private System.Windows.Forms.TextBox secondTxt;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button powerBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button sqrtBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.ListBox resultsLst;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.Label label1;
    }
}

