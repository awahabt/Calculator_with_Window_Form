namespace Calculator
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            addNumber = new Button();
            subtNumber = new Button();
            multiNumber = new Button();
            divideNumber = new Button();
            result = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(298, 36);
            label1.Name = "label1";
            label1.Size = new Size(141, 29);
            label1.TabIndex = 0;
            label1.Text = "Calculator";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(343, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 25);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(343, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 25);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(166, 119);
            label2.Name = "label2";
            label2.Size = new Size(127, 24);
            label2.TabIndex = 3;
            label2.Text = "1st Number";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(166, 179);
            label3.Name = "label3";
            label3.Size = new Size(135, 24);
            label3.TabIndex = 4;
            label3.Text = "2nd Number";
            // 
            // addNumber
            // 
            addNumber.Location = new Point(154, 263);
            addNumber.Name = "addNumber";
            addNumber.Size = new Size(83, 25);
            addNumber.TabIndex = 5;
            addNumber.Text = "Add";
            addNumber.UseVisualStyleBackColor = true;
            addNumber.Click += addNumber_Click;
            // 
            // subtNumber
            // 
            subtNumber.Location = new Point(278, 263);
            subtNumber.Name = "subtNumber";
            subtNumber.Size = new Size(83, 25);
            subtNumber.TabIndex = 6;
            subtNumber.Text = "Subtract";
            subtNumber.UseVisualStyleBackColor = true;
            subtNumber.Click += subtNumber_Click;
            // 
            // multiNumber
            // 
            multiNumber.Location = new Point(397, 263);
            multiNumber.Name = "multiNumber";
            multiNumber.Size = new Size(83, 25);
            multiNumber.TabIndex = 7;
            multiNumber.Text = "Multiply";
            multiNumber.UseVisualStyleBackColor = true;
            multiNumber.Click += multiNumber_Click;
            // 
            // divideNumber
            // 
            divideNumber.Location = new Point(519, 263);
            divideNumber.Name = "divideNumber";
            divideNumber.Size = new Size(83, 25);
            divideNumber.TabIndex = 8;
            divideNumber.Text = "Divide";
            divideNumber.UseVisualStyleBackColor = true;
            divideNumber.Click += divideNumber_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Arial Rounded MT Bold", 18.3396225F, FontStyle.Regular, GraphicsUnit.Point, 0);
            result.Location = new Point(329, 329);
            result.Name = "result";
            result.Size = new Size(93, 32);
            result.TabIndex = 9;
            result.Text = "label4";
            result.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 477);
            Controls.Add(result);
            Controls.Add(divideNumber);
            Controls.Add(multiNumber);
            Controls.Add(subtNumber);
            Controls.Add(addNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button addNumber;
        private Button subtNumber;
        private Button multiNumber;
        private Button divideNumber;
        private Label result;
    }
}
