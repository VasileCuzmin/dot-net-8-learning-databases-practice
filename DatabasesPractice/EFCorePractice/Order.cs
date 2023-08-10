namespace EFCorePractice
{
    public class Order
    {
        //[Key]
        public int Id { get; set; }

        public int NumberOfPieces { get; set; }

        public int ItemId { get; set; }

        // for the one to many relationship
        public Item Item { get; set; }
    }
}
