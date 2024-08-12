using AspNetApiWithMediatR.Models;

namespace AspNetApiWithMediatR.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<Person> _people;

        public DemoDataAccess()
        {
            _people = new List<Person>();
        }

        public List<Person> GetPeople() => _people;

        public void AddPerson(Person person) => _people.Add(person);

    }
}
