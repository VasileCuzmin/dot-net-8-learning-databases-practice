namespace EFCorePractice
{
    public class OrdersRepository
    {
        public void ReadAllOrders()
        {
            using (var context = new ItemsManagementContext())
            {
                // write the corresponding code to get and display all the orders

            }
        }

        public void UpdateFirstOrder()
        {
            using (var context = new ItemsManagementContext())
            {
                // write the corresponding code to update the first order
                // Tip: .First() method should help you
                // Don't forget to save your changes with context.SaveChanges();

            }
        }

        public void RemoveFirstOrder()
        {
            using (var context = new ItemsManagementContext())
            {
                // write the corresponding code to remove the first order
                // Tip: .First() method should help you
                // Don't forget to save your changes with context.SaveChanges();

            }
        }
    }
}
