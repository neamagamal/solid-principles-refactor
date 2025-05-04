namespace SOLID.SOLID_Case_Answer.Case_Answer_2_OCP
{
    #region Bad Code
    //public class Drawing
    //{
    //    public string DrawShape(string shape)
    //    {
    //        string result=string.Empty;
    //        if (shape == "Circle")
    //        {
    //            result="Drawing a Circle";
    //        }
    //        else if (shape == "Square")
    //        {
    //            result ="Drawing a Square";
    //        }

    //        return result;
    //    }
    //}
    #endregion

    public interface IDrawShape
    {
        string DrawShape();
    }

    public class Circle : IDrawShape
    {
        public string DrawShape()
        {
            return "Drawing a Circle";
        }
    }

    public class Square : IDrawShape
    {
        public string DrawShape()
        {
            return "Drawing a Square";
        }
    }

    public class Drawshape
    {
        public string DrawShape(IDrawShape shape)
        {
            return shape.DrawShape();
        }

    }
}
