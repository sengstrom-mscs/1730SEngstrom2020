namespace engstrom1730ex1e
{
    partial class frmAverageTestScore
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
            this.test1 = new System.Windows.Forms.Label();
            this.txttest1 = new System.Windows.Forms.TextBox();
            this.test2 = new System.Windows.Forms.Label();
            this.txttest2 = new System.Windows.Forms.TextBox();
            this.test3 = new System.Windows.Forms.Label();
            this.txttest3 = new System.Windows.Forms.TextBox();
            this.average = new System.Windows.Forms.Label();
            this.txtaverage = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test1
            // 
            this.test1.AutoSize = true;
            this.test1.Location = new System.Drawing.Point(39, 34);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(40, 13);
            this.test1.TabIndex = 0;
            this.test1.Text = "Test 1:";
            this.test1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txttest1
            // 
            this.txttest1.Location = new System.Drawing.Point(97, 27);
            this.txttest1.Name = "txttest1";
            this.txttest1.Size = new System.Drawing.Size(52, 20);
            this.txttest1.TabIndex = 1;
            this.txttest1.Text = "0";
            this.txttest1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // test2
            // 
            this.test2.AutoSize = true;
            this.test2.Location = new System.Drawing.Point(39, 68);
            this.test2.Name = "test2";
            this.test2.Size = new System.Drawing.Size(40, 13);
            this.test2.TabIndex = 2;
            this.test2.Text = "Test 2:";
            this.test2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txttest2
            // 
            this.txttest2.Location = new System.Drawing.Point(97, 65);
            this.txttest2.Name = "txttest2";
            this.txttest2.Size = new System.Drawing.Size(52, 20);
            this.txttest2.TabIndex = 3;
            this.txttest2.Text = "0";
            this.txttest2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // test3
            // 
            this.test3.AutoSize = true;
            this.test3.Location = new System.Drawing.Point(39, 101);
            this.test3.Name = "test3";
            this.test3.Size = new System.Drawing.Size(40, 13);
            this.test3.TabIndex = 4;
            this.test3.Text = "Test 3:";
            this.test3.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txttest3
            // 
            this.txttest3.Location = new System.Drawing.Point(97, 98);
            this.txttest3.Name = "txttest3";
            this.txttest3.Size = new System.Drawing.Size(52, 20);
            this.txttest3.TabIndex = 5;
            this.txttest3.Text = "0";
            this.txttest3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.Location = new System.Drawing.Point(29, 145);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(50, 13);
            this.average.TabIndex = 6;
            this.average.Text = "Average:";
            // 
            // txtaverage
            // 
            this.txtaverage.Location = new System.Drawing.Point(97, 142);
            this.txtaverage.Name = "txtaverage";
            this.txtaverage.ReadOnly = true;
            this.txtaverage.Size = new System.Drawing.Size(52, 20);
            this.txtaverage.TabIndex = 7;
            this.txtaverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(232, 41);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 23);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "Ca&lculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(232, 70);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(232, 99);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // frmAverageTestScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 249);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtaverage);
            this.Controls.Add(this.average);
            this.Controls.Add(this.txttest3);
            this.Controls.Add(this.test3);
            this.Controls.Add(this.txttest2);
            this.Controls.Add(this.test2);
            this.Controls.Add(this.txttest1);
            this.Controls.Add(this.test1);
            this.Name = "frmAverageTestScore";
            this.Text = "engstrom1730ex1e";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label test1;
        private System.Windows.Forms.TextBox txttest1;
        private System.Windows.Forms.Label test2;
        private System.Windows.Forms.TextBox txttest2;
        private System.Windows.Forms.Label test3;
        private System.Windows.Forms.TextBox txttest3;
        private System.Windows.Forms.Label average;
        private System.Windows.Forms.TextBox txtaverage;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

