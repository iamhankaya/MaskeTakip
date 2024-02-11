using Business.Abstract;
using Entities.Conctrete;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        

        public void GiveMask(Person person1)
        {
            if (_applicantService.CheckPerson(person1))
            {
                Console.WriteLine("Maske Verildi");
            }
            else
            {
                Console.WriteLine("Maske Verilemedi");
            }
        }

        public void GiveMask()
        {
            throw new NotImplementedException();
        }
    }
}
