using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        private string name;
        private BMICalculator bmiCalc = new BMICalculator(); //declare and create an instace 
        private SavingCalculator savingCalc = new SavingCalculator();//declare and create an instace
        public Form1()
        {
            InitializeComponent();
            InitializeGUI(); 
        }

        private void InitializeGUI()
        {
            // sets the default values to lbl, txt and rbt 
            this.Text += " Amina Amin";
            txtName.Text = string.Empty;
            lblBMI.Text = Convert.ToInt32("311");
            lblBalance.Text = string.Empty;
            lblOut.Text = string.Empty;
            lblOutGreen.Text = "Normal BMI is between 18.50 and 24.9";
            lblPaid.Text = string.Empty;
            lblWeight.Text = string.Empty;
            rbtMetric.Checked = true;
        }

        private void UpdateHWText()
        {
            //changeing the label text on height and weight
            //based on choosen metric
            if (rbtMetric.Checked)
            {
                lblH.Text = "Height (cm)";
                lblW.Text = "Weight (kg)";
                txtInch.Visible = false;
            }
            else
            {
                lblH.Text = "Height (ft, in)";
                lblW.Text = "Weight (lbs)";
                txtInch.Visible = true;
            }
            lblWeight.Text = "";
            lblBMI.Text = "";
        }

        private void btnCalcBMI_Click(object sender, EventArgs e)
        {
            //the method that gets activated when clicking the btnClacBMI button
            //calls on methods to read input and display if all is correctly registered
            bool ok = ReadInputBMI();

            if (ok)
            {
                CalculateAndDisplayResultsBMI();
            }
        }

        private void CalculateAndDisplayResultsBMI() {
            //method call the bmiCalc instence to calculate and then
            //sets the results to GUI
            double bmi = bmiCalc.CalculateBMI();
            string textout = bmiCalc.BmiWeightCategory();
            lblBMI.Text = bmi.ToString("0.00"); //f2 or 0.00 - round off the value by two decimals
            lblWeight.Text = textout;
        }

        private bool ReadInputBMI() {
            //read user input
            ReadName();
            bool heightOk = ReadHeight();
            bool weightOk = ReadWeight();
            ReadUnit();
            return heightOk && weightOk;
        }

        private void ReadUnit()
        {
            if (rbtMetric.Checked)
                bmiCalc.SetUnitType(UnitTypes.Metric);
            else
                bmiCalc.SetUnitType(UnitTypes.Imperial);
        }
        private void ReadName()
        {
            name = txtName.Text.Trim();
            grpResults.Text = "Results for " + name;
        }

        private bool ReadHeight()
        {
            double height = 0.0;
            bool check = double.TryParse(txtHeight.Text, out height);
            if (!check)
            {
                MessageBox.Show("The height value is invaild!", "Error");
            }
            double inch = 0.0;
            if (rbtUS.Checked)
            {
                check = check && double.TryParse(txtInch.Text, out inch);
                if (!check)
                {
                    MessageBox.Show("The inch value is invaild!", "Error");
                }
            }
            // cm --> m - ft ---> inch

            if (bmiCalc.GetUnitType() == UnitTypes.Metric)
                height = height / 100.0; // cm --> m
            else
                height = height * 12.0 + inch; // ft --> inch

            bmiCalc.SetHeight(height);

            return check;


        }

        private bool ReadWeight()
        {
            double weight = 0.0;
            bool check = double.TryParse(txtWeight.Text, out weight);
            if (!check)
            {
                MessageBox.Show("The weight value is invaild!", "Error");
            }
            bmiCalc.SetWeight(weight);
            return check;
        }

        private void ResetHW()
        {// setting the txt of BMI calc to default to aviod 
            //complication when changing unit
            txtHeight.Text = string.Empty;
            txtWeight.Text = string.Empty;
        }


        private void rbtMetric_CheckedChanged(object sender, EventArgs e)
        { // acknowledges when unit change to metric
            UpdateHWText();
            ResetHW();
        }

        private void rbtUS_CheckedChanged(object sender, EventArgs e)
        {//acknowledges when unit change to US
            UpdateHWText();
            ResetHW();
        }


        private bool ReadInputSavings()
        {
            //read the input for savnings (deposit & period)
            //and making sure that the values is correct

            bool success = true;

            double monthlyDeposit = ReadDouble(txtDeposit.Text, out success);

            if (success)
            {
                savingCalc.SetDeposit(monthlyDeposit);
            }
            else
            {
                MessageBox.Show("The deposit value is invaild!", "Error");
                return false;
            }

            int period = ReadInt(txtPeriod.Text, out success);

            if (success)
            {
                savingCalc.SetPeriod(period);
            }
            else
            {
                MessageBox.Show("The period value is invaild!", "Error");
                return false;
            }
            return true;
        }

        private double ReadDouble(string str, out bool success)
        { // read deposit value as double
            double value = -1.00;
            success = false;
            if (double.TryParse(str, out value))
                success = true;
            return value;
        }

        private int ReadInt(string str, out bool success)
        { // read period value as int
            int value = -1;
            success = false;
            if (int.TryParse(str, out value))
                success = true;
            return value;

        }

        private void Form1_Load(object sender, EventArgs e)
        { // center the GUI
            CenterToScreen();
        }
        private void CalculateAndDisplayResultsSaving()
        {
            //method call the savingCalc instence to calculate and then
            //sets the results to GUI
            string amoutPaid = savingCalc.calculatePaid();
            string finalBalacnce = savingCalc.calculateBalance();
            lblPaid.Text = amoutPaid.ToString(); 
            lblBalance.Text = finalBalacnce;
        }
        private void btnCalcSaving_Click(object sender, EventArgs e)
        { //method that activates when clicking on btnClacSaving
            // reads input 
           bool ok = ReadInputSavings();

            // CalculateAndDisplayResults();
            if (ok)
            {
                CalculateAndDisplayResultsSaving();
            }
        }



    }
}
