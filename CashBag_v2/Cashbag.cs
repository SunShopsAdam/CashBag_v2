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

        private void Cashbag_Load(object sender, EventArgs e)
        {
            List<Bag> bags = GetAllBagsFromDB();
            UpdateTreeViewByStore(tv_viewByStore);
            tv_viewByStore.ExpandAll();

        }

        public void UpdateTreeViewByStore(TreeView treeViewByStore)
        {
            List<Bag> bagsForTreeView = GetBagsByStore();
            List<string> storesForTreeView = bagsForTreeView.OrderBy(o => o.BagLocationID).Select(o => o.BagLocationName).Distinct().ToList();
            storesForTreeView.Remove("Cash Room");
            tv_viewByStore.Nodes.Clear();



            foreach (string store in storesForTreeView)
            {
                var topNode = new TreeNode(store);
                tv_viewByStore.Nodes.Add(topNode);
                List<Bag> bagsInStore = bagsForTreeView.Where(b => b.BagLocationName == store).ToList();
                
                string bagsList = "";

                var last = bagsInStore.Last();

                foreach (Bag bag in bagsInStore)
                {
                    bagsList += bag.BagNumber;
                    if (bag != last)
                        bagsList += ", ";
                }

                var bagNode = new TreeNode(bagsList);
                topNode.Nodes.Add(bagNode);
            }
        }

        static public List<Bag> GetBagsByStore()
        {
            //This is where we grab the info from the SQL database to populate the tables on open
            SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=Cashbag.db;Version=3;");
            m_dbConnection.Open();

            //create SQL string
            string SQL = "select Bags.*, Stores.storeName from Bags, Stores where Bags.bagLocationID = Stores.storeID";
            SQLiteCommand command = new SQLiteCommand(SQL, m_dbConnection);

            SQLiteDataReader reader = command.ExecuteReader();
            var bags = new List<Bag>();
            while (reader.Read())
            {
                Bag bag = new Bag()
                {
                    BagID = reader.GetInt32(0),
                    BagNumber = reader.GetString(1),
                    BagType = reader.GetInt32(2),
                    BagLocationID = reader.GetInt32(3),
                    BagLocationName = reader.GetString(4)
                };
                bags.Add(bag);
            }

            m_dbConnection.Close();
            return bags;
        }

        public List<Bag> GetAllBagsFromDB()
        {
            //This is where we grab the info from the SQL database to populate the tables on open
            SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=Cashbag.db;Version=3;");
            m_dbConnection.Open();

            //create SQL string
            string getBagsSQL = "select * from Bags";
            SQLiteCommand command = new SQLiteCommand(getBagsSQL, m_dbConnection);

            SQLiteDataReader reader = command.ExecuteReader();
            var bags = new List<Bag>();
            while (reader.Read())
            {
                Bag bag = new Bag()
                {
                    BagID = reader.GetInt32(0),
                    BagNumber = reader.GetString(1),
                    BagType = reader.GetInt32(2),
                    BagLocationID = reader.GetInt32(3)
                };
                bags.Add(bag);
            }

            m_dbConnection.Close();

            return bags;
        }
    }
}
