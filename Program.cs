using System;

namespace LabWork4._1
{
    class Product : Goods //Класс Product, похідний від класу Goods.
    {
        bool quality = false;
        public Product(int quantity, double price, string name, bool quality) : base(quantity, price, name) //конструктор з параметрами
        {
            base.quantity = quantity;
            base.price = price;
            base.name = name;
            this.quality = quality;
        }
        public override void TotalPrice()
        {
            if (quality == false)
            {
                //Якщо продукт пошкоджений, то він продається зі знижкою 50%
                Console.WriteLine("Товар бракований, знижка 50%");
                double totalPrice = (price * quantity)/2;
                Console.WriteLine($"Цiна за {quantity} одиниць товару: {totalPrice}");
            }
            else
            {
                double totalPrice = price * quantity;
                Console.WriteLine($"Цiна за {quantity} одиниць товару: {totalPrice}");
            }
            Console.WriteLine("444555666");
        }
    }
    class Toy : Goods //Класс Toy, похідний від класу Goods.
    {
        public Toy(int quantity, double price, string name): base(quantity, price, name) //конструктор з параметрами
        {
            base.quantity = quantity;
            base.price = price;
            base.name = name;
        }
        public override void TotalPrice()
        {
            base.TotalPrice();
            Console.WriteLine("111222333");
        }
    }
    class DairyProduct : Goods //Класс DairyProduct, похідний від класу Goods.
    {
        bool quality = false;
        public DairyProduct(int quantity, double price, string name, bool quality) : base(quantity, price, name) //конструктор з параметрами
        {
            base.quantity = quantity;
            base.price = price;
            base.name = name;
            this.quality = quality;
        }
        public override void TotalPrice()
        {
            if (quality == false)
            {
                //Якщо молочний продукт просрочений, то він не продається
                Console.WriteLine("Молочний продукт просрочений. Не можна купити");
            }
            else
            {
                double totalPrice = price * quantity;
                Console.WriteLine($"Цiна за {quantity} одиниць товару: {totalPrice}");
            }
            Console.Write("Штрих код товару:");
            Console.WriteLine("777888999");
        }
    }
    class Goods // клас Goods
    {
        protected double price; //захищене поле - ціна товару
        protected string name; //захищене поле - ім'я товару
        protected int quantity; //захищене поле - кількість товару
        public Goods(int quantity, double price, string name) //конструктор з параметрами
        {
            this.quantity = quantity;
            this.price = price;
            this.name = name;
        }
        public virtual void TotalPrice()
        {
            double totalPrice = price * quantity;
            Console.WriteLine($"Цiна за {quantity} одиниць товару: {totalPrice}");
            Console.Write("Штрих код товару:");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ласкаво просимо до нашого магазину!!!");
            Console.Write("Введiть кiлькiсть iграшок:\t");
            Toy toy = new Toy(Convert.ToInt32(Console.ReadLine()), 54.99, "Іграшка");
            Console.Write("Введiть кiлькiсть продуктiв:\t");
            Product product = new Product(Convert.ToInt32(Console.ReadLine()), 109.99, "Продукт", true);
            Console.Write("Введiть кiлькiсть молчних продуктiв:\t");
            DairyProduct dairyProduct = new DairyProduct(Convert.ToInt32(Console.ReadLine()), 109.99, "Продукт", true);
            Console.WriteLine();
            toy.TotalPrice();
            product.TotalPrice();
            dairyProduct.TotalPrice();
        }
    }
}
