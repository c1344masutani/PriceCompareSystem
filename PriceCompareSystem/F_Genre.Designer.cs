namespace PriceCompareSystem
{
    partial class F_Genre
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRegester = new System.Windows.Forms.Button();
            this.labelGeIDtitle = new System.Windows.Forms.Label();
            this.textBoxGeName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.comboBoxMajorGenre = new System.Windows.Forms.ComboBox();
            this.buttonMajorGenre = new System.Windows.Forms.Button();
            this.labelMajorGenre = new System.Windows.Forms.Label();
            this.labelGeID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(808, 301);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 56);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(630, 301);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(109, 56);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "更新";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRegester
            // 
            this.buttonRegester.Location = new System.Drawing.Point(445, 301);
            this.buttonRegester.Name = "buttonRegester";
            this.buttonRegester.Size = new System.Drawing.Size(109, 56);
            this.buttonRegester.TabIndex = 15;
            this.buttonRegester.Text = "登録";
            this.buttonRegester.UseVisualStyleBackColor = true;
            this.buttonRegester.Click += new System.EventHandler(this.buttonRegester_Click);
            // 
            // labelGeIDtitle
            // 
            this.labelGeIDtitle.AutoSize = true;
            this.labelGeIDtitle.Location = new System.Drawing.Point(286, 162);
            this.labelGeIDtitle.Name = "labelGeIDtitle";
            this.labelGeIDtitle.Size = new System.Drawing.Size(79, 18);
            this.labelGeIDtitle.TabIndex = 18;
            this.labelGeIDtitle.Text = "ジャンルID";
            // 
            // textBoxGeName
            // 
            this.textBoxGeName.Location = new System.Drawing.Point(402, 250);
            this.textBoxGeName.Name = "textBoxGeName";
            this.textBoxGeName.Size = new System.Drawing.Size(225, 25);
            this.textBoxGeName.TabIndex = 21;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(286, 257);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(81, 18);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "ジャンル名";
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.AllowUserToAddRows = false;
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(155, 379);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersVisible = false;
            this.dataGridViewDsp.RowHeadersWidth = 62;
            this.dataGridViewDsp.RowTemplate.Height = 27;
            this.dataGridViewDsp.Size = new System.Drawing.Size(971, 438);
            this.dataGridViewDsp.TabIndex = 22;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            // 
            // comboBoxMajorGenre
            // 
            this.comboBoxMajorGenre.FormattingEnabled = true;
            this.comboBoxMajorGenre.Location = new System.Drawing.Point(402, 206);
            this.comboBoxMajorGenre.Name = "comboBoxMajorGenre";
            this.comboBoxMajorGenre.Size = new System.Drawing.Size(121, 26);
            this.comboBoxMajorGenre.TabIndex = 23;
            // 
            // buttonMajorGenre
            // 
            this.buttonMajorGenre.Location = new System.Drawing.Point(541, 183);
            this.buttonMajorGenre.Name = "buttonMajorGenre";
            this.buttonMajorGenre.Size = new System.Drawing.Size(86, 49);
            this.buttonMajorGenre.TabIndex = 24;
            this.buttonMajorGenre.Text = "大ｼﾞｬﾝﾙ管理";
            this.buttonMajorGenre.UseVisualStyleBackColor = true;
            this.buttonMajorGenre.Click += new System.EventHandler(this.buttonMajorGenre_Click);
            // 
            // labelMajorGenre
            // 
            this.labelMajorGenre.AutoSize = true;
            this.labelMajorGenre.Location = new System.Drawing.Point(284, 209);
            this.labelMajorGenre.Name = "labelMajorGenre";
            this.labelMajorGenre.Size = new System.Drawing.Size(81, 18);
            this.labelMajorGenre.TabIndex = 25;
            this.labelMajorGenre.Text = "大ジャンル";
            // 
            // labelGeID
            // 
            this.labelGeID.AutoSize = true;
            this.labelGeID.Location = new System.Drawing.Point(402, 161);
            this.labelGeID.Name = "labelGeID";
            this.labelGeID.Size = new System.Drawing.Size(0, 18);
            this.labelGeID.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 52);
            this.label2.TabIndex = 36;
            this.label2.Text = "ジャンル管理";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 100);
            this.panel1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 820);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 39;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(144, 161);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(105, 54);
            this.buttonClear.TabIndex = 41;
            this.buttonClear.Text = "入力クリア";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonMenu.Location = new System.Drawing.Point(30, 162);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(81, 53);
            this.buttonMenu.TabIndex = 42;
            this.buttonMenu.Text = "メニュー";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // F_Genre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1262, 853);
            this.ControlBox = false;
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelGeID);
            this.Controls.Add(this.labelMajorGenre);
            this.Controls.Add(this.buttonMajorGenre);
            this.Controls.Add(this.comboBoxMajorGenre);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.textBoxGeName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelGeIDtitle);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRegester);
            this.Name = "F_Genre";
            this.Text = "ジャンル管理";
            this.Load += new System.EventHandler(this.F_Genre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRegester;
        private System.Windows.Forms.Label labelGeIDtitle;
        private System.Windows.Forms.TextBox textBoxGeName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.ComboBox comboBoxMajorGenre;
        private System.Windows.Forms.Button buttonMajorGenre;
        private System.Windows.Forms.Label labelMajorGenre;
        private System.Windows.Forms.Label labelGeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonMenu;
    }
}