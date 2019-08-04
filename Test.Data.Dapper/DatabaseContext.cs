using System;
using System.Data;
using System.Data.SqlClient;
using Test.Domain.App;
using Test.Domain.Repositories.Database;

namespace Test.Data.Dapper
{
    public class DatabaseContext : IDisposable, IDatabaseContext
    {
        IDbConnection Connection;
        IDbTransaction Transaction;

        public DatabaseContext(DbInfo dbInfo)
        {
            this.Connection = new SqlConnection(dbInfo.ConnectionStrings);
            this.Connection.Open();
            this.Transaction = Connection.BeginTransaction();

            this.widgetRepository = new Test.Data.Dapper.Repositories.WidgetRepository();
        }

        public IWidgetRepository widgetRepository { get; }

        public void Save()
        {
            Transaction.Commit();
        }

        public void SaveAsync()
        {
            Transaction.Commit();
        }

        public void Dispose()
        {
            this.Connection.Close();
            this.Transaction.Dispose();
            this.Connection.Dispose();
        }
    }
}
