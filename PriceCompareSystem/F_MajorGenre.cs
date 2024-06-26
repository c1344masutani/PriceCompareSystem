﻿using PriceCompareSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCompareSystem
{
    public partial class F_MajorGenre : Form
    {
        public F_MajorGenre()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new PriceCompareSystemContext();
                foreach (var p in context.M_MajorGenres)
                {
                    dataGridViewDsp.Rows.Add(p.MgID,p.MgName);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AllClear()
        {
            labelMgID.Text = "";
            textBoxMgName.Text = "";
        }

        private void F_MajorGenre_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 2;

            dataGridViewDsp.Columns[0].Width = 70;
            dataGridViewDsp.Columns[0].HeaderText = "大ジャンルID";
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[1].HeaderText = "大ジャンル名";
            //選択モードを行単位
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //読み取り専用
            dataGridViewDsp.ReadOnly = true;
            //全データ表示
            fncAllSelect();
        }

        private void buttonRegester_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxMgName.Text.Trim()))
            {
                MessageBox.Show("大ジャンル名を入力してください");
                return;
            }
            else if (textBoxMgName.TextLength > 50)
            {
                MessageBox.Show("大ジャンル名は50文字以内です");
                return;
            }

            var majorgenre = new M_MajorGenres
            {
                MgName = textBoxMgName.Text.Trim()
            };

            var context = new PriceCompareSystemContext();
            int count = context.M_MajorGenres.Where(x => x.MgName == textBoxMgName.Text).Count();
            if (count >= 1)
            {
                MessageBox.Show("入力された大ジャンル名は既に使用されています");
                return;
            }

            try
            {
                DialogResult result = MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                context.M_MajorGenres.Add(majorgenre);
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                AllClear();
                MessageBox.Show("登録完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(labelMgID.Text.Trim()))
            {
                MessageBox.Show("更新したい項目を選択してください");
                return;
            }
            if (String.IsNullOrEmpty(textBoxMgName.Text.Trim()))
            {
                MessageBox.Show("大ジャンル名を入力してください");
                return;
            }
            else if (textBoxMgName.TextLength > 50)
            {
                MessageBox.Show("大ジャンル名は50文字以内です");
                return;
            }

            var context = new PriceCompareSystemContext();

            try
            {
                DialogResult result = MessageBox.Show("更新してもよろしいですか？", "更新確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                int mgid = int.Parse(labelMgID.Text.Trim());
                var majorgenre = context.M_MajorGenres.Single(x => x.MgID == mgid);
                majorgenre.MgName = textBoxMgName.Text.Trim();
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                AllClear();
                MessageBox.Show("更新完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(labelMgID.Text.Trim()))
            {
                MessageBox.Show("削除したい項目を選択してください");
                return;
            }
            try
            {
                DialogResult result = MessageBox.Show("削除してもよろしいですか？", "削除確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                int mgid = int.Parse(labelMgID.Text.Trim());
                var context = new PriceCompareSystemContext();
                var majorgenre = context.M_MajorGenres.Single(x => x.MgID == mgid);
                context.M_MajorGenres.Remove(majorgenre);
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                AllClear() ;
                MessageBox.Show("削除完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelMgID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxMgName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            F_Genre f_Genre = new F_Genre();
            f_Genre.ShowDialog();
            f_Genre.Dispose();
        }
    }
}
