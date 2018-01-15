using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using IO.Swagger.Models;

namespace Softomate.context
{
    public class MockContext : IContext
    {

        private ICollection<Person> inMemoryStorage;


        public MockContext()
        {
            inMemoryStorage = new List<Person>();
        }

        public ICollection<Person> GetPersons()
        {
            return inMemoryStorage;
        }

        public Person GetPerson(string id)
        {
            return inMemoryStorage.FirstOrDefault(p => p.Id == id);
        }

        public bool CreatePerson(Person person)
        {
            var result = inMemoryStorage.FirstOrDefault(p => p.Id == person.Id);
            if (result == null)
            {
                inMemoryStorage.Add(person);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdatePerson(Person person)
        {
            var result = inMemoryStorage.FirstOrDefault(p => p.Id == person.Id);
            if (result == null)
            {
                return false;
            }
            else
            {
                inMemoryStorage.Remove(result);
                inMemoryStorage.Add(person);
                return true;
            }
        }

        public bool DeletePerson(string id)
        {
            var result = inMemoryStorage.FirstOrDefault(p => p.Id == id);
            if (result == null)
            {
                return false;
            }
            else
            {
                inMemoryStorage.Remove(result);
                return true;
            }
            
        }
    }
}