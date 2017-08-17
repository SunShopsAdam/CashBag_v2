using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CashBag_v2
{
    public partial class Cashbag : Form
    {
        public Cashbag()
        {
            InitializeComponent();
        }

        public void Cashbag_Load(object sender, EventArgs e)
        {
            UpdateTreeViewByStore();
            tv_viewByStore.ExpandAll();
        }

        public void UpdateTreeViewByStore()
        {
            List<Bag> bags = GetAllBagsFromDB();
            List<string> storesForTreeView = bags.OrderBy(o => o.StoreID).Select(o => o.StoreName).Distinct().ToList();
            tv_viewByStore.Nodes.Clear();

                
            foreach (string store in storesForTreeView)
            {
                string bagsList = "";

                var topNode = new TreeNode(store);
                tv_viewByStore.Nodes.Add(topNode);
                List<Bag> bagsInStore = bags.Where(b => b.StoreName == store).ToList();

                //For the Cash Room, we need a way to display the entire set of bags
                if (store == "Cash Room")
                {
                    int page = 50;
                    int skip = 50;

                    List<List<Bag>> cashroomNodes = new List<List<Bag>>();

                    List<Bag> firstFiftyOnSite = bagsInStore.Where(b => b.BagType == 0).Take(page).ToList();
                    List<Bag> secondFiftyOnSite = bagsInStore.Where(b => b.BagType == 0).Skip(skip).ToList();
                    List<Bag> firstFiftyOffSite = bagsInStore.Where(b => b.BagType == 1).Take(page).ToList();
                    List<Bag> secondFiftyOffSite = bagsInStore.Where(b => b.BagType == 1).Skip(skip).ToList();
                    List<Bag> firstFiftyImaging = bagsInStore.Where(b => b.BagType == 2).Take(page).ToList();
                    List<Bag> secondFiftyImaging = bagsInStore.Where(b => b.BagType == 2).Skip(skip).ToList();

                    cashroomNodes.Add(firstFiftyOnSite);
                    cashroomNodes.Add(secondFiftyOnSite);
                    cashroomNodes.Add(firstFiftyOffSite);
                    cashroomNodes.Add(secondFiftyOffSite);
                    cashroomNodes.Add(firstFiftyImaging);
                    cashroomNodes.Add(secondFiftyImaging);

                    foreach (List<Bag> node in cashroomNodes)
                    {
                        foreach (Bag bag in node)
                        {
                            bagsList += bag.BagNumber;
                            bagsList += ", ";
                        }
                        if (bagsList.Substring(bagsList.Length - 2) == ", ")
                        {
                            bagsList = bagsList.Substring(0, bagsList.Length - 2);
                        }
                        var bagNode = new TreeNode(bagsList);
                        topNode.Nodes.Add(bagNode);
                        bagsList = "";
                    }
                }

                //For the rest of the stores, we'll never have more than 50 bags at any 1 location
                else {
                    foreach (Bag bag in bagsInStore)
                    {
                        bagsList += bag.BagNumber;
                        bagsList += ", ";
                    }
                    if (bagsList.Substring(bagsList.Length - 2) == ", ")
                    {
                        bagsList = bagsList.Substring(0, bagsList.Length - 2);
                    }
                    var bagNode = new TreeNode(bagsList);
                    topNode.Nodes.Add(bagNode);
                }

            }
        }

        public List<Bag> GetAllBagsFromDB()
        {
            //This is where we grab the info from the SQL database to populate the tables on open
            SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=Cashbag.db;Version=3;");
            m_dbConnection.Open();

            //create SQL string
            string getBagsSQL = "select Bags.bagID, Bags.bagNumber, Bags.bagType, Stores.storeName, Stores.storeShortName," +
                " Stores.storeLocation, Stores.storeID from Bags, Stores where Bags.bagLocationID = Stores.storeID order by storeID, bagID";
            SQLiteCommand command = new SQLiteCommand(getBagsSQL, m_dbConnection);

            SQLiteDataReader reader = command.ExecuteReader();
            var bags = new List<Bag>();
            while (reader.Read())
            {
                Bag bag = new Bag(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2),
                    reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetInt32(6));
                bags.Add(bag);
            }

            m_dbConnection.Close();

            return bags;
        }
    }
}
