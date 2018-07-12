using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ExcelCopy
{
    class functions
    {
        //int sizew = 12;
        //int sizeh = 20;
        public string[,] matrica = new string[20, 12];
        /*public functions()
        {
          

           
            
        }*/
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
            Stack<string> st = new Stack<string>();
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
                        sec = matrica[row,column].ToString();
                    }
                    if ((int)frst[0] >= 65)
                    {
                        Tuple<int, int> elem = GetIndex(frst);
                        int column = elem.Item1;
                        int row = elem.Item2;
                        frst = matrica[row, column].ToString();
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

        public Tuple<String, int, int> DoFunc(string t, Tuple<int, int> selektovana_celija )
        {
            int column;
            int row;
            string[] tokens = t.Split('=');
            tokens[0] = tokens[0].Replace(" ", "");

            // * = 5
            if (tokens[0].Equals(""))
            {
                column = selektovana_celija.Item1;
                row = selektovana_celija.Item2;
            }

            //* A1 = 5
            else
            {
                Tuple<int, int> elem = GetIndex(tokens[0]);
                column = elem.Item1;
                row = elem.Item2;
            }

            //tokens[1] = tokens[1].Replace(" ", string.Empty);
            matrica[row, column] = tokens[1];
           
            return Tuple.Create(Calc(tokens[1]), column, row);

        }
         

    }
}
