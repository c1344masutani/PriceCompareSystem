﻿namespace PriceCompareSystem
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(526, 197);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 56);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(383, 197);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(109, 56);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "更新";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRegester
            // 
            this.buttonRegester.Location = new System.Drawing.Point(236, 197);
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
            this.labelGeIDtitle.Location = new System.Drawing.Point(90, 66);
            this.labelGeIDtitle.Name = "labelGeIDtitle";
            this.labelGeIDtitle.Size = new System.Drawing.Size(79, 18);
            this.labelGeIDtitle.TabIndex = 18;
            this.labelGeIDtitle.Text = "ジャンルID";
            // 
            // textBoxGeName
            // 
            this.textBoxGeName.Location = new System.Drawing.Point(206, 153);
            this.textBoxGeName.Name = "textBoxGeName";
            this.textBoxGeName.Size = new System.Drawing.Size(171, 25);
            this.textBoxGeName.TabIndex = 21;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(90, 161);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(81, 18);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "ジャンル名";
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(93, 282);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 62;
            this.dataGridViewDsp.RowTemplate.Height = 27;
            this.dataGridViewDsp.Size = new System.Drawing.Size(971, 593);
            this.dataGridViewDsp.TabIndex = 22;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            // 
            // comboBoxMajorGenre
            // 
            this.comboBoxMajorGenre.FormattingEnabled = true;
            this.comboBoxMajorGenre.Location = new System.Drawing.Point(206, 110);
            this.comboBoxMajorGenre.Name = "comboBoxMajorGenre";
            this.comboBoxMajorGenre.Size = new System.Drawing.Size(121, 26);
            this.comboBoxMajorGenre.TabIndex = 23;
            // 
            // buttonMajorGenre
            // 
            this.buttonMajorGenre.Location = new System.Drawing.Point(345, 87);
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
            this.labelMajorGenre.Location = new System.Drawing.Point(88, 113);
            this.labelMajorGenre.Name = "labelMajorGenre";
            this.labelMajorGenre.Size = new System.Drawing.Size(81, 18);
            this.labelMajorGenre.TabIndex = 25;
            this.labelMajorGenre.Text = "大ジャンル";
            // 
            // labelGeID
            // 
            this.labelGeID.AutoSize = true;
            this.labelGeID.Location = new System.Drawing.Point(206, 65);
            this.labelGeID.Name = "labelGeID";
            this.labelGeID.Size = new System.Drawing.Size(0, 18);
            this.labelGeID.TabIndex = 26;
            // 
            // F_Genre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
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
    }
}