using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
          var result =client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId),customer.FirstName,customer.LastName,customer.DateOfBirth.Year).Result;
            return result.Body.TCKimlikNoDogrulaResult;


        }
    }
}
