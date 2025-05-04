namespace SOLID.SOLID_Implement_2._2_3_LSP
{
    #region Bad Code
    //public class Rectangle
    //{
    //    public int Width { get; set; }
    //    public int Height { get; set; }
    //}
    //public class Square : Rectangle
    //{
    //    public new int Width
    //    {
    //        get { return base.Width; }
    //        set
    //        {
    //            base.Width = value;
    //            base.Height = value;
    //        }
    //    }
    //    public new int Height
    //    {
    //        get { return base.Height; }
    //        set
    //        {
    //            base.Height = value;
    //            base.Width = value;
    //        }
    //    }
    //}

    #endregion

    // Using composition instead of inheritance
    public interface IShape
    {
        int Area { get; }
    }

    public class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area => Width * Height;
    }

    public class Square : IShape
    {
        public int SideLength { get; set; }
        public int Area => SideLength * SideLength;
    }

}
