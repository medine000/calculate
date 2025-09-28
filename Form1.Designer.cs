namespace calculate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            number1 = new Label();
            number2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            operation = new Label();
            result = new Label();
            comboBox1 = new ComboBox();
            submit = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // number1
            // 
            number1.AutoSize = true;
            number1.ForeColor = Color.White;
            number1.Location = new Point(115, 41);
            number1.Margin = new Padding(4, 0, 4, 0);
            number1.Name = "number1";
            number1.Size = new Size(97, 25);
            number1.TabIndex = 0;
            number1.Text = "number1 :";
            // 
            // number2
            // 
            number2.AutoSize = true;
            number2.ForeColor = SystemColors.ButtonHighlight;
            number2.Location = new Point(113, 140);
            number2.Margin = new Padding(4, 0, 4, 0);
            number2.Name = "number2";
            number2.Size = new Size(97, 25);
            number2.TabIndex = 1;
            number2.Text = "number2 :";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(124, 84);
            maskedTextBox1.Margin = new Padding(4, 4, 4, 4);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(548, 32);
            maskedTextBox1.TabIndex = 2;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(126, 185);
            maskedTextBox2.Margin = new Padding(4, 4, 4, 4);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(541, 32);
            maskedTextBox2.TabIndex = 3;
            // 
            // operation
            // 
            operation.AutoSize = true;
            operation.ForeColor = SystemColors.ButtonHighlight;
            operation.Location = new Point(124, 249);
            operation.Margin = new Padding(4, 0, 4, 0);
            operation.Name = "operation";
            operation.Size = new Size(103, 25);
            operation.TabIndex = 4;
            operation.Text = "operation :";
            // 
            // result
            // 
            result.AutoSize = true;
            result.ForeColor = SystemColors.ButtonHighlight;
            result.Location = new Point(127, 495);
            result.Margin = new Padding(4, 0, 4, 0);
            result.Name = "result";
            result.Size = new Size(68, 25);
            result.TabIndex = 5;
            result.Text = "result :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "/", "*" });
            comboBox1.Location = new Point(124, 307);
            comboBox1.Margin = new Padding(4, 4, 4, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(544, 33);
            comboBox1.TabIndex = 6;
            // 
            // submit
            // 
            submit.BackColor = Color.DarkRed;
            submit.Location = new Point(127, 374);
            submit.Margin = new Padding(4, 4, 4, 4);
            submit.Name = "submit";
            submit.Size = new Size(541, 93);
            submit.TabIndex = 7;
            submit.Text = "submit ";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(131, 553);
            listBox1.Margin = new Padding(4, 4, 4, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(540, 129);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1000, 729);
            Controls.Add(listBox1);
            Controls.Add(submit);
            Controls.Add(comboBox1);
            Controls.Add(result);
            Controls.Add(operation);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(number2);
            Controls.Add(number1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "calculate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label number1;
        private Label number2;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Label operation;
        private Label result;
        private ComboBox comboBox1;
        private Button submit;
        private ListBox listBox1;
    }
}
