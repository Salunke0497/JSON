using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY_MANAGEMENT
{
    public class Details
    {
        public List<TypesOfRice> TypesOfRice;
        public List<TypesOfWheat> TypesOfWheat;
        public List<TypesOfPulse> TypesOfPulse;

    }
    public class TypesOfRice
    {
        public string name;
        public int weight;
        public int price;    
    }
    public class TypesOfWheat
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypesOfPulse
    {
        public string name;
        public int weight;
        public int price;
    }
}
