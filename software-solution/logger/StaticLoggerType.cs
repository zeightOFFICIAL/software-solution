using NLog.Config;
using NLog.Targets;
using NLog;

namespace software_solution.logger
{
    static class StaticLoggerType
    {
        public static Logger GetStaticLogger()
        {
            LoggingConfiguration config;
            ColoredConsoleTarget consoleTarget;
            FileTarget fileTarget;
            Logger lgr;

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
                FileName = "logs/${shortdate}_static_.log"
            };
            config.AddTarget("file", fileTarget);
            config.AddRuleForAllLevels(fileTarget);
            LogManager.Configuration = config;
            lgr = LogManager.GetCurrentClassLogger();

            return lgr;
        }
    }
}
