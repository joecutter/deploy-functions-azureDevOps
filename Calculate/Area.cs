using System;
using Calculate.Dto;

namespace Calculate
{
    public class Area
    {

        public float Addition(Addition addition)
        {
            return addition.Num1 + addition.Num2;
        }
        
        public float Subtraction(Addition addition)
        {
            return addition.Num1 - addition.Num2;
        }
        
        public float Square(Quadrilateral quadrilateral)
        {
            return quadrilateral.Length * quadrilateral.Width;
        }
    }
}