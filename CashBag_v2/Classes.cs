using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBag_v2
{
    public class Bag
    {
        public int BagID { get; set; }
        public string BagNumber { get; set; }
        public int BagType { get; set; }
        public int BagLocationID { get; set; }
        public string BagLocationName { get; set; }
    }

    public class Store
    {
        public int StoreID { get; set; }
        public string StoreName { get; set; }
        public int StoreOffsite { get; set; }
        public string StoreShortName { get; set; }
        public int StoreImaging { get; set; }
    }
}
