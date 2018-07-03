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
            this.squareroot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(242, 105);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(94, 20);
            this.input1.TabIndex = 0;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(372, 105);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(70, 219);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(178, 219);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 3;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(70, 278);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(75, 23);
            this.mult.TabIndex = 4;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(178, 278);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 23);
            this.div.TabIndex = 5;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(315, 154);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(100, 20);
            this.output.TabIndex = 6;
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(525, 219);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(75, 23);
            this.square.TabIndex = 7;
            this.square.Text = "x^2";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // squareroot
            // 
            this.squareroot.Location = new System.Drawing.Point(525, 278);
            this.squareroot.Name = "squareroot";
            this.squareroot.Size = new System.Drawing.Size(75, 23);
            this.squareroot.TabIndex = 8;
            this.squareroot.Text = "x^(1/2)";
            this.squareroot.UseVisualStyleBackColor = true;
            this.squareroot.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 371);
            this.Controls.Add(this.squareroot);
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
        private System.Windows.Forms.Button squareroot;
    }
}

