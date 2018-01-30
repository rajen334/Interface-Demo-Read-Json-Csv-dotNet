using InterfaceImplementSamples;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementationDemo_Json_Csv
{
    public class CsvFileReader : IPaintDealers
    {
        private string path;

        public CsvFileReader()
        {
          var CsvFileName = ConfigurationManager.AppSettings["CsvFile"];
          path = AppDomain.CurrentDomain.BaseDirectory + CsvFileName;
        }

        public IEnumerable<PaintDealers> Dealers { get; private set; }
        public IEnumerable<PaintDealers> GetPaintDealers()
        {
            string[] lines = File.ReadAllLines(path);
            var csvDealers = from line in lines
                      select (line.Split(',')).ToArray();

            foreach (var dealer in csvDealers)
            {

                Console.WriteLine("ID: " + dealer[0]);
                Console.WriteLine("Dealer Name: " + dealer[5]);
                Console.WriteLine("Paint Category: " + dealer[1]);
                Console.WriteLine("Paint Name: " + dealer[2]);
                Console.WriteLine("Paint type: " + dealer[4]);
                Console.WriteLine("Quantity: " + dealer[7]);
                Console.WriteLine("Price: " + dealer[6]);

            }

            return Dealers;
        }
    }
}
