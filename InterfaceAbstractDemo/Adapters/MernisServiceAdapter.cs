using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MenrisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody
                (
                customer.NationalityId, Ad: customer.FirtName.ToUpper, Soyad: customer.FirtName.ToUpper, DogumYili: customer.DateOfBirth.Year
                )
                ))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}