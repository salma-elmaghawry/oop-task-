using System.Diagnostics;
using System.Xml.Linq;

namespace MyApp
{
    class product
    {
        public string Name;
        public double Price;
        public string Brand;
        public string category;
        public int Quantity;
        public string SKU;
        public bool IsAvalable;
        public string description;

        public product ()
        {

        }
        public product (string name ,double price )
        {
            this.Name = name;
            this.Price = price;
        }
        
        public product (double  price ,string Brand )
        {
            this.Price = price;
            this.Brand = Brand;

        }
        public product (string category ,int Quntity ,bool isavalable )
        {
            this.category = category;
            this.Quantity = Quntity;
            this.IsAvalable = isavalable;
        }
        public product (string Sku,string discreption )
        {
            this.SKU = Sku;
            this.description = discreption;
        }
       

        public string DisplayInfo()
        {
            return $"Name: {Name}\nDescription: {description}\nPrice:{Price}\nQuantity: {Quantity}\nIsAvaliable: {IsAvalable}\nCategory: {category}\nSKu: {SKU}\nBrand: {Brand}"
                ;
        }
      public bool IsOutOfStock()
        {
            return Quantity == 0;
        }
        public void AddQuantity (int quantity )
        {
            Quantity += quantity;
        }

        public void setCategory(string category1)
        {
            category = category1;
        }
        public void setBrand(string brand )
        {
            Brand = brand;
        }
        public void setPrice(double price)
        {
            Price = price;
        }
    }
    class Myprogram
    {
        static void Main(string[]args)
        {


            product product1 = new product("mobile",5.5);
            Console.WriteLine(product1.Name);
            Console.WriteLine(product1.Price);

            Console.WriteLine(product1.DisplayInfo());

            Console.WriteLine( "===================================");
            product product2 = new product("electronics", 100,true );
            Console.WriteLine(product2.category);
            Console.WriteLine(product2.Quantity);
            Console.WriteLine(product2.IsAvalable);

            
            Console.WriteLine(product2.DisplayInfo());
            
        }
    }
}