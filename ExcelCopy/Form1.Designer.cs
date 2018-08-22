namespace ExcelCopy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.function = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(4, 68);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1600, 729);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellEndEdit);
            // 
            // function
            // 
            this.function.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.function.Location = new System.Drawing.Point(79, 15);
            this.function.Margin = new System.Windows.Forms.Padding(4);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(536, 30);
            this.function.TabIndex = 1;
            this.function.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(681, 15);
            this.calcBtn.Margin = new System.Windows.Forms.Padding(4);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(100, 28);
            this.calcBtn.TabIndex = 2;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(791, 15);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 28);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(899, 15);
            this.openBtn.Margin = new System.Windows.Forms.Padding(4);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(100, 28);
            this.openBtn.TabIndex = 4;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "F";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 795);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.function);
            this.Controls.Add(this.dataGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox function;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button button1;
    }
}

