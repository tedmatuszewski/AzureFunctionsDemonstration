using Test.Domain.Repositories.Database;

namespace Test.Domain.App
{
    public interface IDatabaseContext
    {
        IWidgetRepository widgetRepository { get; }

        void Save();
    }
}
