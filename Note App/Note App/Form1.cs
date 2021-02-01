using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Note_App
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable(tableName:"solutions");
            
            if (File.Exists("saved.xml"))
            {

                table.ReadXml("saved.xml");
            }
            else 
            {
                table.Columns.Add("Title", typeof(String));
                table.Columns.Add("Description", typeof(String));
                table.Columns.Add("Solution", typeof(String));
            }
          

            solutionList.DataSource = table;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            titleTxt.Clear();
            desTxt.Clear();
            solTxt.Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            table.Rows.Add(titleTxt.Text, desTxt.Text, solTxt.Text);
            titleTxt.Clear();
            desTxt.Clear();
            solTxt.Clear();
        }

        private void solutionList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           try 
            {
                titleTxt.Text = solutionList.Rows[e.RowIndex].Cells[0].Value.ToString();
                desTxt.Text = solutionList.Rows[e.RowIndex].Cells[1].Value.ToString();
                solTxt.Text = solutionList.Rows[e.RowIndex].Cells[2].Value.ToString();
               
            }
            catch(ArgumentOutOfRangeException a)
            {
                //can just ignore this error
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            table.WriteXml("saved.xml", XmlWriteMode.WriteSchema);
        }
    }
}
