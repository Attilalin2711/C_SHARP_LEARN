namespace sharp_class
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
            this.btnupgrade = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnupgrade
            // 
            this.btnupgrade.Location = new System.Drawing.Point(126, 225);
            this.btnupgrade.Name = "btnupgrade";
            this.btnupgrade.Size = new System.Drawing.Size(178, 49);
            this.btnupgrade.TabIndex = 2;
            this.btnupgrade.Text = "upgrade";
            this.btnupgrade.UseVisualStyleBackColor = true;
            this.btnupgrade.Click += new System.EventHandler(this.btnupgrade_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 81);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 318);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnupgrade);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnupgrade;
        private System.Windows.Forms.Button button2;
    }
}

