using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Contrete
{
    public class MainSupplier:ISupplierService
    {
        private IApplicantService _applicantService;
        public MainSupplier(IApplicantService applicantService) //Constructor
        {
            _applicantService = applicantService;

        }
        public void GiveMask(Person person)
        {
            
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " was given a mask");
            }
            else 
            {
                Console.WriteLine(person.FirstName + " was not given a mask");
                    }
        }
    }
}
