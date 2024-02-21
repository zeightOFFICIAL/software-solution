using NLog;
using NLog.Config;
using NLog.Targets;

namespace software_solution.logger
{
    class LoggerType
    {
        readonly LoggingConfiguration config;
        readonly ColoredConsoleTarget consoleTarget;
        readonly FileTarget fileTarget;
        Logger lgr;

        public LoggerType()
        {
            config = new LoggingConfiguration();
            consoleTarget = new ColoredConsoleTarget()
            {
                Layout = "${longdate} ${level} ${message}"
            };
            config.AddTarget("console", consoleTarget);
            config.AddRuleForAllLevels(consoleTarget);
            fileTarget = new FileTarget()
            {
                Layout = "${longdate} ${level} ${message}",
                FileName = "logs/${shortdate}_nonstatic.log"
            };
            config.AddTarget("file", fileTarget);
            config.AddRuleForAllLevels(fileTarget);
            LogManager.Configuration = config;
            lgr = LogManager.GetCurrentClassLogger();
        }

        public Logger GetLogger()
        {
            return lgr;
        }
    }
}
