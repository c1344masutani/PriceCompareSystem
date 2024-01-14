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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMgIDtitle
            // 
            this.labelMgIDtitle.AutoSize = true;
            this.labelMgIDtitle.Location = new System.Drawing.Point(37, 115);
            this.labelMgIDtitle.Name = "labelMgIDtitle";
            this.labelMgIDtitle.Size = new System.Drawing.Size(97, 18);
            this.labelMgIDtitle.TabIndex = 20;
            this.labelMgIDtitle.Text = "大ジャンルID";
            // 
            // labelMgName
            // 
            this.labelMgName.AutoSize = true;
            this.labelMgName.Location = new System.Drawing.Point(37, 168);
            this.labelMgName.Name = "labelMgName";
            this.labelMgName.Size = new System.Drawing.Size(99, 18);
            this.labelMgName.TabIndex = 22;
            this.labelMgName.Text = "大ジャンル名";
            // 
            // textBoxMgName
            // 
            this.textBoxMgName.Location = new System.Drawing.Point(153, 160);
            this.textBoxMgName.Name = "textBoxMgName";
            this.textBoxMgName.Size = new System.Drawing.Size(100, 25);
            this.textBoxMgName.TabIndex = 23;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(434, 211);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 56);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(291, 211);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(109, 56);
            this.buttonUpdate.TabIndex = 25;
            this.buttonUpdate.Text = "更新";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRegester
            // 
            this.buttonRegester.Location = new System.Drawing.Point(144, 211);
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
            this.dataGridViewDsp.Location = new System.Drawing.Point(82, 283);
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
            this.labelMgID.Location = new System.Drawing.Point(153, 115);
            this.labelMgID.Name = "labelMgID";
            this.labelMgID.Size = new System.Drawing.Size(0, 18);
            this.labelMgID.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 40);
            this.label2.TabIndex = 36;
            this.label2.Text = "大ジャンル管理";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 70);
            this.panel1.TabIndex = 38;
            // 
            // F_MajorGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}