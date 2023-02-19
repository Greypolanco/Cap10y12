
namespace Cap10_12
{
    public class Ejercicios
    {

        public static void Main(String[] args)
        {
            Inventory product1 = new Inventory("lapiz",30,15.00, 1);
            System.Console.WriteLine(product1.productName);

            // Exercise 2 cap 10
            Students student1 = new Students("Greilyn", 20200577,"Sistemas");
            System.Console.WriteLine(student1.nameStudent);

            // Exercise 3 cap 10
            Polygon polygon1 = new Polygon(4,8,27.77);
            System.Console.WriteLine("El perimetro del poligono es: " + polygon1.perimeter);
            System.Console.WriteLine("El area del poligono es: " + polygon1.area);
        }
    }
}