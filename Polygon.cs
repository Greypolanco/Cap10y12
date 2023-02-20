namespace Cap10_12
{
    public class Polygon
    {
        public int side {get; set;}
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

        public void SetSide(int side)
        {   
            if(this.side > 0)
                this.side = side;
            else 
                System.Console.WriteLine("Tiene que ser mayor a cero");
        }

        public override string ToString()
        {
            return $" los lado: {side}, cantidad: {side_quantity}";
        }
    }
}