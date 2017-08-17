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
        public string StoreName{ get; set; }
        public string StoreShortName{ get; set; }
        public int StoreLocation { get; set; }
        public int StoreID { get; set; }

        public Bag(int BagID, string BagNumber, int BagType, string StoreName, string StoreShortName, int StoreLocation, int StoreID)
        {
            this.BagID = BagID;
            this.BagNumber = BagNumber;
            this.BagType = BagType;
            this.StoreName = StoreName;
            this.StoreShortName = StoreShortName;
            this.StoreLocation = StoreLocation;
            this.StoreID = StoreID;
        }

    }

    public class Store
    {
        public int StoreID;
        public string StoreName;
        public string StoreShortName;
        public int StoreLocation;

        public Store(int StoreID, string StoreName, string StoreShortName, int StoreLocation)
        {
            this.StoreID = StoreID;
            this.StoreName = StoreName;
            this.StoreShortName = StoreShortName;
            this.StoreLocation = StoreLocation;
        }
    }
}
