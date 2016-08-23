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
using System.Collections;

namespace excel1
{
    public partial class Form1 : Form
    {
        private string tableName = "Table1";
        private OleDbConnection conn = null;
        private OleDbDataAdapter myCommand = null;
        private DataSet dataset;
        private DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void readExcel_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName.ToString();
                info.Text = path;
                ExcelToDS(path);
                dataset = GetDataSet();

                if (dataset == null) return;
                table = dataset.Tables[dataset.Tables.Count - 1];
                //table.PrimaryKey = new DataColumn[] { table.Columns[1], table.Columns[2] };
                tableName = table.TableName;


                int productNameBoxIndex = 1;
                setComboBox(productNameBoxIndex, productNameBox);

                int dueboxIndex = 10;
                setComboBox(dueboxIndex, duebox);

                int tagBoxIndex = 4;
                setComboBox(tagBoxIndex, tagBox);
                int interest1BoxIndex = 9;
                int interest2BoxIndex = 13;
                int interest3BoxIndex = 14;
                setComboBox(interest1BoxIndex, interest1Box);
                setComboBox(interest2BoxIndex, interest2Box);
                setComboBox(interest3BoxIndex, interest3Box);

            }
        }

        private void setComboBox(int column, ComboBox box) {
            int count = table.Rows.Count;
            if (table.Columns.Count <= column) return;
            ArrayList array = new ArrayList();
            for (int i = 0; i < count; i++) {
                object temp = table.Rows[i][column];
                if (!array.Contains(temp)) {
                    array.Add(temp);
                    box.Items.Add(temp);
                }
            }
        }
        private void writeToExcelClick(object sender, EventArgs e)
        {
            info.Text = "succedd";
            DSToExcel1();
        }

        //TODO read
        private void ExcelToDS(string path)
        {

            string strConn = CheckExcelFormat(path);
            if (strConn.Length < 1) return;
            conn = new OleDbConnection(strConn);
            conn.Open();
            string strExcel = "select * from [sheet1$]";
            myCommand = new OleDbDataAdapter(strExcel, strConn);
        }


        private String CheckExcelFormat(String pathName)
        {
            if (pathName.EndsWith("xlsx"))
            {
                return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 12.0;HDR = yes'";
            }
            else if (pathName.EndsWith("xls"))
            {
                return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR = yes'";
            }
            return "";
        }

        private DataSet GetDataSet() {
            DataSet ds = new DataSet();
            myCommand.Fill(ds,tableName);
            return ds;
        }
        // TODO write

        public void DSToExcel1()
        {
            int rowcount = table.Rows.Count;
            int i = rowcount;
            //for (; i < rowcount; i++) {
            //    if (table.Rows[i][1].Equals("")) {
            //        int count = orderColumnBox.Checked ? 1 : 0;
            //        table.Rows[i][count++] = productNameBox.Text;
            //        table.Rows[i][count++] = numberbox.Text;
            //        table.Rows[i][count++] = bankNameBox.Text;
            //        table.Rows[i][count++] = tagBox.Text;
            //        table.Rows[i][count++] = startTimer.Text;
            //        table.Rows[i][count++] = endTimer.Text;
            //        table.Rows[i][count++] = moneyBox.Text;
            //        table.Rows[i][count++] = rateBox.Text + "";
            //        table.Rows[i][count++] = interest1Box.Text;
            //        table.Rows[i][count++] = duebox.Text;
            //        table.Rows[i][count++] = manageFeeBox.Text + "";
            //        table.Rows[i][count++] = interFeeBox.Text + "";
            //        table.Rows[i][count++] = interest2Box.Text;
            //        table.Rows[i][count++] = interest3Box.Text;
            //        table.Rows[i][count++] = letterNoBox.Text;
            //        table.Rows[i][count++] = letterPlaceBox.Text;
            //        table.Rows[i][count++] = checkBox1.Checked ? "1" : "0";
            //        table.Rows[i][count++] = checkBox2.Checked ? "1" : "0";
            //        table.Rows[i][count++] = checkBox3.Checked ? "1" : "0";
            //        table.Rows[i][count++] = checkBox4.Checked ? "1" : "0";
            //        table.Rows[i][count++] = stampCardBox.Text;
            //        table.Rows[i][count++] = stampPlaceBox.Text;
            //        table.Rows[i][count++] = accountBox.Text;
            //        table.Rows[i][count++] = paper1Box.Text;
            //        if (paper2Box.Text.Trim() != "")
            //        {
            //            table.Rows[i][count - 1] += "\r\n" + paper2Box.Text;
            //        }
            //        break;
            //    }
            //}
            dataset.Tables[tableName].PrimaryKey = new DataColumn[] { table.Columns[1], table.Columns[2] };
            if (i == rowcount)
            {
                DataRow nrow = setDataRow(dataset.Tables[tableName].NewRow());
                try { dataset.Tables[tableName].Rows.Add(nrow); } catch (System.Data.ConstraintException e) {
                    info.Text = "cannot insert same data";
                    conn.Close();
                }
                
            }
            OleDbCommandBuilder builder = new OleDbCommandBuilder(myCommand);
            //QuotePrefix和QuoteSuffix主要是对builder生成InsertComment命令时使用。 
            builder.QuotePrefix = "[";     //获取insert语句中保留字符（起始位置） 
            builder.QuoteSuffix = "]"; //获取insert语句中保留字符（结束位置） 
            myCommand.Update(dataset, tableName);
            conn.Close();
        }
        public void DSToExcel2()
        {
            int rowcount = table.Rows.Count;
            int i = 0;
            info.Text = "count" + i;
            List<DataRow> removelist = new List<DataRow>();
            bool inserted = false;
            for (; i < rowcount; i++)
            {
                if (string.IsNullOrEmpty(table.Rows[i][1].ToString().Trim()))
                {
                    if (inserted)
                    {
                        removelist.Add(table.Rows[i]);
                    }
                    else { 
                        info.Text = table.Rows[i][1] + "break" + i;
                        table.Rows[i][1] = "succeed" + i;
                        table.Rows[i][2] =  i;
                        table.Rows[i][0] = i;
                        inserted = true;
                    }
                }
            }
            if (!inserted)
            {
                info.Text = table.Rows[i-1][1]+"---return "+i;
                DataRow nrow = dataset.Tables[tableName].NewRow();
                nrow[1] = "succeed";
                nrow[0] = 1;
                nrow[2] = 1;
                dataset.Tables[tableName].Rows.Add(nrow);
            }
            for (int j = 0; j < removelist.Count; j++)
            {
                table.Rows.Remove(removelist[j]);
            }
            OleDbCommandBuilder builder = new OleDbCommandBuilder(myCommand);
            //QuotePrefix和QuoteSuffix主要是对builder生成InsertComment命令时使用。 
            dataset.Tables[tableName].PrimaryKey = new DataColumn[] { table.Columns[1], table.Columns[2] };
            builder.QuotePrefix = "[";     //获取insert语句中保留字符（起始位置） 
            builder.QuoteSuffix = "]"; //获取insert语句中保留字符（结束位置） 
            myCommand.Update(dataset, tableName);
            conn.Close();
        }

        private DataRow setDataRow(DataRow nrow)
        {
            int count = orderColumnBox.Checked ? 1:0;
            nrow[count++] = productNameBox.Text;
            nrow[count++] = numberbox.Text;
            nrow[count++] = bankNameBox.Text;
            nrow[count++] = tagBox.Text;
            nrow[count++] = startTimer.Text;
            nrow[count++] = endTimer.Text;
            nrow[count++] = moneyBox.Text;
            nrow[count++] = rateBox.Text + "%";
            nrow[count++] = interest1Box.Text;
            nrow[count++] = duebox.Text;
            nrow[count++] = manageFeeBox.Text + "%";
            nrow[count++] = interFeeBox.Text + "%";
            nrow[count++] = interest2Box.Text;
            nrow[count++] = interest3Box.Text;
            nrow[count++] = letterNoBox.Text;
            nrow[count++] = letterPlaceBox.Text;
            nrow[count++] = checkBox1.Checked ? "1":"0";
            nrow[count++] = checkBox2.Checked ? "1" : "0";
            nrow[count++] = checkBox3.Checked ? "1" : "0";
            nrow[count++] = checkBox4.Checked ? "1" : "0";
            nrow[count++] = stampCardBox.Text;
            nrow[count++] = stampPlaceBox.Text;
            nrow[count++] = accountBox.Text;
            nrow[count++] = paper1Box.Text;
            if (paper2Box.Text.Trim() != "") {
                nrow[count - 1] += "\r\n" + paper2Box.Text;
            }
            
            return nrow;
        }

        private void stampPlaceBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowcount = table.Rows.Count;
            int i = 0;
            bool found = false;
            for (; i < rowcount; i++)
            {
                if (table.Rows[i][1].ToString().Equals(productNameBox.Text))
                {
                    if (table.Rows[i][2].ToString().Equals(numberbox.Text))
                    {
                        listAll(table.Rows[i]);
                        info.Text = "succeed found in line: " + ++i;
                        found = true;
                        break;
                    }
                
                }
            }
            if(!found) info.Text = "no search result"+ rowcount;
        }

        private void listAll(DataRow nrow) {
            int count = orderColumnBox.Checked ? 1 : 0;
            count++;
            count++;
            bankNameBox.Text = nrow[count++].ToString();
            tagBox.Text = nrow[count++].ToString();
            startTimer.Text = nrow[count++].ToString();
            endTimer.Text = nrow[count++].ToString();
            moneyBox.Text = nrow[count++].ToString();
            rateBox.Text = nrow[count++].ToString(); // 
            interest1Box.Text = nrow[count++].ToString();
            duebox.Text = nrow[count++].ToString();
            manageFeeBox.Text = nrow[count++].ToString(); //
            interFeeBox.Text = nrow[count++].ToString(); //
            interest2Box.Text = nrow[count++].ToString();
            interest3Box.Text = nrow[count++].ToString();
            letterNoBox.Text = nrow[count++].ToString();
            letterPlaceBox.Text = nrow[count++].ToString();
            if (nrow[count].ToString().Equals("1")) { 
            checkBox1.CheckState = CheckState.Checked;
            } if (nrow[count++].ToString().Equals("0"))
            {
                checkBox1.CheckState = CheckState.Unchecked;
            }
            if (nrow[count].ToString().Equals("1"))
            {
                checkBox2.CheckState = CheckState.Checked;
            }
             if (nrow[count++].ToString().Equals("0"))
            {
                checkBox2.CheckState = CheckState.Unchecked;
            }
            if (nrow[count].ToString().Equals("1"))
            {
                checkBox3.CheckState = CheckState.Checked;
            }
             if (nrow[count++].ToString().Equals("0"))
            {
                checkBox3.CheckState = CheckState.Unchecked;
            }
            if (nrow[count].ToString().Equals("1"))
            {
                checkBox4.CheckState = CheckState.Checked;
            }
             if (nrow[count++].ToString().Equals("0"))
            {
                checkBox4.CheckState = CheckState.Unchecked;
            }
            stampCardBox.Text = nrow[count++].ToString() ;
            stampPlaceBox.Text = nrow[count++].ToString();
            accountBox.Text = nrow[count++].ToString() ;
            string[] str = nrow[count].ToString().Split(new string[] { "\r\n" }, 2, StringSplitOptions.RemoveEmptyEntries);
            paper1Box.Text = str[0];
            if(str.Length > 1)paper2Box.Text =str[1] ;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //public void DSToExcel(string Path, DataSet oldds)
        //{
        //    //先得到汇总EXCEL的DataSet 主要目的是获得EXCEL在DataSet中的结构 
        //    string strCon = CheckExcelFormat(Path);
        //    OleDbConnection myConn = new OleDbConnection(strCon);
        //    string strCom = "select * from [Sheet1$]";
        //    myConn.Open();
        //    OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
        //    OleDbCommandBuilder builder = new OleDbCommandBuilder(myCommand);
        //    //QuotePrefix和QuoteSuffix主要是对builder生成InsertComment命令时使用。 
        //    builder.QuotePrefix = "[";     //获取insert语句中保留字符（起始位置） 
        //    builder.QuoteSuffix = "]"; //获取insert语句中保留字符（结束位置） 
        //    DataSet newds = new DataSet();
        //    myCommand.Fill(newds, "Table1");
        //    for (int i = 0; i < oldds.Tables[0].Rows.Count; i++)
        //    {
        //        //在这里不能使用ImportRow方法将一行导入到news中，因为ImportRow将保留原来DataRow的所有设置(DataRowState状态不变)。
        //        //在使用ImportRow后newds内有值，但不能更新到Excel中因为所有导入行的DataRowState != Added
        //        //DataRow nrow = aDataSet.Tables["Table1"].NewRow();
        //        DataRow nrow = newds.Tables["Table1"].NewRow();
        //        for (int j = 0; j < newds.Tables[0].Columns.Count; j++)
        //        {
        //            nrow[j] = oldds.Tables[0].Rows[i][j];
        //        }
        //        newds.Tables["Table1"].Rows.Add(nrow);
        //    }
        //    myCommand.Update(newds, "Table1");
        //    myConn.Close();
        //}
    }
}
