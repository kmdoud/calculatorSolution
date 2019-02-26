namespace Calculator
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
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(299, 146);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 112);
            this.minus.TabIndex = 0;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(186, 146);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 116);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(186, 287);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 147);
            this.multiply.TabIndex = 2;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(299, 287);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 147);
            this.divide.TabIndex = 3;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(33, 287);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 44);
            this.input1.TabIndex = 4;
            this.input1.Text = "1";
            this.input1.TextChanged += new System.EventHandler(this.input1_TextChanged);
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(446, 259);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 44);
            this.input2.TabIndex = 5;
            this.input2.Text = "2";
            this.input2.TextChanged += new System.EventHandler(this.input2_TextChanged);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(624, 262);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 37);
            this.total.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 740);
            this.Controls.Add(this.total);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Label total;
    }
}

