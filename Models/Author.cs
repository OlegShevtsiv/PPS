namespace DataAccess.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }

        public Author(int _id, string _name, string _surname, string _description)
        {
            Id = _id;
            Name = _name;
            Surname = _surname;
            Description = _description;
        }
    }
}
