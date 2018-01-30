using InterfaceImplementSamples;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementationDemo_Json_Csv
{

    public class JsonFileReader : IPaintDealers
    {
        private string path;

        public JsonFileReader()
        {
            var JsonFileName = ConfigurationManager.AppSettings["JsonFile"];
            path = AppDomain.CurrentDomain.BaseDirectory + JsonFileName;
        }

        public IEnumerable<PaintDealers> Dealers { get; private set; }


        public IEnumerable<PaintDealers> GetPaintDealers()

        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                string result = streamReader.ReadToEnd();
                Dealers = JsonConvert.DeserializeObject<IEnumerable<PaintDealers>>(result);

                foreach (var dealer in Dealers)
                {
                    
                    Console.WriteLine("ID: " + dealer.id);
                    Console.WriteLine("Dealer Name: " + dealer.dealer_name);
                    Console.WriteLine("Paint Category: " + dealer.paint_category);
                    Console.WriteLine("Paint Name: " + dealer.paint_name);
                    Console.WriteLine("Paint type: " + dealer.type);
                    Console.WriteLine("Quantity: " + dealer.quantity);
                    Console.WriteLine("Price: " + dealer.unit_price);
                    
                }
            }
            return Dealers;
        }
    }
}
