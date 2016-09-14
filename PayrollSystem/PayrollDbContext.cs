using System.Data.Entity;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;
using PayrollSystem.Properties;

namespace PayrollSystem
{
    [DbConfigurationType(typeof (MySqlEFConfiguration))]
    public class PayrollDbContext : DbContext
    {
        public PayrollDbContext() : base(GetConnectionString())
        {
        }

        private static string GetConnectionString()
        {
            var connectionBuilder = new MySqlConnectionStringBuilder
            {
                Server = Settings.Default.DatabaseServer,
                Port = Settings.Default.DatabasePort,
                UserID = Settings.Default.DatabaseUser,
                Password = Utilities.Decrypt(Settings.Default.DatabasePassword),
                Database = string.Format("payroll_{0}", Settings.Default.DatabaseEnvironment.ToLower()),
            };
            return connectionBuilder.ToString();
        }

        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.PayrollPeriod> PayrollPeriods { get; set; }
    }
}