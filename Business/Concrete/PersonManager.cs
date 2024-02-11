using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Conctrete;
using MernisServiceReference1;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
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
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(TCKimlikNo:person.TcNo,Ad:person.Ad,Soyad:person.Soyad,DogumYili:person.DogumYili)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }   
    }
}
