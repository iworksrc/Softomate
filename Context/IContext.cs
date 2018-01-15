using System.Collections;
using System.Collections.Generic;
using IO.Swagger.Models;

namespace Softomate.context
{
    public interface IContext
    {
        ICollection<Person> GetPersons();
        Person GetPerson(string id);
        bool CreatePerson(Person person);
        bool UpdatePerson(Person person);
        bool DeletePerson(string id);
    }
}