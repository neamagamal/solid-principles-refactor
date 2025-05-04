using System;

namespace SOLID.SOLID_Case_Answer.Case_Answer_2_OCP
{
    #region Bad Code
    //public class Shape
    //{
    //    public virtual double Area { get; } // Makes derived classes implement Area

    //    public void RectangleShape(double width, double height)
    //    {
    //        // Logic for rectangle specific calculations
    //    }

    //    public void CircleShape(double radius)
    //    {
    //        // Logic for circle specific calculations
    //    }
    //}

    #endregion

    public interface IShape
    {
        double Area { get; }
    }


    public class circle : IShape
    {
        private double _radius;

        public circle(double radius)
        {
            _radius = radius;
        }

        public double Area
        {
            get { return Math.PI * _radius * _radius; }
        }
    }

    public class Rectangle : IShape
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double Area
        {
            get { return _width * _height; }
        }
    }



}
