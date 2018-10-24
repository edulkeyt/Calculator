using System.Diagnostics;
using System.ServiceProcess;
using System.Timers;
using VtbCalculator.CalculationQueueWorker.Services;
using VtbCalculator.Common;

namespace VtbCalculator.CalculationQueueWorker
{
    public partial class VtbQueueWorker : ServiceBase
    {
        private readonly IQueueService _queueService = new QueueService();
        private Timer _timer;

        public VtbQueueWorker()
        {
            ServiceName = nameof(VtbQueueWorker);
        }

        protected override void OnStart(string[] args)
        {
            //Debugger.Launch();

            _timer = new Timer(Config.QueueWorkerPeriodInMilliseconds) {AutoReset = true};
            _timer.Elapsed += TimerElapsed;
            _timer.Start();
        }

        protected override void OnStop()
        {
            _timer.Stop();
            _timer = null;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            _queueService.RerunCalculationsInQueue();
        }
    }
}