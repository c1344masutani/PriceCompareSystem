namespace PriceCompareSystem
{
    partial class F_Login
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
            this.textBoxStID = new System.Windows.Forms.TextBox();
            this.labelStID = new System.Windows.Forms.Label();
            this.labelPassWord = new System.Windows.Forms.Label();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxStID
            // 
            this.textBoxStID.Location = new System.Drawing.Point(252, 127);
            this.textBoxStID.Name = "textBoxStID";
            this.textBoxStID.Size = new System.Drawing.Size(226, 25);
            this.textBoxStID.TabIndex = 0;
            // 
            // labelStID
            // 
            this.labelStID.AutoSize = true;
            this.labelStID.Location = new System.Drawing.Point(161, 127);
            this.labelStID.Name = "labelStID";
            this.labelStID.Size = new System.Drawing.Size(60, 18);
            this.labelStID.TabIndex = 1;
            this.labelStID.Text = "店舗ID";
            // 
            // labelPassWord
            // 
            this.labelPassWord.AutoSize = true;
            this.labelPassWord.Location = new System.Drawing.Point(161, 189);
            this.labelPassWord.Name = "labelPassWord";
            this.labelPassWord.Size = new System.Drawing.Size(79, 18);
            this.labelPassWord.TabIndex = 3;
            this.labelPassWord.Text = "パスワード";
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.Location = new System.Drawing.Point(252, 189);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.Size = new System.Drawing.Size(226, 25);
            this.textBoxPassWord.TabIndex = 2;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(252, 248);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(107, 48);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "ログイン";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelPassWord);
            this.Controls.Add(this.textBoxPassWord);
            this.Controls.Add(this.labelStID);
            this.Controls.Add(this.textBoxStID);
            this.Name = "F_Login";
            this.Text = "店舗ログイン";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStID;
        private System.Windows.Forms.Label labelStID;
        private System.Windows.Forms.Label labelPassWord;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.Button buttonLogin;
    }
}