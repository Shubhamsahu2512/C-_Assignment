using System.Collections;

using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Assignment
{
    //public class AuthenticationFailed : Exception { 
    
    //    public AuthenticationFailed() { 

    //    }
    //    public void Message()
    //    {
    //        Console.WriteLine("User already logged in");
    //    }
    //}

    public class Products
    {
        
            
         public int ProductId { get; set; }
        public string ProductName { get; set; }
         
        public string ProductDescription { get; set; }

        public int ProductPrice { get; set; }


    }

    public class Cart
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
    public class CheckLogin
    {

        public bool Login(string username, string password)
        {
             bool isloggedin = false;

            if (!isloggedin)
            {
                if (username == "admin" && password == "1234")
                {
                    isloggedin = true;
                    return true;
                }
                else
                {
                    isloggedin = false;
                   // Console.WriteLine("Invalid UserName or Password");
                    return false;
                    //throw new AuthenticationFailed();
                }
            }
            else
            {
                Console.WriteLine("Already Logged In");
                Console.WriteLine();
                return false;
            }
           
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Home Screen");
            Console.WriteLine();

            Console.WriteLine("Press 1 To Login");
            Console.WriteLine();
            Console.WriteLine("Press 2 To Register");
            Console.WriteLine();

            string action =  Console.ReadLine();

            if (action == "2") {

                Console.WriteLine("Sorry curently we are not registering new users");
                Console.WriteLine();
                Console.ReadKey();
            }
            else
            {
                CheckLogin login = new CheckLogin();

                Console.WriteLine("Enter UserName");
                Console.WriteLine();
                string username = Console.ReadLine();

                Console.WriteLine("Enter Password");
                Console.WriteLine();
                string password = Console.ReadLine();


                try
                {
                    bool IsLoggedIn = login.Login(username, password);
                    if (IsLoggedIn)
                    {
                        Console.WriteLine("Success fully Logged In");
                        Console.WriteLine();



                        List<Products> products= new List<Products>();
                        List<Cart> carts= new List<Cart>();
                        products.Add(new Products { ProductId = 1, ProductName = "Laptop", ProductDescription = "Tech", ProductPrice = 32000 });
                        products.Add(new Products { ProductId = 2, ProductName = "Mouse", ProductDescription = "Tech", ProductPrice = 2000 });
                        products.Add(new Products { ProductId = 3, ProductName = "Pen", ProductDescription = "Stationery", ProductPrice = 3 });
                        products.Add(new Products { ProductId = 4, ProductName = "Cap", ProductDescription = "Clothes", ProductPrice = 320 });
                        products.Add(new Products { ProductId = 5, ProductName = "Clock", ProductDescription = "Tech", ProductPrice = 3200 });

                        Console.WriteLine("Welcome To Shubhams Business");
                        Console.WriteLine();
                        foreach (var item in products)
                        {
                            Console.WriteLine(item.ProductId + "   " + item.ProductName + "   " + item.ProductPrice + "   " + item.ProductDescription);
                        }
                        int result = 2;

                        while(result != 1)
                        {
                            Console.WriteLine("Add Items to Your Cart");
                            Console.WriteLine();
                            Console.WriteLine("Please Select Id to Add to Cart");
                            Console.WriteLine();

                            int id = int.Parse(Console.ReadLine());

                            switch (id)
                            {

                                case 1:
                                    {
                                        Console.WriteLine("Please specify Quantity in numbers");
                                        Console.WriteLine();
                                        int Q = int.Parse(Console.ReadLine());
                                        carts.Add(new Cart { Quantity = Q, ProductName = "Laptop" });
                                    }
                                    break;

                                case 2:
                                    {
                                        Console.WriteLine("Please specify Quantity in numbers");
                                        Console.WriteLine();
                                        int Q = int.Parse(Console.ReadLine());
                                        carts.Add(new Cart { Quantity = Q, ProductName = "Mouse" });
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine("Please specify Quantity in numbers");
                                        Console.WriteLine();
                                        int Q = int.Parse(Console.ReadLine());
                                        carts.Add(new Cart { Quantity = Q, ProductName = "Pen" });
                                    }
                                    break;
                                case 4:
                                    {
                                        Console.WriteLine("Please specify Quantity in numbers");
                                        Console.WriteLine();
                                        int Q = int.Parse(Console.ReadLine());
                                        carts.Add(new Cart { Quantity = Q, ProductName = "Cap" });
                                    }
                                    break;
                                case 5:
                                    {
                                        Console.WriteLine("Please specify Quantity in numbers");
                                        Console.WriteLine();
                                        int Q = int.Parse(Console.ReadLine());
                                        carts.Add(new Cart { Quantity = Q, ProductName = "Clock" });
                                    }
                                    break;

                                default:
                                    throw new Exception("Invalid Item Selected");
                                    break;
                            }

                            Console.WriteLine("Items in your Cart");
                            foreach (var item in carts)
                            {
                                Console.WriteLine(item.ProductName + "  " + item.Quantity);
                                Console.WriteLine();
                            }

                            Console.WriteLine();

                            Console.WriteLine("Continue To Check Out");
                            Console.WriteLine();

                            Console.WriteLine("1.Yes");
                            Console.WriteLine();
                            Console.WriteLine("2.No");
                            Console.WriteLine();

                            result = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("Order Placed Successfully");
                        Console.WriteLine();


                    }

                    else
                    {
                        throw new Exception("Invalid UserName or Password");
                    }




                }
                catch(Exception ex)
                {
                    Console.WriteLine (ex.Message);
                }
                finally
                {
                    Console.ReadKey();
                }


            }
        }
    }
}