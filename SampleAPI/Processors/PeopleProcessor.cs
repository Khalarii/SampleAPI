using SampleAPI.Models;

namespace SampleAPI.Processors
{
    public class PeopleProcessor
    {
        public Person Apply(Person person)
        {
            if (person.RiskLevel > 0)
            {
                person.Name += string.Format(" R{0}", person.RiskLevel);
            }

            return person;
        }
    }
}