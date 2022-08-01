namespace Datasource.Ef.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public DateTime? Birth { get; set; }
        public DateTime? Death { get; set; }
        public int? GenderId { get; set; }

        public Gender? Gender { get; set; }
    }
}