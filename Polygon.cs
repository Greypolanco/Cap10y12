namespace Cap10_12
{
    public class Polygon
    {
        public int side { get; set; }
        public int side_quantity { get; set; }
        public int perimeter { get; set; }
        public double area { get; set; }
        public double height { get; set; }
        public Polygon()
        {
            
        }
        public Polygon(int side, int side_quantity, double height)
        {
            this.side = side;
            this.side_quantity = side_quantity;
            this.height = height;
            perimeter = side * side_quantity;
            area = (perimeter * height)/2;
        }
    }
}