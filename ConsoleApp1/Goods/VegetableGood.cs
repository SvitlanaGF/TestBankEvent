namespace ConsoleApp1.Goods;  //наш файл у папці Goods, яка в папці ConsoleApp1

public class VegetableGood  // клас товару VegetableGood 
{  // фігурна дужка
    public VegetableGood(int price, string name) // конструктор класу VegetableGood, передаємо ціну товару цілим числом та ім'я строкою 
    {  // фігурна дужка
        Price = price;  // присвоюємо для об'єкта в Price значення переданого price
        Name = name;  // присвоюємо для об'єкта в Name значення переданого name
    }  // фігурна дужка

    public int Price { get; set; }  // ціна товару
    public string Name { get; set; }  // назва товару
}  // фігурна дужка
