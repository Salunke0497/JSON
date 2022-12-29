using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock
{
    internal class Details
    {
            public List<AutoSector>AutoSector;
            public List<BankSector>BankSector;
            public List<FMCG>FMCG;

    }
    public class AutoSector
    {
        public string name;
        public int Quantity;
        public int price;
    }
    public class BankSector
    {
        public string name;
        public int Quantity;
        public int price;
    }
    public class FMCG
    {
        public string name;
        public int Quantity;
        public int price;
    }
}
