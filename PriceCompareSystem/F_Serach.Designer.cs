namespace PriceCompareSystem
{
    partial class F_Serach
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelMaker = new System.Windows.Forms.Label();
            this.labelPrefectures = new System.Windows.Forms.Label();
            this.comboBoxPrefectures = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxMaker = new System.Windows.Forms.ComboBox();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.comboBoxMajorGenre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSmallGenre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonEasySearch = new System.Windows.Forms.Button();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(7, 91);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(62, 18);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Text = "商品名";
            // 
            // labelMaker
            // 
            this.labelMaker.AutoSize = true;
            this.labelMaker.Location = new System.Drawing.Point(6, 37);
            this.labelMaker.Name = "labelMaker";
            this.labelMaker.Size = new System.Drawing.Size(63, 18);
            this.labelMaker.TabIndex = 2;
            this.labelMaker.Text = "メーカー";
            // 
            // labelPrefectures
            // 
            this.labelPrefectures.AutoSize = true;
            this.labelPrefectures.Location = new System.Drawing.Point(11, 74);
            this.labelPrefectures.Name = "labelPrefectures";
            this.labelPrefectures.Size = new System.Drawing.Size(80, 18);
            this.labelPrefectures.TabIndex = 6;
            this.labelPrefectures.Text = "都道府県";
            this.labelPrefectures.Click += new System.EventHandler(this.labelPrefectures_Click);
            // 
            // comboBoxPrefectures
            // 
            this.comboBoxPrefectures.FormattingEnabled = true;
            this.comboBoxPrefectures.Location = new System.Drawing.Point(122, 71);
            this.comboBoxPrefectures.Name = "comboBoxPrefectures";
            this.comboBoxPrefectures.Size = new System.Drawing.Size(244, 26);
            this.comboBoxPrefectures.TabIndex = 7;
            this.comboBoxPrefectures.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrefectures_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(869, 386);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(176, 75);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "検索";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxMaker
            // 
            this.comboBoxMaker.FormattingEnabled = true;
            this.comboBoxMaker.Location = new System.Drawing.Point(679, 133);
            this.comboBoxMaker.Name = "comboBoxMaker";
            this.comboBoxMaker.Size = new System.Drawing.Size(220, 26);
            this.comboBoxMaker.TabIndex = 12;
            this.comboBoxMaker.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMaker_SelectionChangeCommitted);
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.AllowUserToAddRows = false;
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(189, 481);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersVisible = false;
            this.dataGridViewDsp.RowHeadersWidth = 62;
            this.dataGridViewDsp.RowTemplate.Height = 27;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1472, 536);
            this.dataGridViewDsp.TabIndex = 14;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(679, 187);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(220, 26);
            this.comboBoxProduct.TabIndex = 18;
            // 
            // comboBoxMajorGenre
            // 
            this.comboBoxMajorGenre.FormattingEnabled = true;
            this.comboBoxMajorGenre.Location = new System.Drawing.Point(140, 133);
            this.comboBoxMajorGenre.Name = "comboBoxMajorGenre";
            this.comboBoxMajorGenre.Size = new System.Drawing.Size(121, 26);
            this.comboBoxMajorGenre.TabIndex = 28;
            this.comboBoxMajorGenre.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMajorGenre_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "大ジャンル";
            // 
            // comboBoxSmallGenre
            // 
            this.comboBoxSmallGenre.FormattingEnabled = true;
            this.comboBoxSmallGenre.Location = new System.Drawing.Point(140, 183);
            this.comboBoxSmallGenre.Name = "comboBoxSmallGenre";
            this.comboBoxSmallGenre.Size = new System.Drawing.Size(121, 26);
            this.comboBoxSmallGenre.TabIndex = 26;
            this.comboBoxSmallGenre.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSmallGenre_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "ジャンル";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClear.Location = new System.Drawing.Point(395, 82);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(96, 58);
            this.buttonClear.TabIndex = 29;
            this.buttonClear.Text = "入力クリア";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonEasySearch
            // 
            this.buttonEasySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonEasySearch.Location = new System.Drawing.Point(1604, 25);
            this.buttonEasySearch.Name = "buttonEasySearch";
            this.buttonEasySearch.Size = new System.Drawing.Size(125, 81);
            this.buttonEasySearch.TabIndex = 30;
            this.buttonEasySearch.Text = "簡単検索";
            this.buttonEasySearch.UseVisualStyleBackColor = false;
            this.buttonEasySearch.Click += new System.EventHandler(this.buttonEasySearch_Click);
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Items.AddRange(new object[] {
            "北海道・東北",
            "関東",
            "中部",
            "近畿",
            "中国・四国",
            "九州・沖縄"});
            this.comboBoxRegion.Location = new System.Drawing.Point(122, 33);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(121, 26);
            this.comboBoxRegion.TabIndex = 32;
            this.comboBoxRegion.SelectionChangeCommitted += new System.EventHandler(this.comboBoxRegion_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "地方";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.comboBoxRegion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelPrefectures);
            this.groupBox1.Controls.Add(this.comboBoxPrefectures);
            this.groupBox1.Location = new System.Drawing.Point(978, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 115);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "地域";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxMajorGenre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxSmallGenre);
            this.groupBox2.Controls.Add(this.labelProduct);
            this.groupBox2.Controls.Add(this.labelMaker);
            this.groupBox2.Location = new System.Drawing.Point(539, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 239);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "商品";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(845, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 72);
            this.label4.TabIndex = 36;
            this.label4.Text = "詳細検索";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1852, 595);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(929, 1023);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 38;
            // 
            // F_Serach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1898, 1050);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEasySearch);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.comboBoxMaker);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "F_Serach";
            this.Text = "検索";
            this.Load += new System.EventHandler(this.F_Serach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelMaker;
        private System.Windows.Forms.Label labelPrefectures;
        private System.Windows.Forms.ComboBox comboBoxPrefectures;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxMaker;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.ComboBox comboBoxMajorGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSmallGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonEasySearch;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

