namespace NLog.EF.Logger.Models
{
    public class LogEntry
    {
        public long Id { get; set; }

        public string Date { get; set; }

        public string Thread { get; set; }

        public string Level { get; set; }

        public string Logger { get; set; }

        public string Message { get; set; }

        public string Exception { get; set; }

        public string StackTrace { get; set; }
    }
}