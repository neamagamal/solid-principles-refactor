﻿namespace SOLID.SOLID_Case_Answer.Case_Answer_4_ISP
{
    #region Bad Code
    //public interface ILogger
    //{
    //    void LogMessage(string message);
    //    void LogWarning(string message);
    //    void LogError(string message); // Not all loggers might implement error logging
    //}

    //public class FileLogger : ILogger
    //{
    //    public void LogMessage(string message)
    //    {
    //        // Log message to file
    //    }

    //    public void LogWarning(string message)
    //    {
    //        // Log warning to file
    //    }

    //    public void LogError(string message) // Might not be implemented
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public class DatabaseLogger : ILogger
    //{
    //    public void LogMessage(string message)
    //    {
    //        // Log message to database
    //    }

    //    public void LogWarning(string message)
    //    {
    //        // Log warning to database
    //    }

    //    public void LogError(string message)
    //    {
    //        // Log error to database
    //    }
    //}

    #endregion

    public interface ILogger
    {
        void LogMessage(string message);
        void LogWarning(string message);
    }

    public interface ILoggerError
    {
        void LogError(string message);
    }

    public class FileLogger : ILogger
    {
        public void LogMessage(string message)
        {
            // Log message to file
        }

        public void LogWarning(string message)
        {
            // Log warning to file
        }
    }

    public class DatabaseLogger : ILoggerError, ILogger
    {
        public void LogError(string message)
        {
            throw new System.NotImplementedException();
        }

        public void LogMessage(string message)
        {
            // Log message to database
        }

        public void LogWarning(string message)
        {
            // Log warning to database
        }
    }
}
