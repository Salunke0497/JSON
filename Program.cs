using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace stock
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Variables
            int calculate = 0;
            int calculate1 = 0;
            int calculate2 = 0;
            int result, x, y, z;
             //Path of Portfolio.json file ......look at right side solution explorer....click right click on *.json file...select copy path...past here.

            String path = "D:\\batch 237\\stock\\stock\\Portfolio.json";

            FetchStockDetails fetchStockDetails = new FetchStockDetails();
            Details data = fetchStockDetails.Read(path);
            Console.WriteLine("Stock Man");

            for (int i = 0; i < data.AutoSector.Count; i++)
            {
                Console.WriteLine("the name of share : " + data.AutoSector[i].name);
                Console.WriteLine("Price of one share : " + data.AutoSector[i].price);
                Console.WriteLine("Quantity of shares : " + data.AutoSector[i].Quantity);
                x = (data.BankSector[i].Quantity * data.BankSector[i].price);
                calculate = calculate + x;
                Console.WriteLine("total Amount for this Share : " + x);

                Console.WriteLine("----------------------------------------------------");
            }
            for (int i = 0; i < data.BankSector.Count; i++)
            {
                Console.WriteLine("the name of share : " + data.BankSector[i].name);
                Console.WriteLine("Price of one share : " + data.BankSector[i].price);
                Console.WriteLine("Quantity of shares : " + data.BankSector[i].Quantity);
                y = (data.BankSector[i].Quantity * data.BankSector[i].price);
                calculate1 = calculate1 + y;
                Console.WriteLine("total Amount for this Share : " + y);

                Console.WriteLine("----------------------------------------------------");
            }
            for (int i = 0; i < data.FMCG.Count; i++)
            {
                Console.WriteLine("the name of share : " + data.FMCG[i].name);
                Console.WriteLine("Price of one share : " + data.FMCG[i].price);
                Console.WriteLine("Quantity of shares : " + data.FMCG[i].Quantity);
                z = (data.BankSector[i].Quantity * data.BankSector[i].price);
                calculate2 = calculate1 + z;
                Console.WriteLine("total Amount for this Share : " + z);

                Console.WriteLine("----------------------------------------------------");
            }
            result = calculate + calculate1 + calculate2;
            Console.WriteLine("Total Investment in Share Market : " + result);
            
            Console.ReadLine();
        }
    }
}
