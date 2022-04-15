namespace CalculatorGUI
{
   partial class CalculatorGUIForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

        #region #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.consoleLog = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inverse = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.changeSign = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            this.consoleLog.BackColor = System.Drawing.Color.White;
            this.consoleLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleLog.ForeColor = System.Drawing.Color.Black;
            this.consoleLog.Location = new System.Drawing.Point(12, 19);
            this.consoleLog.Name = "consoleLog";
            this.consoleLog.Size = new System.Drawing.Size(341, 124);
            this.consoleLog.TabIndex = 2;
            this.consoleLog.Text = "0";
            this.consoleLog.TextAlign = System.Drawing.ContentAlignment.BottomLeft;

            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.one.Location = new System.Drawing.Point(3, 3);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(80, 80);
            this.one.TabIndex = 3;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.OnePress);

            this.panel1.Controls.Add(this.inverse);
            this.panel1.Controls.Add(this.square);
            this.panel1.Controls.Add(this.minus);
            this.panel1.Controls.Add(this.log);
            this.panel1.Controls.Add(this.divide);
            this.panel1.Controls.Add(this.equal);
            this.panel1.Controls.Add(this.product);
            this.panel1.Controls.Add(this.plus);
            this.panel1.Controls.Add(this.changeSign);
            this.panel1.Controls.Add(this.zero);
            this.panel1.Controls.Add(this.nine);
            this.panel1.Controls.Add(this.eight);
            this.panel1.Controls.Add(this.seven);
            this.panel1.Controls.Add(this.six);
            this.panel1.Controls.Add(this.four);
            this.panel1.Controls.Add(this.five);
            this.panel1.Controls.Add(this.three);
            this.panel1.Controls.Add(this.two);
            this.panel1.Controls.Add(this.one);
            this.panel1.Location = new System.Drawing.Point(12, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 428);
            this.panel1.TabIndex = 4;

            this.inverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inverse.Location = new System.Drawing.Point(3, 347);
            this.inverse.Name = "inverse";
            this.inverse.Size = new System.Drawing.Size(80, 80);
            this.inverse.TabIndex = 25;
            this.inverse.Text = "1/x";
            this.inverse.UseVisualStyleBackColor = true;
            this.inverse.Click += new System.EventHandler(this.InversePress);

            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.square.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.square.Location = new System.Drawing.Point(89, 347);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(80, 80);
            this.square.TabIndex = 24;
            this.square.Text = "√";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.SquarePress);

            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minus.Location = new System.Drawing.Point(261, 89);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(80, 80);
            this.minus.TabIndex = 21;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.MinusPress);

            this.log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.log.Location = new System.Drawing.Point(175, 261);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(80, 80);
            this.log.TabIndex = 20;
            this.log.Text = "log";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.LogPress);

            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.divide.Location = new System.Drawing.Point(261, 261);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(80, 80);
            this.divide.TabIndex = 16;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.DividePress);

            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.equal.Location = new System.Drawing.Point(175, 348);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(80, 80);
            this.equal.TabIndex = 14;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.EqualPress);

            this.product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.product.Location = new System.Drawing.Point(261, 175);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(80, 80);
            this.product.TabIndex = 15;
            this.product.Text = "x";
            this.product.UseVisualStyleBackColor = true;
            this.product.Click += new System.EventHandler(this.ProductPress);

            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.plus.Location = new System.Drawing.Point(261, 3);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(80, 80);
            this.plus.TabIndex = 13;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.PlusPress);

            this.changeSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSign.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeSign.Location = new System.Drawing.Point(3, 261);
            this.changeSign.Name = "changeSign";
            this.changeSign.Size = new System.Drawing.Size(80, 80);
            this.changeSign.TabIndex = 13;
            this.changeSign.Text = "+/-";
            this.changeSign.UseVisualStyleBackColor = true;
            this.changeSign.Click += new System.EventHandler(this.SignChangePress);

            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.zero.Location = new System.Drawing.Point(89, 261);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(80, 80);
            this.zero.TabIndex = 12;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.ZeroPress);

            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nine.Location = new System.Drawing.Point(175, 175);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(80, 80);
            this.nine.TabIndex = 11;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.NinePress);

            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.eight.Location = new System.Drawing.Point(89, 175);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(80, 80);
            this.eight.TabIndex = 10;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.EightPress);

            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.seven.Location = new System.Drawing.Point(3, 175);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(80, 80);
            this.seven.TabIndex = 9;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.SevenPress);

            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.six.Location = new System.Drawing.Point(175, 89);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(80, 80);
            this.six.TabIndex = 8;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.SixPress);

            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.four.Location = new System.Drawing.Point(3, 89);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(80, 80);
            this.four.TabIndex = 7;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.FourPress);

            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.five.Location = new System.Drawing.Point(89, 89);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(80, 80);
            this.five.TabIndex = 6;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.FivePress);

            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.three.Location = new System.Drawing.Point(175, 3);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(80, 80);
            this.three.TabIndex = 5;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.ThreePress);

            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.two.Location = new System.Drawing.Point(89, 3);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(80, 80);
            this.two.TabIndex = 4;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.TwoPress);

            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(367, 607);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.consoleLog);
            this.Name = "CalculatorGUIForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button inverse;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button product;
        private System.Windows.Forms.Button changeSign;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Label consoleLog;
    #endregion
    }
}

