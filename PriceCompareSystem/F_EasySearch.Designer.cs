namespace PriceCompareSystem
{
    partial class F_EasySearch
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
            this.textBoxKewWord = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxPrefectures = new System.Windows.Forms.ComboBox();
            this.labelPrefectures = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.buttonSearchForm = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxKewWord
            // 
            this.textBoxKewWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxKewWord.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxKewWord.Location = new System.Drawing.Point(607, 108);
            this.textBoxKewWord.Name = "textBoxKewWord";
            this.textBoxKewWord.Size = new System.Drawing.Size(341, 31);
            this.textBoxKewWord.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSearch.Location = new System.Drawing.Point(607, 270);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(130, 61);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "検索";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxPrefectures
            // 
            this.comboBoxPrefectures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBoxPrefectures.FormattingEnabled = true;
            this.comboBoxPrefectures.Location = new System.Drawing.Point(607, 209);
            this.comboBoxPrefectures.Name = "comboBoxPrefectures";
            this.comboBoxPrefectures.Size = new System.Drawing.Size(244, 26);
            this.comboBoxPrefectures.TabIndex = 10;
            // 
            // labelPrefectures
            // 
            this.labelPrefectures.AutoSize = true;
            this.labelPrefectures.Location = new System.Drawing.Point(479, 217);
            this.labelPrefectures.Name = "labelPrefectures";
            this.labelPrefectures.Size = new System.Drawing.Size(80, 18);
            this.labelPrefectures.TabIndex = 9;
            this.labelPrefectures.Text = "都道府県";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(478, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "キーワード";
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.AllowUserToAddRows = false;
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(106, 347);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 62;
            this.dataGridViewDsp.RowTemplate.Height = 27;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1292, 581);
            this.dataGridViewDsp.TabIndex = 15;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "地域";
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Items.AddRange(new object[] {
            "北海道・東北",
            "関東",
            "中部",
            "近畿",
            "中国・四国",
            "九州・沖縄"});
            this.comboBoxRegion.Location = new System.Drawing.Point(607, 163);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(244, 26);
            this.comboBoxRegion.TabIndex = 36;
            this.comboBoxRegion.SelectionChangeCommitted += new System.EventHandler(this.comboBoxRegion_SelectionChangeCommitted);
            // 
            // buttonSearchForm
            // 
            this.buttonSearchForm.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSearchForm.ForeColor = System.Drawing.Color.White;
            this.buttonSearchForm.Location = new System.Drawing.Point(1231, 28);
            this.buttonSearchForm.Name = "buttonSearchForm";
            this.buttonSearchForm.Size = new System.Drawing.Size(106, 58);
            this.buttonSearchForm.TabIndex = 38;
            this.buttonSearchForm.Text = "詳細検索";
            this.buttonSearchForm.UseVisualStyleBackColor = false;
            this.buttonSearchForm.Click += new System.EventHandler(this.buttonSearchForm_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClear.Location = new System.Drawing.Point(295, 38);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(96, 58);
            this.buttonClear.TabIndex = 39;
            this.buttonClear.Text = "入力クリア";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(549, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 72);
            this.label3.TabIndex = 40;
            this.label3.Text = "かんたん検索";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(725, 997);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1454, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 42;
            // 
            // F_EasySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1518, 1024);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSearchForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxRegion);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxPrefectures);
            this.Controls.Add(this.labelPrefectures);
            this.Controls.Add(this.textBoxKewWord);
            this.Name = "F_EasySearch";
            this.Text = "簡単検索";
            this.Load += new System.EventHandler(this.F_EasySearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKewWord;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxPrefectures;
        private System.Windows.Forms.Label labelPrefectures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.Button buttonSearchForm;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}