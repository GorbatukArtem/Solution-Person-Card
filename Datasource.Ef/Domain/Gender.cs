namespace Datasource.Ef.Domain
{
    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public virtual HashSet<Person> Persons { get; set; } = new HashSet<Person>();
    }
}