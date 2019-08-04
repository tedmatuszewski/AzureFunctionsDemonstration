using System;

namespace Test.Domain.Entities.Database
{
    public interface IEntity
    {
        int Id { get; set; }

        DateTime DateAdded { get; set; }

        string AddedBy { get; set; }

        DateTime DateUpdated { get; set; }

        string UpdatedBy { get; set; }

        bool Deleted { get; set; }
    }
}
