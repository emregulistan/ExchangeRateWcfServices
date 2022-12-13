using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ExchangeRateService
{
    public class KurService : IKurService
    {
        public List<double> KurlariGetir(string kurTipi)
        {
            Random randomKur = new Random();
            List<double> kurlarListesi= new List<double>();
            for(var i = 0; i < 15; i++)
            {
                kurlarListesi.Add(randomKur.NextDouble() + 2);
            }
            return kurlarListesi;
        }

        public List<string> ParaBirimleriGetir()
        {
            List<string> paraBirimleri = new List<string>();
            paraBirimleri.Add("TL");
            paraBirimleri.Add("Dolar");
            paraBirimleri.Add("Euro");
            paraBirimleri.Add("Pound");

            return paraBirimleri;
        }
    }
}
