namespace Cap10_12
{

    public class Inventory
    {
        public string? productName { get; set; }
        public int idproduct { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public Inventory(string productName, int quantity, double price, int idproduct)
        {
            this.productName = productName;
            this.quantity = quantity;
            this.price = price;
            this.idproduct = idproduct;
        }

        
        
        
    }
}