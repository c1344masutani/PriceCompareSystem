namespace PriceCompareSystem
{
    partial class F_MajorGenre
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
            this.labelMgIDtitle = new System.Windows.Forms.Label();
            this.labelMgName = new System.Windows.Forms.Label();
            this.textBoxMgName = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRegester = new System.Windows.Forms.Button();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.labelMgID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMgIDtitle
            // 
            this.labelMgIDtitle.AutoSize = true;
            this.labelMgIDtitle.Location = new System.Drawing.Point(32, 36);
            this.labelMgIDtitle.Name = "labelMgIDtitle";
            this.labelMgIDtitle.Size = new System.Drawing.Size(97, 18);
            this.labelMgIDtitle.TabIndex = 20;
            this.labelMgIDtitle.Text = "大ジャンルID";
            // 
            // labelMgName
            // 
            this.labelMgName.AutoSize = true;
            this.labelMgName.Location = new System.Drawing.Point(32, 89);
            this.labelMgName.Name = "labelMgName";
            this.labelMgName.Size = new System.Drawing.Size(99, 18);
            this.labelMgName.TabIndex = 22;
            this.labelMgName.Text = "大ジャンル名";
            // 
            // textBoxMgName
            // 
            this.textBoxMgName.Location = new System.Drawing.Point(148, 81);
            this.textBoxMgName.Name = "textBoxMgName";
            this.textBoxMgName.Size = new System.Drawing.Size(100, 25);
            this.textBoxMgName.TabIndex = 23;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(429, 162);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 56);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(286, 162);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(109, 56);
            this.buttonUpdate.TabIndex = 25;
            this.buttonUpdate.Text = "更新";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRegester
            // 
            this.buttonRegester.Location = new System.Drawing.Point(139, 162);
            this.buttonRegester.Name = "buttonRegester";
            this.buttonRegester.Size = new System.Drawing.Size(109, 56);
            this.buttonRegester.TabIndex = 24;
            this.buttonRegester.Text = "登録";
            this.buttonRegester.UseVisualStyleBackColor = true;
            this.buttonRegester.Click += new System.EventHandler(this.buttonRegester_Click);
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(77, 234);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 62;
            this.dataGridViewDsp.RowTemplate.Height = 27;
            this.dataGridViewDsp.Size = new System.Drawing.Size(578, 279);
            this.dataGridViewDsp.TabIndex = 27;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            // 
            // labelMgID
            // 
            this.labelMgID.AutoSize = true;
            this.labelMgID.Location = new System.Drawing.Point(148, 36);
            this.labelMgID.Name = "labelMgID";
            this.labelMgID.Size = new System.Drawing.Size(0, 18);
            this.labelMgID.TabIndex = 28;
            // 
            // F_MajorGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMgID);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRegester);
            this.Controls.Add(this.textBoxMgName);
            this.Controls.Add(this.labelMgName);
            this.Controls.Add(this.labelMgIDtitle);
            this.Name = "F_MajorGenre";
            this.Text = "大ジャンル管理";
            this.Load += new System.EventHandler(this.F_MajorGenre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMgIDtitle;
        private System.Windows.Forms.Label labelMgName;
        private System.Windows.Forms.TextBox textBoxMgName;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRegester;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.Label labelMgID;
    }
}