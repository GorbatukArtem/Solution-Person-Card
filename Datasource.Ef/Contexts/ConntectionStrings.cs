using Microsoft.Data.SqlClient;

namespace Datasource.Ef.Contexts
{
    public static class ConntectionStrings
    {
        public static string GetProductionConnectionString()
        {
            var sqlbuilder = new SqlConnectionStringBuilder
            {
                DataSource = @"localhost,1433",
                InitialCatalog = "PersonCard",

                UserID = "SA",
                Password = "Password01",

                ConnectTimeout = 30,
                Encrypt = false,
                TrustServerCertificate = false,
                MultipleActiveResultSets = true
            };

            return sqlbuilder.ConnectionString;
        }
        public static string GetDevelopmentConnectionString()
        {
            var sqlbuilder = new SqlConnectionStringBuilder
            {
                DataSource = @"localhost,1433",
                InitialCatalog = "PersonCard",

                UserID = "SA",
                Password = "Password01",

                ConnectTimeout = 30,
                Encrypt = false,
                TrustServerCertificate = false,
                MultipleActiveResultSets = true
            };

            return sqlbuilder.ConnectionString;
        }
    }
}