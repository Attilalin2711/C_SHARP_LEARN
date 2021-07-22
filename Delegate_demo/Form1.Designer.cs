namespace Delegate_demo
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btNew = new System.Windows.Forms.Button();
            this.tsMsg = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(12, 12);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(116, 47);
            this.btNew.TabIndex = 0;
            this.btNew.Text = "new Form";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // tsMsg
            // 
            this.tsMsg.Location = new System.Drawing.Point(12, 205);
            this.tsMsg.Name = "tsMsg";
            this.tsMsg.Size = new System.Drawing.Size(383, 25);
            this.tsMsg.TabIndex = 1;
            this.tsMsg.Text = "hello";
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(279, 267);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(116, 47);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 326);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tsMsg);
            this.Controls.Add(this.btNew);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.TextBox tsMsg;
        private System.Windows.Forms.Button btSend;
    }
}

