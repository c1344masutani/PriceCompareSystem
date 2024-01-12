namespace PriceCompareSystem
{
    partial class F_Maker
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
            this.labelMaName = new System.Windows.Forms.Label();
            this.textBoxMaName = new System.Windows.Forms.TextBox();
            this.textBoxMaAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonRegester = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.labelMaIDtitle = new System.Windows.Forms.Label();
            this.labelMaID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMaName
            // 
            this.labelMaName.AutoSize = true;
            this.labelMaName.Location = new System.Drawing.Point(51, 84);
            this.labelMaName.Name = "labelMaName";
            this.labelMaName.Size = new System.Drawing.Size(81, 18);
            this.labelMaName.TabIndex = 0;
            this.labelMaName.Text = "メーカー名";
            // 
            // textBoxMaName
            // 
            this.textBoxMaName.Location = new System.Drawing.Point(161, 77);
            this.textBoxMaName.Name = "textBoxMaName";
            this.textBoxMaName.Size = new System.Drawing.Size(168, 25);
            this.textBoxMaName.TabIndex = 1;
            // 
            // textBoxMaAddress
            // 
            this.textBoxMaAddress.Location = new System.Drawing.Point(161, 112);
            this.textBoxMaAddress.Name = "textBoxMaAddress";
            this.textBoxMaAddress.Size = new System.Drawing.Size(168, 25);
            this.textBoxMaAddress.TabIndex = 2;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(49, 119);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(44, 18);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "住所";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(52, 173);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(80, 18);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "電話番号";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(161, 165);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(168, 25);
            this.textBoxPhone.TabIndex = 5;
            // 
            // buttonRegester
            // 
            this.buttonRegester.Location = new System.Drawing.Point(138, 240);
            this.buttonRegester.Name = "buttonRegester";
            this.buttonRegester.Size = new System.Drawing.Size(94, 44);
            this.buttonRegester.TabIndex = 6;
            this.buttonRegester.Text = "登録";
            this.buttonRegester.UseVisualStyleBackColor = true;
            this.buttonRegester.Click += new System.EventHandler(this.buttonRegester_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(304, 240);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(102, 44);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "更新";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(473, 240);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 44);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(21, 322);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 62;
            this.dataGridViewDsp.RowTemplate.Height = 27;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1058, 713);
            this.dataGridViewDsp.TabIndex = 10;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            // 
            // labelMaIDtitle
            // 
            this.labelMaIDtitle.AutoSize = true;
            this.labelMaIDtitle.Location = new System.Drawing.Point(49, 40);
            this.labelMaIDtitle.Name = "labelMaIDtitle";
            this.labelMaIDtitle.Size = new System.Drawing.Size(79, 18);
            this.labelMaIDtitle.TabIndex = 11;
            this.labelMaIDtitle.Text = "メーカーID";
            // 
            // labelMaID
            // 
            this.labelMaID.AutoSize = true;
            this.labelMaID.Location = new System.Drawing.Point(158, 40);
            this.labelMaID.Name = "labelMaID";
            this.labelMaID.Size = new System.Drawing.Size(0, 18);
            this.labelMaID.TabIndex = 12;
            // 
            // F_Maker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 964);
            this.Controls.Add(this.labelMaID);
            this.Controls.Add(this.labelMaIDtitle);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRegester);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxMaAddress);
            this.Controls.Add(this.textBoxMaName);
            this.Controls.Add(this.labelMaName);
            this.Name = "F_Maker";
            this.Text = "メーカー管理";
            this.Load += new System.EventHandler(this.F_Maker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaName;
        private System.Windows.Forms.TextBox textBoxMaName;
        private System.Windows.Forms.TextBox textBoxMaAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonRegester;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.Label labelMaIDtitle;
        private System.Windows.Forms.Label labelMaID;
    }
}