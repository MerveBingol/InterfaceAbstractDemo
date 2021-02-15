using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        // kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz.
        //Strabucks ve Nero Firması için çalışıyoruz. iki firmada müşterilerini veri tabanına kaydetmek istiyor.
        //Strabucks müşterileri kaydederken mutlaka mernis doğrulması istiyor.Nero ise istemiyor
        //Starbucks müşteriler için her kahve alımında yıldız  kazandırmak istiyor.
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer {DateOfBirth=new DateTime(2000,5,1),FirstName="Merve",LastName="BİNGÖL" ,
            NationalityId="123456"});
            Console.ReadLine();
            
        }
    }


}
