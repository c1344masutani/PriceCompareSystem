namespace PriceCompareSystem
{
    partial class F_Admin
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
            this.buttonGenre = new System.Windows.Forms.Button();
            this.buttonStore = new System.Windows.Forms.Button();
            this.buttonMaker = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonPWChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGenre
            // 
            this.buttonGenre.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonGenre.Location = new System.Drawing.Point(172, 232);
            this.buttonGenre.Name = "buttonGenre";
            this.buttonGenre.Size = new System.Drawing.Size(601, 160);
            this.buttonGenre.TabIndex = 20;
            this.buttonGenre.Text = "ジャンル管理";
            this.buttonGenre.UseVisualStyleBackColor = true;
            this.buttonGenre.Click += new System.EventHandler(this.buttonGenre_Click);
            // 
            // buttonStore
            // 
            this.buttonStore.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonStore.Location = new System.Drawing.Point(172, 45);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Size = new System.Drawing.Size(601, 160);
            this.buttonStore.TabIndex = 19;
            this.buttonStore.Text = "店舗管理";
            this.buttonStore.UseVisualStyleBackColor = true;
            this.buttonStore.Click += new System.EventHandler(this.buttonStore_Click);
            // 
            // buttonMaker
            // 
            this.buttonMaker.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonMaker.Location = new System.Drawing.Point(172, 417);
            this.buttonMaker.Name = "buttonMaker";
            this.buttonMaker.Size = new System.Drawing.Size(601, 160);
            this.buttonMaker.TabIndex = 18;
            this.buttonMaker.Text = "メーカー管理";
            this.buttonMaker.UseVisualStyleBackColor = true;
            this.buttonMaker.Click += new System.EventHandler(this.buttonMaker_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonProduct.Location = new System.Drawing.Point(172, 609);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(601, 160);
            this.buttonProduct.TabIndex = 17;
            this.buttonProduct.Text = "商品管理";
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 788);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 22;
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonMenu.ForeColor = System.Drawing.Color.Black;
            this.buttonMenu.Location = new System.Drawing.Point(22, 25);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(131, 70);
            this.buttonMenu.TabIndex = 45;
            this.buttonMenu.Text = "トップメニュー";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonPWChange
            // 
            this.buttonPWChange.BackColor = System.Drawing.Color.Silver;
            this.buttonPWChange.Location = new System.Drawing.Point(22, 132);
            this.buttonPWChange.Name = "buttonPWChange";
            this.buttonPWChange.Size = new System.Drawing.Size(131, 73);
            this.buttonPWChange.TabIndex = 46;
            this.buttonPWChange.Text = "パスワード変更";
            this.buttonPWChange.UseVisualStyleBackColor = false;
            this.buttonPWChange.Click += new System.EventHandler(this.buttonPWChange_Click);
            // 
            // F_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(919, 826);
            this.ControlBox = false;
            this.Controls.Add(this.buttonPWChange);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGenre);
            this.Controls.Add(this.buttonStore);
            this.Controls.Add(this.buttonMaker);
            this.Controls.Add(this.buttonProduct);
            this.Name = "F_Admin";
            this.Text = "管理画面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_Admin_FormClosing);
            this.Load += new System.EventHandler(this.F_Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGenre;
        private System.Windows.Forms.Button buttonStore;
        private System.Windows.Forms.Button buttonMaker;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonPWChange;
    }
}