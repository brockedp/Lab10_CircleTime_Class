using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_CircleTime
{
    public class Circle
    {
        #region Field
        private double radius;
        private double pi = Math.PI;
        #endregion

        #region Properties
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        #endregion

        #region Constructors

        public Circle()
        {

        }
        public Circle(double _radius)
        {
            radius = _radius;
        }
        public double CalculateCircumferce()
        {
            double result = (2 * radius) * pi;
            return Math.Round(result,2);
        }
        public double CalculateArea()
        {
            double result = (radius * radius) * pi;
            return Math.Round(result, 2);
        }
        public string CalculateFormattedCircumference()
        {
            double result = CalculateCircumferce();
            return result.ToString();
            
        }
        public string CalculateFormattedArea()
        {
            double result = CalculateArea();
            return result.ToString();
        }
        public string FormattedNumber(double x)
        {
            string formattedNum =  Math.Round(x, 2).ToString();
            return formattedNum;
        }

        #endregion
    }
}
