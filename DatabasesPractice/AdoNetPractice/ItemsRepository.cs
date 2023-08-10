using DatabasesPractice;
using System.Data.SqlClient;

namespace AdoNetPractice
{
    public class ItemsRepository
    {
        public int GetNumberOfItems()
        {
            int numberOfItems = 0;
            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                conn.Open();
                // write the corresponding code to get the number of items

            }
            return numberOfItems;
        }

        public List<Item> GetAllItems()
        {
            List<Item> items = new List<Item>();

            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                conn.Open();
                // write the corresponding code to get  all the items

            }

            return items;
        }
    }
}
