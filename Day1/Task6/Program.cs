class Program
{
    static void Main()
    {
        Console.Write("Введите номер телевизионного канала: ");
        int channel = int.Parse(Console.ReadLine());

        switch (channel)
        {
            case 1:
                Console.WriteLine("На канале 1 популярные программы: \"Время\", \"Голос\", \"Поле чудес\"");
                break;
            case 2:
                Console.WriteLine("На канале 2 популярные программы: \"Новости 24\", \"Танцы со звёздами\"");
                break;
            case 3:
                Console.WriteLine("На канале 3 популярные программы: \"КВН\", \"Что? Где? Когда?\", \"Умницы и умники\"");
                break;
            case 4:
                Console.WriteLine("На канале 4 популярные программы: \"Дом-2\", \"Битва экстрасенсов\"");
                break;
            case 5:
                Console.WriteLine("На канале 5 популярные программы: \"Вести\", \"60 минут\", \"Вечерний Ургант\"");
                break;
            default:
                Console.WriteLine("Информация о программах для данного канала отсутствует");
                break;
        }
    }
}