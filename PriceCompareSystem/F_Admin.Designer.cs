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
            this.buttonPriceList = new System.Windows.Forms.Button();
            this.buttonGenre = new System.Windows.Forms.Button();
            this.buttonStore = new System.Windows.Forms.Button();
            this.buttonMaker = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPriceList
            // 
            this.buttonPriceList.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonPriceList.Location = new System.Drawing.Point(144, 185);
            this.buttonPriceList.Name = "buttonPriceList";
            this.buttonPriceList.Size = new System.Drawing.Size(601, 120);
            this.buttonPriceList.TabIndex = 21;
            this.buttonPriceList.Text = "価格リスト管理";
            this.buttonPriceList.UseVisualStyleBackColor = true;
            this.buttonPriceList.Click += new System.EventHandler(this.buttonPriceList_Click);
            // 
            // buttonGenre
            // 
            this.buttonGenre.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonGenre.Location = new System.Drawing.Point(144, 325);
            this.buttonGenre.Name = "buttonGenre";
            this.buttonGenre.Size = new System.Drawing.Size(601, 120);
            this.buttonGenre.TabIndex = 20;
            this.buttonGenre.Text = "ジャンル管理";
            this.buttonGenre.UseVisualStyleBackColor = true;
            this.buttonGenre.Click += new System.EventHandler(this.buttonGenre_Click);
            // 
            // buttonStore
            // 
            this.buttonStore.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonStore.Location = new System.Drawing.Point(144, 46);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Size = new System.Drawing.Size(601, 120);
            this.buttonStore.TabIndex = 19;
            this.buttonStore.Text = "店舗管理";
            this.buttonStore.UseVisualStyleBackColor = true;
            this.buttonStore.Click += new System.EventHandler(this.buttonStore_Click);
            // 
            // buttonMaker
            // 
            this.buttonMaker.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonMaker.Location = new System.Drawing.Point(144, 468);
            this.buttonMaker.Name = "buttonMaker";
            this.buttonMaker.Size = new System.Drawing.Size(601, 120);
            this.buttonMaker.TabIndex = 18;
            this.buttonMaker.Text = "メーカー管理";
            this.buttonMaker.UseVisualStyleBackColor = true;
            this.buttonMaker.Click += new System.EventHandler(this.buttonMaker_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonProduct.Location = new System.Drawing.Point(144, 605);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(601, 120);
            this.buttonProduct.TabIndex = 17;
            this.buttonProduct.Text = "商品管理";
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 728);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 22;
            // 
            // F_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(919, 826);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPriceList);
            this.Controls.Add(this.buttonGenre);
            this.Controls.Add(this.buttonStore);
            this.Controls.Add(this.buttonMaker);
            this.Controls.Add(this.buttonProduct);
            this.Name = "F_Admin";
            this.Text = "管理画面";
            this.Load += new System.EventHandler(this.F_Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPriceList;
        private System.Windows.Forms.Button buttonGenre;
        private System.Windows.Forms.Button buttonStore;
        private System.Windows.Forms.Button buttonMaker;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Label label1;
    }
}