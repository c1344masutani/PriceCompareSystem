namespace PriceCompareSystem
{
    partial class F_Store
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
            this.components = new System.ComponentModel.Container();
            this.labelStIDtitle = new System.Windows.Forms.Label();
            this.textBoxStName = new System.Windows.Forms.TextBox();
            this.labelStName = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPrefectures = new System.Windows.Forms.Label();
            this.comboBoxPrefectures = new System.Windows.Forms.ComboBox();
            this.prefectureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceCompareSystemDataSet1 = new PriceCompareSystem.PriceCompareSystemDataSet1();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRegester = new System.Windows.Forms.Button();
            this.priceCompareSystemDataSet = new PriceCompareSystem.PriceCompareSystemDataSet();
            this.priceCompareSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prefectureTableAdapter = new PriceCompareSystem.PriceCompareSystemDataSet1TableAdapters.PrefectureTableAdapter();
            this.priceCompareSystemDataSet2 = new PriceCompareSystem.PriceCompareSystemDataSet2();
            this.prefectureBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prefectureTableAdapter1 = new PriceCompareSystem.PriceCompareSystemDataSet2TableAdapters.PrefectureTableAdapter();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.labelPW = new System.Windows.Forms.Label();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.labelStID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.prefectureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCompareSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCompareSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCompareSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCompareSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prefectureBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStIDtitle
            // 
            this.labelStIDtitle.AutoSize = true;
            this.labelStIDtitle.Location = new System.Drawing.Point(147, 107);
            this.labelStIDtitle.Name = "labelStIDtitle";
            this.labelStIDtitle.Size = new System.Drawing.Size(60, 18);
            this.labelStIDtitle.TabIndex = 0;
            this.labelStIDtitle.Text = "店舗ID";
            // 
            // textBoxStName
            // 
            this.textBoxStName.Location = new System.Drawing.Point(249, 155);
            this.textBoxStName.Name = "textBoxStName";
            this.textBoxStName.Size = new System.Drawing.Size(203, 25);
            this.textBoxStName.TabIndex = 3;
            // 
            // labelStName
            // 
            this.labelStName.AutoSize = true;
            this.labelStName.Location = new System.Drawing.Point(147, 162);
            this.labelStName.Name = "labelStName";
            this.labelStName.Size = new System.Drawing.Size(62, 18);
            this.labelStName.TabIndex = 2;
            this.labelStName.Text = "店舗名";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(249, 253);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(201, 25);
            this.textBoxAddress.TabIndex = 5;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(149, 260);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(44, 18);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "住所";
            // 
            // labelPrefectures
            // 
            this.labelPrefectures.AutoSize = true;
            this.labelPrefectures.Location = new System.Drawing.Point(463, 216);
            this.labelPrefectures.Name = "labelPrefectures";
            this.labelPrefectures.Size = new System.Drawing.Size(80, 18);
            this.labelPrefectures.TabIndex = 6;
            this.labelPrefectures.Text = "都道府県";
            // 
            // comboBoxPrefectures
            // 
            this.comboBoxPrefectures.FormattingEnabled = true;
            this.comboBoxPrefectures.Location = new System.Drawing.Point(562, 207);
            this.comboBoxPrefectures.Name = "comboBoxPrefectures";
            this.comboBoxPrefectures.Size = new System.Drawing.Size(149, 26);
            this.comboBoxPrefectures.TabIndex = 7;
            // 
            // prefectureBindingSource
            // 
            this.prefectureBindingSource.DataMember = "Prefecture";
            this.prefectureBindingSource.DataSource = this.priceCompareSystemDataSet1;
            // 
            // priceCompareSystemDataSet1
            // 
            this.priceCompareSystemDataSet1.DataSetName = "PriceCompareSystemDataSet1";
            this.priceCompareSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(249, 311);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(201, 25);
            this.textBoxPhone.TabIndex = 9;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(147, 318);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(80, 18);
            this.labelPhone.TabIndex = 8;
            this.labelPhone.Text = "電話番号";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(562, 373);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 56);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(419, 373);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(109, 56);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "更新";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRegester
            // 
            this.buttonRegester.Location = new System.Drawing.Point(272, 373);
            this.buttonRegester.Name = "buttonRegester";
            this.buttonRegester.Size = new System.Drawing.Size(109, 56);
            this.buttonRegester.TabIndex = 12;
            this.buttonRegester.Text = "登録";
            this.buttonRegester.UseVisualStyleBackColor = true;
            this.buttonRegester.Click += new System.EventHandler(this.buttonRegester_Click);
            // 
            // priceCompareSystemDataSet
            // 
            this.priceCompareSystemDataSet.DataSetName = "PriceCompareSystemDataSet";
            this.priceCompareSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // priceCompareSystemDataSetBindingSource
            // 
            this.priceCompareSystemDataSetBindingSource.DataSource = this.priceCompareSystemDataSet;
            this.priceCompareSystemDataSetBindingSource.Position = 0;
            // 
            // prefectureTableAdapter
            // 
            this.prefectureTableAdapter.ClearBeforeFill = true;
            // 
            // priceCompareSystemDataSet2
            // 
            this.priceCompareSystemDataSet2.DataSetName = "PriceCompareSystemDataSet2";
            this.priceCompareSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prefectureBindingSource1
            // 
            this.prefectureBindingSource1.DataMember = "Prefecture";
            this.prefectureBindingSource1.DataSource = this.priceCompareSystemDataSet2;
            // 
            // prefectureTableAdapter1
            // 
            this.prefectureTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(153, 453);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersVisible = false;
            this.dataGridViewDsp.RowHeadersWidth = 62;
            this.dataGridViewDsp.RowTemplate.Height = 27;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1028, 413);
            this.dataGridViewDsp.TabIndex = 15;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            // 
            // labelPW
            // 
            this.labelPW.AutoSize = true;
            this.labelPW.Location = new System.Drawing.Point(518, 315);
            this.labelPW.Name = "labelPW";
            this.labelPW.Size = new System.Drawing.Size(79, 18);
            this.labelPW.TabIndex = 16;
            this.labelPW.Text = "パスワード";
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.Location = new System.Drawing.Point(624, 315);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.Size = new System.Drawing.Size(225, 25);
            this.textBoxPassWord.TabIndex = 17;
            // 
            // labelStID
            // 
            this.labelStID.AutoSize = true;
            this.labelStID.Location = new System.Drawing.Point(246, 107);
            this.labelStID.Name = "labelStID";
            this.labelStID.Size = new System.Drawing.Size(0, 18);
            this.labelStID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "地域";
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
            this.comboBoxRegion.Location = new System.Drawing.Point(249, 207);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(121, 26);
            this.comboBoxRegion.TabIndex = 34;
            this.comboBoxRegion.SelectionChangeCommitted += new System.EventHandler(this.comboBoxRegion_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(168, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 52);
            this.label2.TabIndex = 36;
            this.label2.Text = "店舗管理";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-24, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 100);
            this.panel1.TabIndex = 37;
            // 
            // F_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 1042);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRegion);
            this.Controls.Add(this.labelStID);
            this.Controls.Add(this.textBoxPassWord);
            this.Controls.Add(this.labelPW);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRegester);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.comboBoxPrefectures);
            this.Controls.Add(this.labelPrefectures);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxStName);
            this.Controls.Add(this.labelStName);
            this.Controls.Add(this.labelStIDtitle);
            this.Name = "F_Store";
            this.Text = "店舗管理";
            this.Load += new System.EventHandler(this.F_Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prefectureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCompareSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCompareSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCompareSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCompareSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prefectureBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStIDtitle;
        private System.Windows.Forms.TextBox textBoxStName;
        private System.Windows.Forms.Label labelStName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPrefectures;
        private System.Windows.Forms.ComboBox comboBoxPrefectures;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRegester;
        private PriceCompareSystemDataSet priceCompareSystemDataSet;
        private System.Windows.Forms.BindingSource priceCompareSystemDataSetBindingSource;
        private PriceCompareSystemDataSet1 priceCompareSystemDataSet1;
        private System.Windows.Forms.BindingSource prefectureBindingSource;
        private PriceCompareSystemDataSet1TableAdapters.PrefectureTableAdapter prefectureTableAdapter;
        private PriceCompareSystemDataSet2 priceCompareSystemDataSet2;
        private System.Windows.Forms.BindingSource prefectureBindingSource1;
        private PriceCompareSystemDataSet2TableAdapters.PrefectureTableAdapter prefectureTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.Label labelPW;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.Label labelStID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}