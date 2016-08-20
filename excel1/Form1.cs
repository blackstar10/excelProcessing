using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace excel1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readExcel_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName.ToString();
                label1.Text =  path;
                DataSet ds = ExcelToDS(path);
                if (ds == null) return;
                DataColumn mykey = ds.Tables[0].Columns[0];
                int count = ds.Tables[0].Rows.Count;
                label1.Text = "count " + count;
            }
        }
        private void writeToExcelClick(object sender, EventArgs e)
        {
            label1.Text = "excel";
        }

        private DataSet ExcelToDS(string path) {
            
            string strConn = CheckExcelFormat(path);
            if (strConn.Length < 1) return null;
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string strExcel = "";
            OleDbDataAdapter myCommand = null;
            DataSet ds = null;
            strExcel = "select * from [sheet1$]";
            myCommand = new OleDbDataAdapter(strExcel, strConn);
            ds = new DataSet();
            myCommand.Fill(ds, "table1");
            return ds;
        }

        private String CheckExcelFormat(String pathName) {
            if (pathName.EndsWith("xlsx"))
            {
                return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
            }
            else if (pathName.EndsWith("xls"))
            {
                return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
            }
            return "";
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
