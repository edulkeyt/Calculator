# VtbCalculator

## Important projects:
**vtb-calculator** - angular application, UI and client
**VtbCalculator.WebSite** - project just for hosting website. You can copy artifacts here from vtb-calculator's dist folder
**VtbCalculator.WebApplication** - Service A from task. Responsible for communication with clients. Redirects calculation requests to CalculationService (Service B from task). Failed due to timeout calculations stored in queue to be recalculated by special periodic worker (service C from task)
**VtbCalculator.CalculationService** - Service B from task. Responsible for calculations. Emulation for timeout errors implemented
**VtbCalculator.CalculationQueueWorker** - periodic worker for recalculating requests that were failed due to timeout or any other reason. Windows Service.
**VtbCalculator.EmailService** - email stub

## Tests:
**VtbCalculator.Tests.CalculationServiceTests** - minimal tests for wcf communication 
**VtbCalculator.Tests.DAL** - minimal tests for repositories
**VtbCalculator.Tests.WebApplication** - empty

## Runing in developer mode.
I worked with angular part in Visual Studio Code. Open vtb-calculator folder in vsc (or other ide) run "ng serve". Proxy configured in "proxy.conf.json" file.
Open solution in Visual Studio and run it (I used VtbCalculator.WebApplication project as startup).
Build solution and install windows service for worker with installutil (project VtbCalculator.CalculationQueueWorker). Attach to process for debug