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

namespace ExcelCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int w = this.Size.Width;
            //int h = this.Size.Height;

            DataTable dt = new DataTable();
            int sizew = 12;
            int sizeh = 20;
            for(int i = 0; i < sizew; i++)
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
                dataGrid.Rows[i].HeaderCell.Value = (i+1).ToString();
            }
        }   

        private double Sum(double a, double b)
        {
            return a + b;
        }

        private double Mul(double a, double b)
        {
            return a * b;
        }

        private String Calc(String input)
        {
            Stack st = new Stack();
            String buff = "";
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    continue;
                }
                else if ((c == '(') || (c == ','))
                {
                    if (!buff.Equals("")) st.Push(buff);
                    buff = "";
                }
                else if (c == ')')
                {
                    String sec = buff;
                    String frst = st.Pop().ToString();
                    String fun = st.Pop().ToString();
                    if ((int)sec[0] >= 65)
                    {
                        Tuple<int, int> elem = GetIndex(sec);
                        int column = elem.Item1;
                        int row = elem.Item2;
                        sec = dataGrid.Rows[row].Cells[column].Value.ToString();
                    }
                    if ((int)frst[0] >= 65)
                    {
                        Tuple<int, int> elem = GetIndex(frst);
                        int column = elem.Item1;
                        int row = elem.Item2;
                        frst = dataGrid.Rows[row].Cells[column].Value.ToString();
                    }
                    double a = double.Parse(frst, System.Globalization.CultureInfo.InvariantCulture);
                    double b = double.Parse(sec, System.Globalization.CultureInfo.InvariantCulture);


                    double result = 0.0;
                    if (fun.Equals("sum"))
                    {
                        result = Sum(a, b); 
                    }
                    else if (fun.Equals("mul"))
                    {
                        result = Mul(a, b);
                    }
                    st.Push(result.ToString());
                    buff = "";
                }
                else
                {
                    buff += c;
                }
            }
            if (buff.Equals("")) return st.Pop().ToString();
            return buff;
        }

        private Tuple<int, int> GetIndex(string s)
        {
            int column;
            int row;
            s = s.Replace(" ", string.Empty);
            column = (int)s[0] - 65;
            char[] arr = s.Skip(1).ToArray();
            row = Int32.Parse(new string(arr)) - 1;
            return Tuple.Create(column, row);
        }

        private void DoFunc(string t)
        {
            int column;
            int row;
            string[] tokens = t.Split('=');
            tokens[0] = tokens[0].Replace(" ", "");

            // * = 5
            if (tokens[0].Equals(""))
            {
                column = dataGrid.CurrentCell.ColumnIndex;
                row = dataGrid.CurrentCell.RowIndex;
            }

            //* A1 = 5
            else
            {
                Tuple<int, int> elem = GetIndex(tokens[0]);
                column = elem.Item1;
                row = elem.Item2;
            }

            //tokens[1] = tokens[1].Replace(" ", string.Empty);
            String result = Calc(tokens[1]);

            dataGrid.Rows[row].Cells[column].Value = result;
            dataGrid.UpdateCellValue(column, row);
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DoFunc(function.Text);
                function.Text = "";
            }
            catch
            {
                function.Text = "Error.";
            }
      
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
        }

    }
}
