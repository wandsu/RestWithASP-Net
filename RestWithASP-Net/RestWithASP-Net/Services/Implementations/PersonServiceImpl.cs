using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestWithASP_Net.Model;

namespace RestWithASP_Net.Services.Implementations
{
    public class PersonServiceImpl : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 9; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }


        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Steve",
                LastName = "Gates",
                Adress = "Microapple Street - Carapicuíba - SP",
                Gender = "Male"
            };
        }


        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "First Name " + i,
                LastName = "Last Name " + i,
                Adress = "Addres " + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
