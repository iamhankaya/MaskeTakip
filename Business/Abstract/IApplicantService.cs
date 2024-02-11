using Entities.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
         void ApplyForMask(Person person)
        {

        }
         List<Person> GetAll(Person person)
        {
            List<Person> PersonList = new List<Person>();
            PersonList.Add(person);

            return PersonList;

        }
        bool CheckPerson(Person person)
        {
            return true;
        }
    }
}
