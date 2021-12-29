
namespace Assignment3
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtUS = new System.Windows.Forms.RadioButton();
            this.rbtMetric = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnCalcBMI = new System.Windows.Forms.Button();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblOutGreen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtInch = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalcSaving = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(24, 106);
            this.lblW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(81, 17);
            this.lblW.TabIndex = 1;
            this.lblW.Text = "Weight (kg)";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(24, 65);
            this.lblH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(81, 17);
            this.lblH.TabIndex = 2;
            this.lblH.Text = "Height (cm)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtUS);
            this.groupBox1.Controls.Add(this.rbtMetric);
            this.groupBox1.Location = new System.Drawing.Point(335, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(183, 165);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit";
            // 
            // rbtUS
            // 
            this.rbtUS.AutoSize = true;
            this.rbtUS.Location = new System.Drawing.Point(8, 60);
            this.rbtUS.Margin = new System.Windows.Forms.Padding(4);
            this.rbtUS.Name = "rbtUS";
            this.rbtUS.Size = new System.Drawing.Size(141, 21);
            this.rbtUS.TabIndex = 1;
            this.rbtUS.TabStop = true;
            this.rbtUS.Text = "US Unit (foot, Ibs)";
            this.rbtUS.UseVisualStyleBackColor = true;
            this.rbtUS.CheckedChanged += new System.EventHandler(this.rbtUS_CheckedChanged);
            // 
            // rbtMetric
            // 
            this.rbtMetric.AutoSize = true;
            this.rbtMetric.Location = new System.Drawing.Point(8, 30);
            this.rbtMetric.Margin = new System.Windows.Forms.Padding(4);
            this.rbtMetric.Name = "rbtMetric";
            this.rbtMetric.Size = new System.Drawing.Size(147, 21);
            this.rbtMetric.TabIndex = 0;
            this.rbtMetric.TabStop = true;
            this.rbtMetric.Text = "Metric Unit (kg cm)";
            this.rbtMetric.UseVisualStyleBackColor = true;
            this.rbtMetric.CheckedChanged += new System.EventHandler(this.rbtMetric_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 18);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(136, 61);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(69, 22);
            this.txtHeight.TabIndex = 5;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(183, 103);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(77, 22);
            this.txtWeight.TabIndex = 6;
            // 
            // btnCalcBMI
            // 
            this.btnCalcBMI.Location = new System.Drawing.Point(176, 215);
            this.btnCalcBMI.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcBMI.Name = "btnCalcBMI";
            this.btnCalcBMI.Size = new System.Drawing.Size(168, 37);
            this.btnCalcBMI.TabIndex = 7;
            this.btnCalcBMI.Text = "Calculate BMI";
            this.btnCalcBMI.UseVisualStyleBackColor = true;
            this.btnCalcBMI.Click += new System.EventHandler(this.btnCalcBMI_Click);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblWeight);
            this.grpResults.Controls.Add(this.lblBMI);
            this.grpResults.Controls.Add(this.lblOut);
            this.grpResults.Controls.Add(this.lblOutGreen);
            this.grpResults.Controls.Add(this.label5);
            this.grpResults.Controls.Add(this.label4);
            this.grpResults.Location = new System.Drawing.Point(32, 260);
            this.grpResults.Margin = new System.Windows.Forms.Padding(4);
            this.grpResults.Name = "grpResults";
            this.grpResults.Padding = new System.Windows.Forms.Padding(4);
            this.grpResults.Size = new System.Drawing.Size(486, 170);
            this.grpResults.TabIndex = 8;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results for";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(185, 65);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(0, 17);
            this.lblWeight.TabIndex = 16;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(185, 30);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 17);
            this.lblBMI.TabIndex = 15;
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(186, 140);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(0, 17);
            this.lblOut.TabIndex = 14;
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOutGreen
            // 
            this.lblOutGreen.AutoSize = true;
            this.lblOutGreen.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblOutGreen.Location = new System.Drawing.Point(186, 107);
            this.lblOutGreen.Name = "lblOutGreen";
            this.lblOutGreen.Size = new System.Drawing.Size(0, 17);
            this.lblOutGreen.TabIndex = 13;
            this.lblOutGreen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Weight Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Your BMI";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtInch);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblH);
            this.groupBox3.Controls.Add(this.lblW);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.txtWeight);
            this.groupBox3.Controls.Add(this.txtHeight);
            this.groupBox3.Location = new System.Drawing.Point(12, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 167);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BMICalculator";
            // 
            // txtInch
            // 
            this.txtInch.Location = new System.Drawing.Point(232, 61);
            this.txtInch.Name = "txtInch";
            this.txtInch.Size = new System.Drawing.Size(64, 22);
            this.txtInch.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPeriod);
            this.groupBox4.Controls.Add(this.txtDeposit);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(575, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 165);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Saving Plan";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(233, 80);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(100, 22);
            this.txtPeriod.TabIndex = 3;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(233, 45);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(100, 22);
            this.txtDeposit.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Period (years)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Monthly deposit";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblBalance);
            this.groupBox5.Controls.Add(this.lblPaid);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(575, 260);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(339, 138);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Future value";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(173, 86);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(16, 17);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "0";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(170, 43);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(16, 17);
            this.lblPaid.TabIndex = 2;
            this.lblPaid.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Final balance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Amount paid";
            // 
            // btnCalcSaving
            // 
            this.btnCalcSaving.Location = new System.Drawing.Point(652, 222);
            this.btnCalcSaving.Name = "btnCalcSaving";
            this.btnCalcSaving.Size = new System.Drawing.Size(202, 32);
            this.btnCalcSaving.TabIndex = 12;
            this.btnCalcSaving.Text = "Calculating saving";
            this.btnCalcSaving.UseVisualStyleBackColor = true;
            this.btnCalcSaving.Click += new System.EventHandler(this.btnCalcSaving_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 443);
            this.Controls.Add(this.btnCalcSaving);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.btnCalcBMI);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtUS;
        private System.Windows.Forms.RadioButton rbtMetric;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnCalcBMI;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalcSaving;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblOutGreen;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.TextBox txtInch;
    }
}

