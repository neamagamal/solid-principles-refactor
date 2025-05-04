namespace SOLID.SOLID_Implement_2._2_5_DIP
{
    #region Bad Code
    //public class Manager
    //{
    //    public void AssignTask() { }
    //}

    //public class Worker
    //{
    //    private Manager _manager = new Manager();

    //    public void DoTask()
    //    {
    //        _manager.AssignTask();
    //    }
    //}
    #endregion

    public class Manager : IManager
    {
        public void AssignTask() { }
    }
    public class Worker
    {
        private readonly IManager _manager;
        public Worker(IManager manager)
        {
            _manager = manager;
        }
        public void DoTask()
        {
            _manager.AssignTask();
        }
    }

}
