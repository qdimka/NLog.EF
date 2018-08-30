using System.Data.Entity;
using NLog.EF.Logger.Models;

namespace NLog.EF.Logger.Context
{
    public class LoggerDbContext : DbContext
    {
        public IDbSet<LogEntry> LogEntries { get; set; }

        public LoggerDbContext()
        {
            
        }
        
        public LoggerDbContext(string connectionStringName) 
            : base(connectionStringName)
        {

        }
    }
}