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
       
            functions = new functions();
            dt = new DataTable();

            const int sizew = 12;
            const int sizeh = 20;

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
                Tuple<string, int, int> a = functions.DoFunc(function.Text, Trenutna_celija());
                dataGrid.Rows[a.Item3].Cells[a.Item2].Value = a.Item1;
                function.Text = "";
                int column = a.Item2;
                int row = a.Item3;
                string polje = ((char)(65 + column)).ToString() + (row + 1).ToString();
                Provera(polje);
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

        private void saveBtn_Click(object sender, EventArgs e)
        {            
            Save s = new Save();
            s.ShowDialog();
            string path = s.a;
            try
            {
                StreamWriter writer = new StreamWriter(path);
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        writer.Write(functions.matrica[i, j]);
                        writer.Write(':');
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

            int column = e.ColumnIndex;
            int row = e.RowIndex;
            functions.matrica[row, column] = dataGrid.Rows[row].Cells[column].Value.ToString();
            string polje = ((char)(65 + column)).ToString() + (row + 1).ToString();
            Provera(polje);
            
        }
        private void Provera(string polje)
        {

            for (int index = 0; index < functions.dict.Count; index++)
            {
                KeyValuePair<string, List<string>> item = functions.dict.ElementAt(index);

                if (functions.dict[item.Key].Contains(polje))
                {
                    string novopolje = item.Key;
                    
                    try
                    {
                        string a = functions.Form1(functions.matrica[Int32.Parse(novopolje[1].ToString()) - 1, (int)novopolje[0] - 65]);
                        dataGrid.Rows[Int32.Parse(novopolje[1].ToString()) - 1].Cells[(int)novopolje[0] - 65].Value = a;
                        
                    }
                    catch
                    {
                        dataGrid.Rows[Int32.Parse(novopolje[1].ToString()) - 1].Cells[(int)novopolje[0] - 65].Value = "Error";
                    }
                    Provera(novopolje);
                }
            }
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Blaa");
            }
            string Rez = form2.a;
            try
            {
                Tuple<string, int, int> a = functions.DoFunc(Rez, Trenutna_celija());
                dataGrid.Rows[a.Item3].Cells[a.Item2].Value = a.Item1;
                function.Text = "";
                int column = a.Item2;
                int row = a.Item3;
                string polje = ((char)(65 + column)).ToString() + (row + 1).ToString();
                Provera(polje);
            }
            catch
            {
                function.Text = "Error.";
            }
        }
    }
}
