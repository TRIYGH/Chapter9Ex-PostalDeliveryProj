namespace PostageDeliveryApp___Ch09
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelHeader = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelInitialMessage = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelBoxOrLtr = new System.Windows.Forms.Label();
            this.listBoxLetterOrBox = new System.Windows.Forms.ListBox();
            this.labelHowMuchWeigh = new System.Windows.Forms.Label();
            this.textBoxNumOunces = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(92, 25);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(250, 37);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Postage Calculator";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "2 Day",
            "Next Day Standard",
            "Next Day Priority"});
            this.listBox1.Location = new System.Drawing.Point(142, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(146, 64);
            this.listBox1.TabIndex = 1;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // labelInitialMessage
            // 
            this.labelInitialMessage.AutoSize = true;
            this.labelInitialMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInitialMessage.Location = new System.Drawing.Point(35, 92);
            this.labelInitialMessage.Name = "labelInitialMessage";
            this.labelInitialMessage.Size = new System.Drawing.Size(251, 20);
            this.labelInitialMessage.TabIndex = 2;
            this.labelInitialMessage.Text = "Please select delivery method:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 256);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 145);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(245, 256);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 145);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "       Next Day Standard\r\n\r\n$10.50, up to 8 oz\r\n\r\n$13.75 for the first pound.\r\nAd" +
    "d $1.00 for each additional\r\npound over the first pound.";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(406, 256);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 145);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "                  2-Day\r\n\r\nNot available\r\n\r\n$7.00 for the first pound.\r\nAdd $0.50" +
    " for each additional\r\npound over the first pound.";
            // 
            // labelBoxOrLtr
            // 
            this.labelBoxOrLtr.AutoSize = true;
            this.labelBoxOrLtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBoxOrLtr.Location = new System.Drawing.Point(241, 92);
            this.labelBoxOrLtr.Name = "labelBoxOrLtr";
            this.labelBoxOrLtr.Size = new System.Drawing.Size(128, 20);
            this.labelBoxOrLtr.TabIndex = 6;
            this.labelBoxOrLtr.Text = "Letter or Box ?";
            this.labelBoxOrLtr.Visible = false;
            // 
            // listBoxLetterOrBox
            // 
            this.listBoxLetterOrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLetterOrBox.FormattingEnabled = true;
            this.listBoxLetterOrBox.ItemHeight = 20;
            this.listBoxLetterOrBox.Items.AddRange(new object[] {
            "Letter",
            "Box"});
            this.listBoxLetterOrBox.Location = new System.Drawing.Point(338, 126);
            this.listBoxLetterOrBox.Name = "listBoxLetterOrBox";
            this.listBoxLetterOrBox.Size = new System.Drawing.Size(50, 44);
            this.listBoxLetterOrBox.TabIndex = 7;
            this.listBoxLetterOrBox.Visible = false;
            this.listBoxLetterOrBox.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // labelHowMuchWeigh
            // 
            this.labelHowMuchWeigh.AutoSize = true;
            this.labelHowMuchWeigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHowMuchWeigh.Location = new System.Drawing.Point(35, 137);
            this.labelHowMuchWeigh.Name = "labelHowMuchWeigh";
            this.labelHowMuchWeigh.Size = new System.Drawing.Size(408, 20);
            this.labelHowMuchWeigh.TabIndex = 8;
            this.labelHowMuchWeigh.Text = "How much does your package weigh? ( in ounces)";
            this.labelHowMuchWeigh.Visible = false;
            // 
            // textBoxNumOunces
            // 
            this.textBoxNumOunces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumOunces.Location = new System.Drawing.Point(204, 156);
            this.textBoxNumOunces.Name = "textBoxNumOunces";
            this.textBoxNumOunces.Size = new System.Drawing.Size(99, 26);
            this.textBoxNumOunces.TabIndex = 9;
            this.textBoxNumOunces.Visible = false;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalc.Location = new System.Drawing.Point(174, 207);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(167, 34);
            this.buttonCalc.TabIndex = 10;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Visible = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 416);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxNumOunces);
            this.Controls.Add(this.labelHowMuchWeigh);
            this.Controls.Add(this.listBoxLetterOrBox);
            this.Controls.Add(this.labelBoxOrLtr);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelInitialMessage);
            this.Controls.Add(this.labelHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelInitialMessage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelBoxOrLtr;
        private System.Windows.Forms.ListBox listBoxLetterOrBox;
        private System.Windows.Forms.Label labelHowMuchWeigh;
        private System.Windows.Forms.TextBox textBoxNumOunces;
        private System.Windows.Forms.Button buttonCalc;
    }
}

