using ConsoleApp1.Customer;  // використовуємо клас із папки Customer
using ConsoleApp1.Goods;  // використовуємо клас із папки Goods
using System.Reflection.Metadata;  // не використовуємо Metadata

namespace ConsoleApp1.Shop;  // наш файл у папці Shop, яка в папці ConsoleApp1

public class LegoShop  // лего магазин
{  // фігурна дужка
    public event Action<User, VegetableGood> UserBoughtGood = delegate { };  // подія UserBoughtGood

    private List<VegetableGood> _goods;  // список речей

    public LegoShop()  // конструктор Lego
    {  // фігурна дужка                      
        _goods = new List<VegetableGood>() {new VegetableGood(100,"Orange") ,  // Анекдот: продаються, значить, в магазині Лего овочі:апельси, 
        new VegetableGood(50,"Tomato"),  // помідор
        new VegetableGood(500,"Peach")};  // та персик. Ок, не смішно? Так і я не клоун, щоб смішити
    }  // фігурна дужка

    public void Start(User user)  // ф-ція, яка запускає всю ланцюгову реакцію подій
    {  // фігурна дужка
        for (int i = 0; i < _goods.Count; i++)  // проходимось по списку 
        {  // фігурна дужка
            Console.WriteLine($"{i + 1}) {_goods[i].Name}");
        }  // фігурна дужка

        Console.WriteLine();
        Console.WriteLine("What do you prefer?");

        var isCanParse = int.TryParse(Console.ReadLine(), out var userChoise);

        UserBoughtGood(user, _goods[userChoise - 1]); // Кидаем ивент с пользователеи и его выбором

    }  // фігурна дужка
}  // фігурна дужка
