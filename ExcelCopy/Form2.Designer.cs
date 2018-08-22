namespace ExcelCopy
{
    partial class Form2
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
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSecond = new System.Windows.Forms.TextBox();
            this.bMUL = new System.Windows.Forms.Button();
            this.bSUM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFirst
            // 
            this.tbFirst.Location = new System.Drawing.Point(75, 10);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(100, 22);
            this.tbFirst.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "First";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second";
            // 
            // tbSecond
            // 
            this.tbSecond.Location = new System.Drawing.Point(75, 45);
            this.tbSecond.Name = "tbSecond";
            this.tbSecond.Size = new System.Drawing.Size(100, 22);
            this.tbSecond.TabIndex = 3;
            // 
            // bMUL
            // 
            this.bMUL.Location = new System.Drawing.Point(190, 278);
            this.bMUL.Name = "bMUL";
            this.bMUL.Size = new System.Drawing.Size(75, 23);
            this.bMUL.TabIndex = 4;
            this.bMUL.Text = "MUL";
            this.bMUL.UseVisualStyleBackColor = true;
            this.bMUL.Click += new System.EventHandler(this.bMUL_Click);
            // 
            // bSUM
            // 
            this.bSUM.Location = new System.Drawing.Point(109, 278);
            this.bSUM.Name = "bSUM";
            this.bSUM.Size = new System.Drawing.Size(75, 23);
            this.bSUM.TabIndex = 5;
            this.bSUM.Text = "SUM";
            this.bSUM.UseVisualStyleBackColor = true;
            this.bSUM.Click += new System.EventHandler(this.bSUM_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 313);
            this.Controls.Add(this.bSUM);
            this.Controls.Add(this.bMUL);
            this.Controls.Add(this.tbSecond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFirst);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSecond;
        private System.Windows.Forms.Button bMUL;
        private System.Windows.Forms.Button bSUM;
    }
}