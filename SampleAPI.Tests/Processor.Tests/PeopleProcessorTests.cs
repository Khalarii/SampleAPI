using SampleAPI.Models;
using SampleAPI.Processors;

namespace SampleAPI.Tests
{
    public class PeopleProcessorTests
    {
        private Person _zeroRiskPerson = new Person { Id = 1, Name = "John Doe", Email = "john@mail.com", RiskLevel = 0 };
        private Person _riskPerson = new Person { Id = 1, Name = "John Doe", Email = "john@mail.com", RiskLevel = 1 };
        private Person _riskPersonProcessed = new Person { Id = 1, Name = "John Doe R1", Email = "john@mail.com", RiskLevel = 1 };

        public PeopleProcessorTests() { }

        [Fact]
        public void AddPerson_Processes_When_ValidInput()
        {
            Person output = new PeopleProcessor().Apply(_zeroRiskPerson);

            AssertEquals(_zeroRiskPerson, output);
        }

        [Fact]
        public void AddPerson_Processes_When_ValidInput_Risk()
        {
            Person output = new PeopleProcessor().Apply(_riskPerson);

            AssertEquals(_riskPersonProcessed, output);
        }

        [Fact]
        public void AddPerson_ThrowsException_When_NullInput()
        {
            Assert.Throws<NullReferenceException>(() => new PeopleProcessor().Apply(null));
        }

        private void AssertEquals(Person expected, Person actual)
        {
            Assert.Equal(expected.Id, actual.Id);
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.Email, actual.Email);
            Assert.Equal(expected.RiskLevel, actual.RiskLevel);
        }
    }
}