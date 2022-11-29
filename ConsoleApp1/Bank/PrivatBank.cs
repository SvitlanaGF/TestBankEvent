using ConsoleApp1.Customer;  // використовуємо клас із папки Customer
using ConsoleApp1.Goods;  // використовуємо клас із папки Goods
using ConsoleApp1.Shop;  // використовуємо клас із папки Shop

namespace ConsoleApp1.Bank; //наш файл у папці Bank, яка в папці ConsoleApp1

public class PrivatBank  // клас для створення більше нових об'єктів ПриватБанку 
{  // фігурна дужка
    private Dictionary<int, int> _bankAccount;  // приватний словник _bankAccount, де ключ цілочисельний номер рахунку користувача, а значення - к-сть грошей на рахунку

    public PrivatBank(LegoShop legoShop1)  // складаємо констрункор ПриватБанку з магазину Лего)) 
    {  // фігурна дужка
        _bankAccount = new Dictionary<int, int>(); // ні користувача, ні шиша у списку нема, головне, щоб не null

        legoShop1.UserBoughtGood += LegoShop1_UserBoughtGood;  // підписОчка на подію, де користувач купує добро
    }  // фігурна дужка
    private void LegoShop1_UserBoughtGood(User user, VegetableGood good)  // метод для виклику події
    {  // фігурна дужка
        _bankAccount.TryGetValue(user.bankAccount, out var money);  // пробуємо знайти бабло money в бідного користувача user у словничку _bankAccount за його номером рахунку bankAccount

        if (money >= good.Price) // якщо наш бідний користувач user не такий вже і бідний, ну як мінімум грошей більше, ніж у боога Прайса, то user попадає в шоу "Хто хоче стати мільйонером" з трохи іншими правилами,
        {  // фігурна дужка
            _bankAccount[user.bankAccount] = money - good.Price; // бо у нашій варіації шоу, user, із свого приватівського рахунку, віддає мільйони на золоті кабачки    
            user.AddGood(good);  // і отримує добро
            Console.WriteLine($"{good.Name} was added, remainder is {_bankAccount[user.bankAccount]}");  // виводиться блага вість, що 
            return;  // поворот (не туди пхд)
        }  // фігурна дужка

        Console.WriteLine($"{good.Name} wasn't added, because remainder is {_bankAccount[user.bankAccount]}");
    }  // фігурна дужка

    public bool Register(User user)  // реєструємо користувача
    {  // фігурна дужка
        var usersMoney = 2000;  // даємо йому трошки грошей
        var isAdded = _bankAccount.TryAdd(user.bankAccount, usersMoney); // додаємо у словник і повертаємо true, якщо його додали

        return isAdded; // повертаємо true або false
    }  // фігурна дужка
}  // фігурна дужка
