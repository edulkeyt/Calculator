using System.ServiceProcess;

namespace VtbCalculator.CalculationQueueWorker
{
    internal static class Program
    {
        private static void Main()
        {
            //new QueueService().RerunCalculationsInQueue();
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new VtbQueueWorker()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}