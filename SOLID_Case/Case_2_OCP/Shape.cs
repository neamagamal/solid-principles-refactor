using System;

namespace SOLID.SOLID_Implement_2._2_2_OCP
{
    #region Bad Code
    //public class Shape
    //{
    //    public virtual double Area(double radius)
    //    {
    //        return 0;
    //    }
    //}

    //public class Circle : Shape
    //{
    //    public override double Area(double radius)
    //    {
    //        return Math.PI * radius * radius;
    //    }
    //}

    //public class Square : Shape
    //{
    //    public override double Area(double radius)
    //    {
    //        return radius * radius;
    //    }
    //}
    #endregion

    public abstract class Shape
    {
        public abstract double CalculateArea();
    }
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }


    public class Square : Shape
    {
        private double _sideLength;

        public Square(double side)
        {
            _sideLength = side;
        }

        public override double CalculateArea()
        {
            return _sideLength * _sideLength;
        }
    }
}
