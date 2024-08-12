using AspNetApiWithMediatR.Models;

namespace AspNetApiWithMediatR.DataAccess
{
    public interface IDataAccess
    {
        void AddPerson(Person person);
        List<Person> GetPeople();
    }
}