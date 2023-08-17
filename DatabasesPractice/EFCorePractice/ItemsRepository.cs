using Microsoft.EntityFrameworkCore;

namespace EFCorePractice
{
    public class ItemsRepository
    {
        public void ReadAllItems()
        {
            using (var context = new ItemsManagementContext())
            {
                // write the corresponding code to get and display all items

            }
        }

        public void ReadAllItemsWithOrders()
        {
            using (var context = new ItemsManagementContext())
            {
                var items = context.Items.Include(i => i.Orders).ToList();

                // write the corresponding code to display the items with their orders

            }
        }

        public void ReadFirstXItems(int numberOfItemsToRead)
        {
            using (var context = new ItemsManagementContext())
            {
                // write the corresponding code to get the first X items
                // Tip: .Take(number) method should help you

            }
        }
    }
}
