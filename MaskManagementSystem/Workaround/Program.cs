// See https://aka.ms/new-console-template for more information
using Business.Contrete;
using Entities.Concrete;
using System;
using System.IO.Pipes;

namespace Workaround
{
    class program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.FirstName = "Test";
            person1.LastName = "Test";
            person1.NationalIdentity = 12345678910;

            MainSupplier pttMnager = new MainSupplier(new PersonManager());
            pttMnager.GiveMask(person1);


            Console.ReadLine();
        }
    }

    }

