using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_CircleCircumference
{
    class Circle
    {
        private double radius = 0;
        private static int numberOfCircle =0 ;

        public Circle(double radius)
        {
            this.radius = radius;
            numberOfCircle++;
        }
        public static int getObjectCount()
        {

            return numberOfCircle;
        }

        public double getArea()
        {
            double areaOfACircle = Math.PI * radius * radius;
            return areaOfACircle;
        }

        public double getCircumference()
        {
            double circumferenceOfACircle = 2 * Math.PI * radius;
            return circumferenceOfACircle;

        }

        private String formatNumber(double valueToFormat)
        {
            string formatedValue = Math.Round(valueToFormat, 2).ToString();

            return formatedValue;
        }

        public string getFormattedCircumference()
        {
            double formatedCircumference = this.getCircumference();
           String valueToBeDisplayed =  this.formatNumber(formatedCircumference);

            return valueToBeDisplayed;
        }

        public String getFormattedArea()
        {
            double formattedArea = this.getArea();
            String valueToBeDisplayed = this.formatNumber(formattedArea);
            return valueToBeDisplayed;
        }

        

    }
}
