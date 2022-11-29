// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Bank; //використовуємо клас із папки Goods
using ConsoleApp1.Customer;  //використовуємо клас із папки Customer
using ConsoleApp1.Shop;  //використовуємо клас із папки Shop

var legoShop = new LegoShop();  //Новий магазин

var bank = new PrivatBank(legoShop); // Банк

var user = new User() { Name = "Valentin"}; // користувач Валік

bank.Register(user); // Реєструємо Валіка в банку

legoShop.Start(user); // Починаємо подію

Console.ReadKey();  // для чогось ще записуємо чар у консолі
