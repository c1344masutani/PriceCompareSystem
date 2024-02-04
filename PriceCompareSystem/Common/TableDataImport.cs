using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PriceCompareSystem
{
    class TableDataImport
    {
        public void DataImport(string strTbl)
        {
            try
            {
                var context = new PriceCompareSystemContext();
                //データが存在していなけばデータをインポート
                int cnt = context.Database.SqlQuery<int>("SELECT count(*) FROM [dbo].[" + strTbl + "]").First();
                context.Dispose();
                if (cnt > 0)
                    return;

                //インポートするCSVファイルの指定
                string csvpth = System.Environment.CurrentDirectory + "\\" + strTbl + ".csv";
                //データテーブルの設定
                DataTable dt = new DataTable();
                dt.TableName = strTbl;

                //csvファイルの内容をDataTableへ
                //csvファイル及び、デリミタの指定
                var parser = new Microsoft.VisualBasic.FileIO.TextFieldParser(csvpth, Encoding.GetEncoding("Shift-JIS"))
                {
                    TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited,
                    Delimiters = new string[] { "," }
                };

                // 全行読み込み
                var rows = new List<string[]>();
                while (!parser.EndOfData)
                {
                    rows.Add(parser.ReadFields());
                }
                // 列設定
                dt.Columns.AddRange(rows.First().Select(s => new DataColumn(s)).ToArray());

                // 行追加
                foreach (var row in rows.Skip(1))
                {
                    dt.Rows.Add(row);
                }

                //DB接続情報の取得
                var dbpth = System.Configuration.ConfigurationManager.ConnectionStrings["PriceCompareSystemContext"].ConnectionString;
                //DataTableの内容をDBへ追加
                using (var bulkCopy = new SqlBulkCopy(dbpth))
                {
                    bulkCopy.DestinationTableName = dt.TableName;
                    bulkCopy.WriteToServer(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
