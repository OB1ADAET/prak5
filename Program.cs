using System;
using System.IO;

class Order
{
    public string form;
    public string size;
    public string taste;
    public int quantity;
    public string icing;
    public string decoration;
    public int price;
}

class Program
{
    static void Main(string[] args)
    {
        string form = "";
        string size = "";
        string taste = "";
        int quantity = 0;
        string icing = "";
        string decoration = "";
        int price = 0;
        char choice;

        do
        {
            Console.WriteLine("Добро пожаловать в нашу пекарню!");
            Console.WriteLine("Пожалуйста, выберите ваш заказ:");
            Console.WriteLine("1. Форма");
            Console.WriteLine("2. Размер");
            Console.WriteLine("3. Вкус");
            Console.WriteLine("4. Количество");
            Console.WriteLine("5. Глазурь");
            Console.WriteLine("6. Декорация");
            Console.WriteLine("Нажмите Escape, чтобы выйти");

            choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (choice == '1')
            {
                Console.WriteLine("Пожалуйста, выберите форму:");
                Console.WriteLine("1. Круглый");
                Console.WriteLine("2. Квадрат");
                Console.WriteLine("3. Прямоугольник");
                Console.WriteLine("Нажмите Escape, чтобы вернуться");

                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice == '1')
                {
                    form = "Круг";
                }
                else if (choice == '2')
                {
                    form = "Квадрат";
                }
                else if (choice == '3')
                {
                    form = "Прямоугольник";
                }
                else if (choice == (char)27)
                {
                 
                }
            }
        
            else if (choice == '2')
            {
                Console.WriteLine("Пожалуйста, выберите размер:");
                Console.WriteLine("1. Маленький");
                Console.WriteLine("2. Средний");
                Console.WriteLine("3. Большой");
                Console.WriteLine("Нажмите Escape, чтобы вернуться");

                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice == '1')
                {
                    size = "Маленький";
                }
                else if (choice == '2')
                {
                    size = "Средний";
                }
                else if (choice == '3')
                {
                    size = "Большой";
                }
                else if (choice == (char)27)
                {
                   
                }
            }
   
            else if (choice == '3')
            {
                Console.WriteLine("Пожалуйста, выберите вкус:");
                Console.WriteLine("1. Ваниль");
                Console.WriteLine("2. Шоколад");
                Console.WriteLine("3. Клубника");
                Console.WriteLine("Нажмите Escape, чтобы вернуться");

                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice == '1')
                {
                    taste = "Ваниль";
                }
                else if (choice == '2')
                {
                    taste = "Шоколад";
                }
                else if (choice == '3')
                {
                    taste = "Клубника";
                }
                else if (choice == (char)27)
                {
          
                }
            }
          
            else if (choice == '4')
            {
                Console.WriteLine("Пожалуйста, выберите количество:");
                int.TryParse(Console.ReadLine(), out quantity);
            }
         
            else if (choice == '5')
            {
                Console.WriteLine("Пожалуйста, выберите глазурь:");
                Console.WriteLine("1. Шоколад");
                Console.WriteLine("2. Ваниль");
                Console.WriteLine("3. Клубника");
                Console.WriteLine("Нажмите Escape, чтобы вернуться");

                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice == '1')
                {
                    icing = "Шоколад";
                }
                else if (choice == '2')
                {
                    icing = "Ваниль";
                }
                else if (choice == '3')
                {
                    icing = "Клубника";
                }
                else if (choice == (char)27)
                {
                   
                }
            }
            
            else if (choice == '6')
            {
                Console.WriteLine("Пожалуйста, выберите украшение:");
                Console.WriteLine("1. Посыпка");
                Console.WriteLine("2. Шоколадные чипсы");
                Console.WriteLine("3. Фрукты");
                Console.WriteLine("Нажмите Escape, чтобы вернуться");

                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice == '1')
                {
                    decoration = "Посыпка";
                }
                else if (choice == '2')
                {
                    decoration = "Шоколадные чипсы";
                }
                else if (choice == '3')
                {
                    decoration = "Фрукты";
                }
                else if (choice == (char)27)
                {
                    
                }
            }
           
            else if (choice == (char)27)
            {
                Console.WriteLine("Спасибо, что пользуетесь нашей пекарней! Хорошего дня!");
                return;
            }
            
            price = quantity * 5;

           
            Order order = new Order();
            order.form = form;
            order.size = size;
            order.taste = taste;
            order.quantity = quantity;
            order.icing = icing;
            order.decoration = decoration;
            order.price = price;

            // Print the order details
            Console.WriteLine("Информация для заказа:");
            Console.WriteLine("Форма: " + order.form);
            Console.WriteLine("Размер: " + order.size);

            Console.WriteLine("Вкус: " + order.taste);
            Console.WriteLine("Количество: " + order.quantity);
            Console.WriteLine("Глазурь: " + order.icing);
            Console.WriteLine("Декорация: " + order.decoration);
            Console.WriteLine("Цена: " + order.price);
            Console.WriteLine("Вы хотите разместить еще один заказ? Нажмите «y» для «да» и любую другую клавишу для выхода.");
            choice = Console.ReadKey().KeyChar;
        } while (choice == 'y');
        Console.WriteLine("Спасибо за ваш заказ. Хорошего дня!");
        Console.ReadKey();
    }
}