namespace DZ_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pizza = new Product(1, 33, 2);
            var tomato = new Product(2, 3.4, 12);
            var inventori = new Inventory();
            inventori.AddProduct(pizza);
            inventori.AddProduct(tomato);
            double ITOGO = inventori.SumInventori();
            Console.WriteLine($"Общая стоимость инвентаря: {ITOGO} руб"); ;



        }
    }

    public class Product
    {
        public int Id { get;  }
        public double Price { get; }
        public int CountProduct { get; set; }

        public Product(int id, double price, int count)
        {
            Id = id;
            Price = price;
            CountProduct = count;

        }

    }


    public class Inventory
    {
        private readonly List<Product> products;

        public Inventory()
        {
            products = new List<Product>();
        }

   

        public void AddProduct(Product product_w)
        {
            products.Add(product_w);
        }

        public double SumInventori()
        {
            double sum = 0;
            foreach (var product in products )
            {
                sum += product.Price * product.CountProduct;
            }
            return sum;
        }
    }
}