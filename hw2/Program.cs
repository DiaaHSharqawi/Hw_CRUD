namespace hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            // ====== insert data ======  :
            /*
              List<Product> products = new List<Product>
      {
           new Product { Name = "TV", Price = "10$" },
          new Product { Name = "Iphone", Price = "15$" },
          new Product { Name = "Sumsung", Price = "10$" },
              };
              dbContext.Products.AddRange(products);
              dbContext.SaveChanges();
              Console.WriteLine("Products added successfully!");

              List<Order> orders = new List<Order>
                  {
                      new Order { Adress = "Nablus", createdAt = DateTime.Now },
                      new Order { Adress = "Ramallah", createdAt = DateTime.Now },
                      new Order { Adress = "Tolkarm", createdAt = DateTime.Now },
                  };
              dbContext.Orders.AddRange(orders);
                  dbContext.SaveChanges();
              Console.WriteLine("Orders added successfully!");


              */




            // ====== Print data ======  :
            /*
            //Print all Order table
            Console.WriteLine("\n======== Orders Table ========\n");

            var orders = dbContext.Orders.ToList();
            foreach (var order in orders)
            {
                Console.WriteLine($"Order Id : {order.Id}\n" +
                    $"Order Adress : {order.Adress}\n" +
                    $" createdAt : {order.createdAt}\n");
                Console.WriteLine("-------------------------------");
            }
            //Print all Product table
            Console.WriteLine("\n======== Products Table ========\n");
            var products = dbContext.Products.ToList();
            foreach (var product in products)
            {
                Console.WriteLine($"Order Id : {product.Id}\n" +
                    $"Product Name : {product.Name}\n" +
                    $" Price : {product.Price}\n");
                Console.WriteLine("-------------------------------");

            }
            */


            // ==== update data ==== :
            /*
            // update product name
            var product = dbContext.Products.FirstOrDefault(product => product.Id == 1);
            product.Name = "Glass";
            dbContext.SaveChanges();

            //update order created at
            var order = dbContext.Orders.FirstOrDefault(order => order.Id == 1);
            order.createdAt = DateTime.Now;
            dbContext.SaveChanges();
            */

            // ==== remove data ==== :
            //remove product with id 2
            var product  = dbContext.Products.FirstOrDefault(product=>product.Id==2);
            dbContext.Products.Remove(product);
            dbContext.SaveChanges();

            var order = dbContext.Orders.FirstOrDefault(order => order.Id == 3);
            dbContext.Orders.Remove(order);
            dbContext.SaveChanges();

            //
        }
    }
}
