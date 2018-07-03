namespace CalculateMinLOb
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.input1 = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(242, 105);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(94, 20);
            this.input1.TabIndex = 0;
            this.input1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(372, 105);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 1;
            this.input.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(241, 227);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(410, 227);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 3;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(241, 286);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(75, 23);
            this.mult.TabIndex = 4;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(410, 286);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 23);
            this.div.TabIndex = 5;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(315, 154);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(100, 20);
            this.output.TabIndex = 6;
            this.output.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 371);
            this.Controls.Add(this.output);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.add);
            this.Controls.Add(this.input);
            this.Controls.Add(this.input1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.TextBox output;
    }
}

