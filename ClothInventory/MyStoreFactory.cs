using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothInventory
{
    public class MyStoreFactory
    {
        public static string Name { get; set; }

        public static MyStore CreateMyStore (string name)
        {
            MyStore mystore = new MyStore(name);

            return mystore;
        }
    }
}
