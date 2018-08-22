using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string a;
        private void bSUM_Click(object sender, EventArgs e)
        {
            string First, Second;
            try { First = tbFirst.Text; } catch { First = "0"; }
            try { Second = tbSecond.Text; } catch { Second = "0"; }
            a ="="+"sum" + "(" + First + "," + Second + ")";
            
            this.Close();        
        }

        private void bMUL_Click(object sender, EventArgs e)
        {
            string First, Second;
            try { First = tbFirst.Text; } catch { First = "0"; }
            try { Second = tbSecond.Text; } catch { Second = "0"; }
            a = "=" + "mul" + "(" + First + "," + Second + ")";
            this.Close();
        }

        
    }
}
