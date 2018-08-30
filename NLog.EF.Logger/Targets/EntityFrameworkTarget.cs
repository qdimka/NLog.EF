using Newtonsoft.Json.Linq;
using NLog.Config;
using NLog.EF.Logger.Context;
using NLog.EF.Logger.Models;
using NLog.Targets;

namespace NLog.EF.Logger.Targets
{
    [Target("DbContext")]
    public class EntityFrameworkTarget: TargetWithLayout
    {
        [RequiredParameter]
        public string ConnectionStringName { get; set; }

        protected override void Write(LogEventInfo logEvent)
        {
            var jsonLogEntry = base.RenderLogEvent(Layout, logEvent);

            var logEntry = JObject
                .Parse(jsonLogEntry)
                .ToObject<LogEntry>();

            using (var context = new LoggerDbContext(ConnectionStringName))
            {
                context
                    .LogEntries
                    .Add(logEntry);

                context.SaveChanges();
            }
        }
    }
}