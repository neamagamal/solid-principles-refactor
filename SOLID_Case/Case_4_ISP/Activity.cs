namespace SOLID.SOLID_Implement_2._2_4_ISP
{
    #region Bad Code
    //public interface IWorker
    //{
    //    void Work();      //Implemented in (Machine , Engineer)
    //    void TakeBreak(); //Implemented in (Machine , Engineer)
    //    void ClockIn();   //Implemented in (Employee , Engineer)
    //    void ClockOut();  //Implemented in (Employee , Engineer)
    //}
    //public class Engineer : IWorker
    //{
    //    public void Work() { }
    //    public void TakeBreak() { }
    //    public void ClockIn() { }
    //    public void ClockOut() { }
    //}

    //public class Employee : IWorker
    //{
    //    public void ClockIn() { }
    //    public void ClockOut() { }

    //    public void TakeBreak() { }
    //    public void Work() { }
    //}

    //public class Machine : IWorker
    //{
    //    public void Work() { }
    //    public void TakeBreak() { }
    //    public void ClockIn() { }
    //    public void ClockOut() { }
    //}
    #endregion
    public interface IWorker
    {
        void Work();

    }
    public interface IBreakTaker
    {
        void TakeBreak();
    }
    public interface ITracker
    {
        void ClockIn();
        void ClockOut();
    }


    public class Engineer : IWorker, IBreakTaker, ITracker
    {
        public void Work() { }
        public void TakeBreak() { }
        public void ClockIn() { }
        public void ClockOut() { }
    }

    public class Employee : ITracker
    {
        public void ClockIn() { }
        public void ClockOut() { }
    }

    public class Machine : IBreakTaker
    {

        public void TakeBreak() { }

    }
}
