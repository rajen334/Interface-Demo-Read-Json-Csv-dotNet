using InterfaceImplementSamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementationDemo_Json_Csv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to read Csv File,Press 2 to read Json File:");

            // Read input from console
            try
            {
                int switchValue = Convert.ToInt32(Console.ReadLine());

                switch (switchValue)
                {
                    case 1:
                        IPaintDealers IPCsvDealers = new CsvFileReader();
                        IPCsvDealers.GetPaintDealers();

                        Console.WriteLine("Press any key to exit...");
                        Console.ReadLine();
                        break;
                    case 2:

                        IPaintDealers IPJsonDealers = new JsonFileReader();
                        IPJsonDealers.GetPaintDealers();

                        Console.WriteLine("Press any key to exit...");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Following exception occured:  " + ex);
                Console.ReadLine();

            }




        }
    }
}
