using DatabasesPractice;
using System.Data.SqlClient;

namespace AdoNetPractice
{
    public class OrdersRepository
    {
        public Order GetOrderById(int orderId)
        {
            Order order = new Order();

            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                conn.Open();
                // write the corresponding code to get an order by orderId

            }

            return order;
        }
    }
}
