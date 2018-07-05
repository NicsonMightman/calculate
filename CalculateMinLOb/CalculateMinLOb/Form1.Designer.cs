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
            this.ctg = new System.Windows.Forms.Button();
            this.arcsin = new System.Windows.Forms.Button();
            this.arccos = new System.Windows.Forms.Button();
            this.arctan = new System.Windows.Forms.Button();
            this.teninx = new System.Windows.Forms.Button();
            this.reverse = new System.Windows.Forms.Button();
            this.log2x = new System.Windows.Forms.Button();
            this.xiny = new System.Windows.Forms.Button();
            this.degreeroot = new System.Windows.Forms.Button();
            this.logxy = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.remaine = new System.Windows.Forms.Button();
            this.average = new System.Windows.Forms.Button();
            this.averagegeo = new System.Windows.Forms.Button();
            this.xdivy = new System.Windows.Forms.Button();
            this.log10x = new System.Windows.Forms.Button();
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
            this.sin.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(373, 103);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 10;
            this.cos.Text = "Cos(x)";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(373, 132);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 11;
            this.tan.Text = "Tan(x)";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // ctg
            // 
            this.ctg.Location = new System.Drawing.Point(373, 161);
            this.ctg.Name = "ctg";
            this.ctg.Size = new System.Drawing.Size(75, 23);
            this.ctg.TabIndex = 12;
            this.ctg.Text = "Ctg(x)";
            this.ctg.UseVisualStyleBackColor = true;
            this.ctg.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // arcsin
            // 
            this.arcsin.Location = new System.Drawing.Point(373, 190);
            this.arcsin.Name = "arcsin";
            this.arcsin.Size = new System.Drawing.Size(75, 23);
            this.arcsin.TabIndex = 13;
            this.arcsin.Text = "ArcSin(x)";
            this.arcsin.UseVisualStyleBackColor = true;
            this.arcsin.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // arccos
            // 
            this.arccos.Location = new System.Drawing.Point(373, 219);
            this.arccos.Name = "arccos";
            this.arccos.Size = new System.Drawing.Size(75, 23);
            this.arccos.TabIndex = 14;
            this.arccos.Text = "ArcCos(x)";
            this.arccos.UseVisualStyleBackColor = true;
            this.arccos.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // arctan
            // 
            this.arctan.Location = new System.Drawing.Point(373, 248);
            this.arctan.Name = "arctan";
            this.arctan.Size = new System.Drawing.Size(75, 23);
            this.arctan.TabIndex = 15;
            this.arctan.Text = "ArcTan(x)";
            this.arctan.UseVisualStyleBackColor = true;
            this.arctan.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // teninx
            // 
            this.teninx.Location = new System.Drawing.Point(303, 132);
            this.teninx.Name = "teninx";
            this.teninx.Size = new System.Drawing.Size(51, 23);
            this.teninx.TabIndex = 16;
            this.teninx.Text = "10^x";
            this.teninx.UseVisualStyleBackColor = true;
            this.teninx.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // reverse
            // 
            this.reverse.Location = new System.Drawing.Point(303, 161);
            this.reverse.Name = "reverse";
            this.reverse.Size = new System.Drawing.Size(51, 23);
            this.reverse.TabIndex = 17;
            this.reverse.Text = "1/x";
            this.reverse.UseVisualStyleBackColor = true;
            this.reverse.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // log2x
            // 
            this.log2x.Location = new System.Drawing.Point(373, 277);
            this.log2x.Name = "log2x";
            this.log2x.Size = new System.Drawing.Size(75, 23);
            this.log2x.TabIndex = 18;
            this.log2x.Text = "Log2(x)";
            this.log2x.UseVisualStyleBackColor = true;
            this.log2x.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // xiny
            // 
            this.xiny.Location = new System.Drawing.Point(10, 132);
            this.xiny.Name = "xiny";
            this.xiny.Size = new System.Drawing.Size(75, 23);
            this.xiny.TabIndex = 19;
            this.xiny.Text = "x^y";
            this.xiny.UseVisualStyleBackColor = true;
            this.xiny.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // degreeroot
            // 
            this.degreeroot.Location = new System.Drawing.Point(12, 161);
            this.degreeroot.Name = "degreeroot";
            this.degreeroot.Size = new System.Drawing.Size(75, 23);
            this.degreeroot.TabIndex = 20;
            this.degreeroot.Text = "x^(1/y)";
            this.degreeroot.UseVisualStyleBackColor = true;
            this.degreeroot.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // logxy
            // 
            this.logxy.Location = new System.Drawing.Point(12, 190);
            this.logxy.Name = "logxy";
            this.logxy.Size = new System.Drawing.Size(75, 23);
            this.logxy.TabIndex = 21;
            this.logxy.Text = "Logx(y)";
            this.logxy.UseVisualStyleBackColor = true;
            this.logxy.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(12, 219);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(75, 23);
            this.min.TabIndex = 22;
            this.min.Text = "Min";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(12, 248);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(75, 23);
            this.max.TabIndex = 23;
            this.max.Text = "Max";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // remaine
            // 
            this.remaine.Location = new System.Drawing.Point(140, 132);
            this.remaine.Name = "remaine";
            this.remaine.Size = new System.Drawing.Size(75, 23);
            this.remaine.TabIndex = 24;
            this.remaine.Text = "Remaine";
            this.remaine.UseVisualStyleBackColor = true;
            this.remaine.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(140, 162);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(75, 23);
            this.average.TabIndex = 25;
            this.average.Text = "Average";
            this.average.UseVisualStyleBackColor = true;
            this.average.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // averagegeo
            // 
            this.averagegeo.Location = new System.Drawing.Point(140, 192);
            this.averagegeo.Name = "averagegeo";
            this.averagegeo.Size = new System.Drawing.Size(75, 23);
            this.averagegeo.TabIndex = 26;
            this.averagegeo.Text = "AverageGeo";
            this.averagegeo.UseVisualStyleBackColor = true;
            this.averagegeo.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // xdivy
            // 
            this.xdivy.Location = new System.Drawing.Point(140, 222);
            this.xdivy.Name = "xdivy";
            this.xdivy.Size = new System.Drawing.Size(75, 23);
            this.xdivy.TabIndex = 27;
            this.xdivy.Text = "XDivY";
            this.xdivy.UseVisualStyleBackColor = true;
            this.xdivy.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // log10x
            // 
            this.log10x.Location = new System.Drawing.Point(373, 306);
            this.log10x.Name = "log10x";
            this.log10x.Size = new System.Drawing.Size(75, 23);
            this.log10x.TabIndex = 28;
            this.log10x.Text = "Log10(x)";
            this.log10x.UseVisualStyleBackColor = true;
            this.log10x.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 553);
            this.Controls.Add(this.log10x);
            this.Controls.Add(this.xdivy);
            this.Controls.Add(this.averagegeo);
            this.Controls.Add(this.average);
            this.Controls.Add(this.remaine);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.logxy);
            this.Controls.Add(this.degreeroot);
            this.Controls.Add(this.xiny);
            this.Controls.Add(this.log2x);
            this.Controls.Add(this.reverse);
            this.Controls.Add(this.teninx);
            this.Controls.Add(this.arctan);
            this.Controls.Add(this.arccos);
            this.Controls.Add(this.arcsin);
            this.Controls.Add(this.ctg);
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
        private System.Windows.Forms.Button ctg;
        private System.Windows.Forms.Button arcsin;
        private System.Windows.Forms.Button arccos;
        private System.Windows.Forms.Button arctan;
        private System.Windows.Forms.Button teninx;
        private System.Windows.Forms.Button reverse;
        private System.Windows.Forms.Button log2x;
        private System.Windows.Forms.Button xiny;
        private System.Windows.Forms.Button degreeroot;
        private System.Windows.Forms.Button logxy;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button remaine;
        private System.Windows.Forms.Button average;
        private System.Windows.Forms.Button averagegeo;
        private System.Windows.Forms.Button xdivy;
        private System.Windows.Forms.Button log10x;
    }
}

