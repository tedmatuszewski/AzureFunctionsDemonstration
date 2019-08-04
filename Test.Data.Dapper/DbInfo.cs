namespace Test.Data.Dapper
{
    public class DbInfo
    {
        public DbInfo(string connectionStrings)
        {
            ConnectionStrings = connectionStrings;
        }

        public string ConnectionStrings { get; }
    }
}
