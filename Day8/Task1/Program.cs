using Task1;

class Program
{
    static void Main()
    {
        PhoneBook myBook = new PhoneBook();

        myBook.AddContact(new Contact("Иван", "+375291112233"));
        myBook.AddContact(new Contact("Мария", "+375334445566"));
        myBook.AddContact(new Contact("Алексей", "+375259998877"));

        myBook.ShowAllContacts();

        Console.WriteLine("\nПоиск контакта 'Мария':");
        Contact found = myBook.FindByName("Мария");
        Console.WriteLine(found != null ? found.ToString() : "Не найден");

        Console.WriteLine("\nФильтрация по части номера '444':");
        myBook.SearchByNumberPart("444");

        Console.WriteLine("\nУдаление контакта 'Иван':");
        myBook.RemoveContact("Иван");
        myBook.ShowAllContacts();
    }
}