using INVENTORY_MANAGEMENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY_MANAGEMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = "D:\\batch 237\\INVENTORY MANAGEMENT\\INVENTORY MANAGEMENT\\Inventory.json";

            FetchInventoryDetails fetchInventoryDetails = new FetchInventoryDetails();

            Details data = fetchInventoryDetails.Read(path);
            Console.WriteLine("Inventory Management");

            for (int i = 0; i < data.TypesOfRice.Count; i++)
            {
                Console.WriteLine("the name of rice is : " + data.TypesOfRice[i].name);
                Console.WriteLine("the weight : " + data.TypesOfRice[i].price);
                Console.WriteLine("the price per kg : " + data.TypesOfRice[i].weight);
                int calculate = data.TypesOfRice[i].price * data.TypesOfRice[i].weight;

                Console.WriteLine("----------------------------------------------------");
            }
            Console.WriteLine("******");
            for (int i = 0; i < data.TypesOfWheat.Count; i++)
            {
                Console.WriteLine("the name of rice is : " + data.TypesOfWheat[i].name);
                Console.WriteLine("the weight : " + data.TypesOfWheat[i].price);
                Console.WriteLine("the price per kg : " + data.TypesOfWheat[i].weight);
                int calculate = data.TypesOfWheat[i].price * data.TypesOfWheat[i].weight;

                Console.WriteLine("----------------------------------------------------");
            }
            Console.WriteLine("******");
            for (int i = 0; i < data.TypesOfPulse.Count; i++)
            {
                Console.WriteLine("the name of rice is : " + data.TypesOfPulse[i].name);
                Console.WriteLine("the weight : " + data.TypesOfPulse[i].price);
                Console.WriteLine("the price per kg : " + data.TypesOfPulse[i].weight);
                int calculate = data.TypesOfPulse[i].price * data.TypesOfPulse[i].weight;

                Console.WriteLine("----------------------------------------------------");
            }
            Console.ReadLine();
        }

    }
}


