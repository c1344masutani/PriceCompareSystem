﻿namespace PriceCompareSystem
{
    partial class F_PriceList
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
            this.labelPlIDtitle = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.comboBoxSmallGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRegester = new System.Windows.Forms.Button();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.comboBoxMaker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMajorGenre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStName = new System.Windows.Forms.Label();
            this.labelPlID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlIDtitle
            // 
            this.labelPlIDtitle.AutoSize = true;
            this.labelPlIDtitle.Location = new System.Drawing.Point(28, 33);
            this.labelPlIDtitle.Name = "labelPlIDtitle";
            this.labelPlIDtitle.Size = new System.Drawing.Size(98, 18);
            this.labelPlIDtitle.TabIndex = 0;
            this.labelPlIDtitle.Text = "価格リストID";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(28, 119);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(63, 18);
            this.labelGenre.TabIndex = 2;
            this.labelGenre.Text = "ジャンル";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(331, 122);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(62, 18);
            this.labelProduct.TabIndex = 4;
            this.labelProduct.Text = "商品名";
            // 
            // comboBoxSmallGenre
            // 
            this.comboBoxSmallGenre.FormattingEnabled = true;
            this.comboBoxSmallGenre.Location = new System.Drawing.Point(132, 119);
            this.comboBoxSmallGenre.Name = "comboBoxSmallGenre";
            this.comboBoxSmallGenre.Size = new System.Drawing.Size(121, 26);
            this.comboBoxSmallGenre.TabIndex = 5;
            this.comboBoxSmallGenre.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSmallGenre_SelectionChangeCommitted);
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(435, 122);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(121, 26);
            this.comboBoxProduct.TabIndex = 6;
            this.comboBoxProduct.SelectionChangeCommitted += new System.EventHandler(this.comboBoxProduct_SelectionChangeCommitted);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(654, 73);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 18);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "価格";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(755, 73);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(183, 25);
            this.textBoxPrice.TabIndex = 8;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(710, 210);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 44);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(541, 210);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(102, 44);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "更新";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRegester
            // 
            this.buttonRegester.Location = new System.Drawing.Point(375, 210);
            this.buttonRegester.Name = "buttonRegester";
            this.buttonRegester.Size = new System.Drawing.Size(94, 44);
            this.buttonRegester.TabIndex = 13;
            this.buttonRegester.Text = "登録";
            this.buttonRegester.UseVisualStyleBackColor = true;
            this.buttonRegester.Click += new System.EventHandler(this.buttonRegester_Click);
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(61, 312);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 62;
            this.dataGridViewDsp.RowTemplate.Height = 27;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1246, 413);
            this.dataGridViewDsp.TabIndex = 16;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            // 
            // comboBoxMaker
            // 
            this.comboBoxMaker.FormattingEnabled = true;
            this.comboBoxMaker.Location = new System.Drawing.Point(435, 68);
            this.comboBoxMaker.Name = "comboBoxMaker";
            this.comboBoxMaker.Size = new System.Drawing.Size(140, 26);
            this.comboBoxMaker.TabIndex = 18;
            this.comboBoxMaker.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMaker_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "メーカー";
            // 
            // comboBoxMajorGenre
            // 
            this.comboBoxMajorGenre.FormattingEnabled = true;
            this.comboBoxMajorGenre.Location = new System.Drawing.Point(132, 73);
            this.comboBoxMajorGenre.Name = "comboBoxMajorGenre";
            this.comboBoxMajorGenre.Size = new System.Drawing.Size(121, 26);
            this.comboBoxMajorGenre.TabIndex = 20;
            this.comboBoxMajorGenre.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMajorGenre_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "大ジャンル";
            // 
            // labelStName
            // 
            this.labelStName.AutoSize = true;
            this.labelStName.Location = new System.Drawing.Point(1245, 28);
            this.labelStName.Name = "labelStName";
            this.labelStName.Size = new System.Drawing.Size(62, 18);
            this.labelStName.TabIndex = 21;
            this.labelStName.Text = "店舗名";
            // 
            // labelPlID
            // 
            this.labelPlID.AutoSize = true;
            this.labelPlID.Location = new System.Drawing.Point(145, 29);
            this.labelPlID.Name = "labelPlID";
            this.labelPlID.Size = new System.Drawing.Size(0, 18);
            this.labelPlID.TabIndex = 22;
            // 
            // F_PriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.labelPlID);
            this.Controls.Add(this.labelStName);
            this.Controls.Add(this.comboBoxMajorGenre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMaker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRegester);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.comboBoxSmallGenre);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelPlIDtitle);
            this.Name = "F_PriceList";
            this.Text = "価格リスト管理";
            this.Load += new System.EventHandler(this.F_PriceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlIDtitle;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.ComboBox comboBoxSmallGenre;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRegester;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.ComboBox comboBoxMaker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMajorGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStName;
        private System.Windows.Forms.Label labelPlID;
    }
}