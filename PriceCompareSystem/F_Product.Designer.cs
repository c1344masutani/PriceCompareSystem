namespace PriceCompareSystem
{
    partial class F_Product
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
            this.labelPrName = new System.Windows.Forms.Label();
            this.textBoxPrName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMaker = new System.Windows.Forms.ComboBox();
            this.labelPrPrice = new System.Windows.Forms.Label();
            this.textBoxPrPrice = new System.Windows.Forms.TextBox();
            this.buttonRegester = new System.Windows.Forms.Button();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelPrIDtitle = new System.Windows.Forms.Label();
            this.comboBoxMajorGenre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSmallGenre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPrID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrName
            // 
            this.labelPrName.AutoSize = true;
            this.labelPrName.Location = new System.Drawing.Point(67, 161);
            this.labelPrName.Name = "labelPrName";
            this.labelPrName.Size = new System.Drawing.Size(62, 18);
            this.labelPrName.TabIndex = 0;
            this.labelPrName.Text = "商品名";
            // 
            // textBoxPrName
            // 
            this.textBoxPrName.Location = new System.Drawing.Point(167, 153);
            this.textBoxPrName.Name = "textBoxPrName";
            this.textBoxPrName.Size = new System.Drawing.Size(140, 25);
            this.textBoxPrName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "メーカー";
            // 
            // comboBoxMaker
            // 
            this.comboBoxMaker.FormattingEnabled = true;
            this.comboBoxMaker.Location = new System.Drawing.Point(167, 104);
            this.comboBoxMaker.Name = "comboBoxMaker";
            this.comboBoxMaker.Size = new System.Drawing.Size(140, 26);
            this.comboBoxMaker.TabIndex = 3;
            // 
            // labelPrPrice
            // 
            this.labelPrPrice.AutoSize = true;
            this.labelPrPrice.Location = new System.Drawing.Point(376, 104);
            this.labelPrPrice.Name = "labelPrPrice";
            this.labelPrPrice.Size = new System.Drawing.Size(116, 18);
            this.labelPrPrice.TabIndex = 4;
            this.labelPrPrice.Text = "希望小売価格";
            // 
            // textBoxPrPrice
            // 
            this.textBoxPrPrice.Location = new System.Drawing.Point(549, 105);
            this.textBoxPrPrice.Name = "textBoxPrPrice";
            this.textBoxPrPrice.Size = new System.Drawing.Size(165, 25);
            this.textBoxPrPrice.TabIndex = 5;
            // 
            // buttonRegester
            // 
            this.buttonRegester.Location = new System.Drawing.Point(306, 258);
            this.buttonRegester.Name = "buttonRegester";
            this.buttonRegester.Size = new System.Drawing.Size(109, 56);
            this.buttonRegester.TabIndex = 8;
            this.buttonRegester.Text = "登録";
            this.buttonRegester.UseVisualStyleBackColor = true;
            this.buttonRegester.Click += new System.EventHandler(this.buttonRegester_Click);
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(70, 380);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 62;
            this.dataGridViewDsp.RowTemplate.Height = 27;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1285, 577);
            this.dataGridViewDsp.TabIndex = 9;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(453, 258);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(109, 56);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "更新";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(596, 258);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 56);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelPrIDtitle
            // 
            this.labelPrIDtitle.AutoSize = true;
            this.labelPrIDtitle.Location = new System.Drawing.Point(67, 62);
            this.labelPrIDtitle.Name = "labelPrIDtitle";
            this.labelPrIDtitle.Size = new System.Drawing.Size(60, 18);
            this.labelPrIDtitle.TabIndex = 12;
            this.labelPrIDtitle.Text = "商品ID";
            // 
            // comboBoxMajorGenre
            // 
            this.comboBoxMajorGenre.FormattingEnabled = true;
            this.comboBoxMajorGenre.Location = new System.Drawing.Point(484, 153);
            this.comboBoxMajorGenre.Name = "comboBoxMajorGenre";
            this.comboBoxMajorGenre.Size = new System.Drawing.Size(121, 26);
            this.comboBoxMajorGenre.TabIndex = 24;
            this.comboBoxMajorGenre.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMajorGenre_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "大ジャンル";
            // 
            // comboBoxSmallGenre
            // 
            this.comboBoxSmallGenre.FormattingEnabled = true;
            this.comboBoxSmallGenre.Location = new System.Drawing.Point(484, 197);
            this.comboBoxSmallGenre.Name = "comboBoxSmallGenre";
            this.comboBoxSmallGenre.Size = new System.Drawing.Size(121, 26);
            this.comboBoxSmallGenre.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "ジャンル";
            // 
            // labelPrID
            // 
            this.labelPrID.AutoSize = true;
            this.labelPrID.Location = new System.Drawing.Point(164, 62);
            this.labelPrID.Name = "labelPrID";
            this.labelPrID.Size = new System.Drawing.Size(0, 18);
            this.labelPrID.TabIndex = 25;
            // 
            // F_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.labelPrID);
            this.Controls.Add(this.comboBoxMajorGenre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSmallGenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPrIDtitle);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.buttonRegester);
            this.Controls.Add(this.textBoxPrPrice);
            this.Controls.Add(this.labelPrPrice);
            this.Controls.Add(this.comboBoxMaker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrName);
            this.Controls.Add(this.labelPrName);
            this.Name = "F_Product";
            this.Text = "商品管理";
            this.Load += new System.EventHandler(this.F_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrName;
        private System.Windows.Forms.TextBox textBoxPrName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMaker;
        private System.Windows.Forms.Label labelPrPrice;
        private System.Windows.Forms.TextBox textBoxPrPrice;
        private System.Windows.Forms.Button buttonRegester;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelPrIDtitle;
        private System.Windows.Forms.ComboBox comboBoxMajorGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSmallGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPrID;
    }
}