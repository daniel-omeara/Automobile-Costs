namespace Automobile_Costs
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
            this.labelLoanPayment = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxLoanPayment = new System.Windows.Forms.TextBox();
            this.textBoxInsurance = new System.Windows.Forms.TextBox();
            this.textBoxGas = new System.Windows.Forms.TextBox();
            this.textBoxOil = new System.Windows.Forms.TextBox();
            this.textBoxTires = new System.Windows.Forms.TextBox();
            this.textBoxMaintenance = new System.Windows.Forms.TextBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.buttonCalculateMonthly = new System.Windows.Forms.Button();
            this.buttonCalculateAnnual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLoanPayment
            // 
            this.labelLoanPayment.AutoSize = true;
            this.labelLoanPayment.Location = new System.Drawing.Point(53, 45);
            this.labelLoanPayment.Name = "labelLoanPayment";
            this.labelLoanPayment.Size = new System.Drawing.Size(86, 15);
            this.labelLoanPayment.TabIndex = 0;
            this.labelLoanPayment.Text = "Loan Payment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insurance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Oil:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tires:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Maintenance:";
            // 
            // labelTotal
            // 
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.Location = new System.Drawing.Point(12, 232);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(233, 23);
            this.labelTotal.TabIndex = 6;
            // 
            // textBoxLoanPayment
            // 
            this.textBoxLoanPayment.Location = new System.Drawing.Point(145, 42);
            this.textBoxLoanPayment.Name = "textBoxLoanPayment";
            this.textBoxLoanPayment.Size = new System.Drawing.Size(100, 23);
            this.textBoxLoanPayment.TabIndex = 7;
            // 
            // textBoxInsurance
            // 
            this.textBoxInsurance.Location = new System.Drawing.Point(145, 71);
            this.textBoxInsurance.Name = "textBoxInsurance";
            this.textBoxInsurance.Size = new System.Drawing.Size(100, 23);
            this.textBoxInsurance.TabIndex = 8;
            // 
            // textBoxGas
            // 
            this.textBoxGas.Location = new System.Drawing.Point(145, 100);
            this.textBoxGas.Name = "textBoxGas";
            this.textBoxGas.Size = new System.Drawing.Size(100, 23);
            this.textBoxGas.TabIndex = 9;
            // 
            // textBoxOil
            // 
            this.textBoxOil.Location = new System.Drawing.Point(145, 129);
            this.textBoxOil.Name = "textBoxOil";
            this.textBoxOil.Size = new System.Drawing.Size(100, 23);
            this.textBoxOil.TabIndex = 10;
            // 
            // textBoxTires
            // 
            this.textBoxTires.Location = new System.Drawing.Point(145, 158);
            this.textBoxTires.Name = "textBoxTires";
            this.textBoxTires.Size = new System.Drawing.Size(100, 23);
            this.textBoxTires.TabIndex = 11;
            // 
            // textBoxMaintenance
            // 
            this.textBoxMaintenance.Location = new System.Drawing.Point(145, 187);
            this.textBoxMaintenance.Name = "textBoxMaintenance";
            this.textBoxMaintenance.Size = new System.Drawing.Size(100, 23);
            this.textBoxMaintenance.TabIndex = 12;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(12, 9);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(226, 15);
            this.labelInstructions.TabIndex = 13;
            this.labelInstructions.Text = "How much do you spend per month on...";
            // 
            // buttonCalculateMonthly
            // 
            this.buttonCalculateMonthly.Location = new System.Drawing.Point(12, 258);
            this.buttonCalculateMonthly.Name = "buttonCalculateMonthly";
            this.buttonCalculateMonthly.Size = new System.Drawing.Size(109, 53);
            this.buttonCalculateMonthly.TabIndex = 14;
            this.buttonCalculateMonthly.Text = "Calculate Monthly Total";
            this.buttonCalculateMonthly.UseVisualStyleBackColor = true;
            this.buttonCalculateMonthly.Click += new System.EventHandler(this.buttonCalculateMonthly_Click);
            // 
            // buttonCalculateAnnual
            // 
            this.buttonCalculateAnnual.Location = new System.Drawing.Point(137, 258);
            this.buttonCalculateAnnual.Name = "buttonCalculateAnnual";
            this.buttonCalculateAnnual.Size = new System.Drawing.Size(108, 53);
            this.buttonCalculateAnnual.TabIndex = 15;
            this.buttonCalculateAnnual.Text = "Calculate Annual Total";
            this.buttonCalculateAnnual.UseVisualStyleBackColor = true;
            this.buttonCalculateAnnual.Click += new System.EventHandler(this.buttonCalculateAnnual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 323);
            this.Controls.Add(this.buttonCalculateAnnual);
            this.Controls.Add(this.buttonCalculateMonthly);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.textBoxMaintenance);
            this.Controls.Add(this.textBoxTires);
            this.Controls.Add(this.textBoxOil);
            this.Controls.Add(this.textBoxGas);
            this.Controls.Add(this.textBoxInsurance);
            this.Controls.Add(this.textBoxLoanPayment);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLoanPayment);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLoanPayment;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label labelTotal;
        private TextBox textBoxLoanPayment;
        private TextBox textBoxInsurance;
        private TextBox textBoxGas;
        private TextBox textBoxOil;
        private TextBox textBoxTires;
        private TextBox textBoxMaintenance;
        private Label labelInstructions;
        private Button buttonCalculateMonthly;
        private Button buttonCalculateAnnual;
    }
}