using System;
using System.Reflection;

namespace VolumeWebService.VolumeCalculator
{
    public class Calculator
    {
        public double CalculateVolumeCylinder(double r,double h)
        {
            return (Math.PI * r * r * h);
        }

        public double CalculateVolumeCone(double r,double h)
        {
            return (Math.PI * r * r * h / ( 3));
        }
    }
}