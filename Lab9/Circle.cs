using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Circle
    {
        private double Radius;
        private double Circumference;
        private double Area;

        private double CRadius
        {
            get
            {
                return Radius;
            }
            set
            {
                Radius = value;
            }
        }

        public Circle()
        {
            Radius = 0;
            Circumference = 0;
            Area = 0;
        }

        public Circle (double RadiusInput)
        {
            Radius = RadiusInput;
            Circumference = getCircumference();
            Area = getArea();
        }

        public double getCircumference() //formula for circumference
        {
            return Radius * Math.PI * 2;
        }
        public string getFormattedCircumference()
        {
            return String.Format("{0:0.00}", Circumference);

        }

        public double getArea() //formula for circumference
        {
            return Radius * Radius * Math.PI ;
        }










    }
}
