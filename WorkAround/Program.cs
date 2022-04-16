using Business.Concrete;
using Entities.Concrete;
using System;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Vatandas vatandas = new Vatandas();
            Person person1 = new Person();

            person1.FirstName = "engin";
            person1.LastName = "demiroğ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DoğumYili { get; set; }
        public long TcNo { get; set; }
    }

}
