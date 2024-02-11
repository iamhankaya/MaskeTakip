using Business.Abstract;
using Entities.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignerManager :IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }
        public List<Person> GetAll(Person person)
        {
            List<Person> PersonList = new List<Person>();
            PersonList.Add(person);

            return PersonList;

        }
        public bool CheckPerson(Person person)
        {
            return true;
        }
    }
}
