namespace Database.Models
{
    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual HashSet<Person> Persons { get; set; }

        public Gender()
        {
            Persons = new HashSet<Person>();
        }
    }
}