using ConsoleApp1.Goods; // використовуємо клас із папки Goods

namespace ConsoleApp1.Customer; //наш файл у папці Customer, яка в папці ConsoleApp1

public class User  // клас для створення користувача User
{  // фігурна дужка
    public string Name { get; set; }  // ім'я користувача
    public int bankAccount { get; set; }  // номер рахунку користувача
    private List<VegetableGood> _legoGoods;  // список овочів, які в нас чарівним обазом стали Лего

    public User()  // конструктор для користувача
    {  // фігурна дужка
        _legoGoods = new List<VegetableGood>();  // надаємо нашим лего-овочам значення порожнього списку, щоб шарп не вийобувався, що в нас null
    }  // фігурна дужка
    internal void AddGood(VegetableGood nameOfGood)  // метод для додавання у список неїстівних овочів _legoGoods нового Буга(жарт для iq>100500)
    {  // фігурна дужка
        _legoGoods.Add(nameOfGood);  // додаємо овоч для юзера
    }  // фігурна дужка
}   // фігурна дужка
