using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ExcelCopy
{
    public partial class Form1 : Form
    {
        functions functions;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int w = this.Size.Width;
            //int h = this.Size.Height;
            functions = new functions();
            dt = new DataTable();  
            
            int sizew = 12;
            int sizeh = 20;

            for (int i = 0; i < sizew; i++)
            {
                string s = Char.ConvertFromUtf32(i + 65);
                dt.Columns.Add(s);
            }

            for (int i = 0; i < sizeh; i++)
            {
                dt.Rows.Add();
            }

            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.DataSource = dt;
            dataGrid.RowHeadersWidth = dataGrid.RowHeadersWidth + (25);

            for (int i = 0; i < sizeh; i++)
            {
                dataGrid.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }           

        private void calcBtn_Click(object sender, EventArgs e)
        {    
                     
            try
            {
                dataGrid.Rows[functions.DoFunc(function.Text, Trenutna_celija()).Item3].Cells[functions.DoFunc(function.Text, Trenutna_celija()).Item2].Value = functions.DoFunc(function.Text, Trenutna_celija()).Item1;
                function.Text = "";
                //ConnectionTo();
            }
            catch
            {
                function.Text = "Error.";
            }
      
        }

       private Tuple<int, int> Trenutna_celija()
        {
            return Tuple.Create(dataGrid.CurrentCell.ColumnIndex, dataGrid.CurrentCell.RowIndex);
        }

        private void ConnectionFrom()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 12; j++)
                {

                    functions.matrica[i, j] = dataGrid.Rows[i].Cells[j].Value.ToString();
                    
                }
            }
        }
      
       private void ConnectionTo()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    dataGrid.Rows[i].Cells[j].Value = functions.matrica[i, j];
                    dataGrid.Update();
                }
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {

            try
            {
                StreamWriter writer = new StreamWriter("D:/Programiranje/C#/PSC-Excel/File.txt");
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        writer.Write(functions.matrica[i, j]);
                        writer.Write(",");
                    }
                    writer.WriteLine();
                }
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error while saving to file");
            }
            

        }

        private void dataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ConnectionFrom();
        }
    }
}
