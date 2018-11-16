using System;

namespace Logger
{
    public class Log
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static void Shutdown()
        {
            NLog.LogManager.Shutdown();
        }

        public static void Info(string msgInfo)
        {
            logger.Info(msgInfo);
        }

        public static void Info(Exception e)
        {
            logger.Info(e, e.Message);
        }

        public static void Info(Exception e, string msgInfo)
        {
            logger.Info(e, msgInfo);
        }

        public static void Error(string msgError)
        {
            logger.Error(msgError);
        }

        public static void Error(Exception e)
        {
            logger.Error(e, e.Message);
        }

        public static void Error(Exception e, string msgError)
        {
            logger.Error(e, msgError);
        }

        public static void Warn(string msgWarn)
        {
            logger.Warn(msgWarn);
        }

        public static void Warn(Exception e)
        {
            logger.Warn(e, e.Message);
        }

        public static void Warn(Exception e, string msgWarn)
        {
            logger.Warn(e, msgWarn);
        }

        public static void Fatal(string msgFatal)
        {
            logger.Fatal(msgFatal);
        }

        public static void Fatal(Exception e)
        {
            logger.Fatal(e, e.Message);
        }

        public static void Fatal(Exception e, string msgFatal)
        {
            logger.Fatal(e, msgFatal);
        }
    }
}