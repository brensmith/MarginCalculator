using System;
using System.Windows.Forms;
using System.Globalization;

namespace MarginCalculator
{
    public partial class Form1 : Form
    {
        // Constants for calculation
        private const double margin30Percent = 0.70;
        private const double margin20Percent = 0.80;
        private const double margin10Percent = 0.90;

        private TextBox txtInputValue;
        private Button btnCalculate;
        private TextBox txtResultWithMargin30Percent;
        private TextBox txtResultWithMargin20Percent;
        private Label lblInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtResultWithMargin10Percent;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtInputValue.Text, out double inputValue))
            {
                double resultWithMargin30Percent = inputValue / margin30Percent;
                double resultWithMargin20Percent = inputValue / margin20Percent;
                double resultWithMargin10Percent = inputValue / margin10Percent;

                CultureInfo euroCulture = new CultureInfo("fr-FR"); // Euro currency culture (France)
                txtResultWithMargin30Percent.Text = resultWithMargin30Percent.ToString("C", euroCulture);
                txtResultWithMargin20Percent.Text = resultWithMargin20Percent.ToString("C", euroCulture);
                txtResultWithMargin10Percent.Text = resultWithMargin10Percent.ToString("C", euroCulture);
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid numeric value.");
            }
        }

        private void InitializeComponent()
        {
            lblInput = new Label();
            txtInputValue = new TextBox();
            btnCalculate = new Button();
            txtResultWithMargin30Percent = new TextBox();
            txtResultWithMargin20Percent = new TextBox();
            txtResultWithMargin10Percent = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(10, 10);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(117, 15);
            lblInput.TabIndex = 0;
            lblInput.Text = "Enter Purchase Price:";
            // 
            // txtInputValue
            // 
            txtInputValue.Location = new Point(133, 7);
            txtInputValue.Name = "txtInputValue";
            txtInputValue.Size = new Size(136, 23);
            txtInputValue.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.ActiveCaption;
            btnCalculate.Location = new Point(10, 40);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtResultWithMargin30Percent
            // 
            txtResultWithMargin30Percent.Location = new Point(119, 80);
            txtResultWithMargin30Percent.Name = "txtResultWithMargin30Percent";
            txtResultWithMargin30Percent.ReadOnly = true;
            txtResultWithMargin30Percent.Size = new Size(150, 23);
            txtResultWithMargin30Percent.TabIndex = 3;
            // 
            // txtResultWithMargin20Percent
            // 
            txtResultWithMargin20Percent.Location = new Point(119, 110);
            txtResultWithMargin20Percent.Name = "txtResultWithMargin20Percent";
            txtResultWithMargin20Percent.ReadOnly = true;
            txtResultWithMargin20Percent.Size = new Size(150, 23);
            txtResultWithMargin20Percent.TabIndex = 4;
            // 
            // txtResultWithMargin10Percent
            // 
            txtResultWithMargin10Percent.Location = new Point(119, 140);
            txtResultWithMargin10Percent.Name = "txtResultWithMargin10Percent";
            txtResultWithMargin10Percent.ReadOnly = true;
            txtResultWithMargin10Percent.Size = new Size(150, 23);
            txtResultWithMargin10Percent.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 84);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 6;
            label1.Text = "30% Margin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 114);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 7;
            label2.Text = "20% Margin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 144);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 8;
            label3.Text = "10% Margin";
            // 
            // Form1
            // 
            ClientSize = new Size(284, 181);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblInput);
            Controls.Add(txtInputValue);
            Controls.Add(btnCalculate);
            Controls.Add(txtResultWithMargin30Percent);
            Controls.Add(txtResultWithMargin20Percent);
            Controls.Add(txtResultWithMargin10Percent);
            Name = "Form1";
            Text = "Margin Calculator";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
