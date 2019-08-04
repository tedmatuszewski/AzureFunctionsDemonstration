using System;

namespace Test.Domain.Entities.Database
{
    public partial class Weather : IEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime DateAdded { get; set; }
        public string AddedBy { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public bool Deleted { get; set; }
    }
}