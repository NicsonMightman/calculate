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
            this.square = new System.Windows.Forms.Button();
            this.twoinx = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.ctan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(12, 31);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(102, 20);
            this.input1.TabIndex = 0;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(140, 31);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(102, 20);
            this.input.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 74);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(140, 74);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 3;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(12, 103);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(75, 23);
            this.mult.TabIndex = 4;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(140, 103);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 23);
            this.div.TabIndex = 5;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(303, 31);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(145, 20);
            this.output.TabIndex = 6;
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(303, 74);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(51, 23);
            this.square.TabIndex = 7;
            this.square.Text = "x^2";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // twoinx
            // 
            this.twoinx.Location = new System.Drawing.Point(303, 103);
            this.twoinx.Name = "twoinx";
            this.twoinx.Size = new System.Drawing.Size(51, 23);
            this.twoinx.TabIndex = 8;
            this.twoinx.Text = "2^x";
            this.twoinx.UseVisualStyleBackColor = true;
            this.twoinx.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(373, 74);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 9;
            this.sin.Text = "Sin(x)";
            this.sin.UseVisualStyleBackColor = true;
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(373, 103);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 10;
            this.cos.Text = "Cos(x)";
            this.cos.UseVisualStyleBackColor = true;
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(373, 132);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 11;
            this.tan.Text = "Tan(x)";
            this.tan.UseVisualStyleBackColor = true;
            // 
            // ctan
            // 
            this.ctan.Location = new System.Drawing.Point(373, 161);
            this.ctan.Name = "ctan";
            this.ctan.Size = new System.Drawing.Size(75, 23);
            this.ctan.TabIndex = 12;
            this.ctan.Text = "Ctan(x)";
            this.ctan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 553);
            this.Controls.Add(this.ctan);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.twoinx);
            this.Controls.Add(this.square);
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
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button twoinx;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button ctan;
    }
}

