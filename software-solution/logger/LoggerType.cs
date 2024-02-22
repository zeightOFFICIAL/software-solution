using NLog;
using NLog.Config;
using NLog.Targets;

namespace software_solution.logger
{
    class LoggerType
    {
        readonly LoggingConfiguration localConfig;
        readonly ColoredConsoleTarget localConsoleTarget;
        readonly FileTarget localFileTarget;
        readonly Logger localLogger;

        public LoggerType()
        {
            localConfig = new LoggingConfiguration();

            localConsoleTarget = new ColoredConsoleTarget()
            {
                Layout = "${longdate} AS ${level} WITH ${message}"
            };
            localConfig.AddTarget("console", localConsoleTarget);
            localConfig.AddRuleForAllLevels(localConsoleTarget);

            localFileTarget = new FileTarget("ads")
            {
                Layout = "${callsite:classname=true:includenamespace=false:methodName=true} FROM ${longdate} AS ${level} WITH ${message}",
                FileName = "logs/${callsite:classname=true:includenamespace=false:methodName=false} from ${shortdate}.log",
            };
            localConfig.AddTarget("file", localFileTarget);
            localConfig.AddRuleForAllLevels(localFileTarget);

            LogManager.Configuration = localConfig;
            localLogger = LogManager.GetCurrentClassLogger();
        }

        public Logger GetLogger()
        {
            localLogger.Info("Logger init");
            return localLogger;
        }
    }
}
