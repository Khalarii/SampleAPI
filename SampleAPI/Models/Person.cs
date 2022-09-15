namespace SampleAPI.Models
{
    public class Person
    {
        public long Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public int RiskLevel { get; set; }
    }

    public class PersonDTO
    {
        public long Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }
    }

    public class PersonTransformer
    {
        public virtual PersonDTO ToDTO(Person person) =>
            new PersonDTO
            {
                Id = person.Id,
                Name = person.Name,
                Email = person.Email
            };
    }
}