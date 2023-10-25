using System;
using System.Collections.Generic;

namespace RatesService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RateService : IRateService
    {
        public List<string> GetCurrencies()
        {
            return new List<string>
            {
                "TL",
                "EUR",
                "USD",
                "GBP"
            };
        }

        public List<double> GetRates(string ratesType)
        {
            var random = new Random();
            var rates = new List<double>();

            for (int i = 0; i < 15; i++)
            {
                rates.Add(random.NextDouble() + 10);
            }

            return rates;

            //Linq query

            //var random = new Random();
            //var rates = Enumerable.Range(0, 15)
            //                     .Select(_ => random.NextDouble() + 10)
            //                     .ToList();

            //return rates;
        }
    }
}
