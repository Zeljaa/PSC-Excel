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
        functions functions;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int w = this.Size.Width;
            //int h = this.Size.Height;
            functions = new functions(dataGrid);
            
        }   

        

        private void calcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                functions.DoFunc(function.Text);
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
