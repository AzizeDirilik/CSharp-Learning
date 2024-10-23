using GameDemo.Abstract;
using GameDemo.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool PlayerIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody
                ( Convert.ToInt64(player.NationalityId), Ad: player.FirstName , Soyad: player.LastName, DogumYili:  Convert.ToInt32(player.DateOfBirth)
                )
                )).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
