using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class BMICalculator
    {
        //  This class do not interact with the user in any way.
        //  This class is formed to use the given input and do  
        //  calculations based on diffrent factors depending on unit type.
        private double height;
        private double weight; 
        private UnitTypes unit;
        public BMICalculator(){
            unit = UnitTypes.Metric;
        }

        #region setters and getters
        public double GetHeight() //fetch variable height
        {
            return height;
        }
        public void SetHeight(double height) //setting a value to the varible
        {
            if (height >= 0.0)
                this.height = height;
        }
        public double GetWeight()
        {
            return weight;
        }
        public void SetWeight(double weight)
        {
            if (weight >= 0.0)
                this.weight = weight;
        }

        public UnitTypes GetUnitType() 
        {
            return unit;
        }
        public void SetUnitType(UnitTypes unit)
        {
            this.unit = unit;
        }
        #endregion

        public double CalculateBMI()
        {   //determin the factor based on unit type and making a
            //calculation to get the BMI

            double bmiValue = 0.0;
            double factor = 1.0;

            if(unit == UnitTypes.Imperial)
            {
                factor = 703.0;
            }

            bmiValue = factor * weight / (height * height);

            return bmiValue;
        }

        public string BmiWeightCategory()
        {
            //by the calculated BMI determine the category 
            double bmi = CalculateBMI();
            string stringout = string.Empty;

            if (bmi < 18.5)
                stringout = "Underweight";
            else if (bmi <= 24.9)
                stringout = "Normal weight";
            else if (bmi <= 29.9)
                stringout = "Overweight pre-obesity";
            else if (bmi <= 34.9)
                stringout = "Overweight (obesity class I)";
            else if (bmi <= 39.9)
                stringout = "Overweight (obesity class II)";
            else 
                stringout = "Overweight (obesity class III)";
            return stringout;

        }

    }
}