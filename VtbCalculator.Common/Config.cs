using System;
using System.Configuration;

namespace VtbCalculator.Common
{
    public static class Config
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;

        public static double QueueWorkerPeriodInMilliseconds => 10000D;
    }
}