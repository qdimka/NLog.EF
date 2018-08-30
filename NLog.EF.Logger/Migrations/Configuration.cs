
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace NLog.EF.Logger.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<NLog.EF.Logger.Context.LoggerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    } 
}