using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace stock
{
    internal class FetchStockDetails
    {
        public Details Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();

                    return JsonConvert.DeserializeObject<Details>(json);

                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
    }
}
