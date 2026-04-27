using System.Collections;

namespace Task1
{
    public class PhoneBook
    {
        private Hashtable _contacts = new Hashtable();

        public void AddContact(Contact contact)
        {
            if (!_contacts.ContainsKey(contact.Name))
            {
                _contacts.Add(contact.Name, contact);
            }
            else
            {
                Console.WriteLine($"Контакт с именем {contact.Name} уже существует.");
            }
        }

        public void RemoveContact(string name)
        {
            if (_contacts.ContainsKey(name))
            {
                _contacts.Remove(name);
                Console.WriteLine($"Контакт {name} удален.");
            }
        }

        public Contact FindByName(string name)
        {
            return (Contact)_contacts[name];
        }

        public void ShowAllContacts()
        {
            Console.WriteLine("Список всех контактов:");
            foreach (DictionaryEntry entry in _contacts)
            {
                Console.WriteLine(entry.Value);
            }
        }

        public void SearchByNumberPart(string part)
        {
            Console.WriteLine($"Поиск контактов, содержащих '{part}':");
            foreach (DictionaryEntry entry in _contacts)
            {
                Contact c = (Contact)entry.Value;
                if (c.PhoneNumber.Contains(part))
                {
                    Console.WriteLine(c);
                }
            }
        }

        public void ClearAll()
        {
            _contacts.Clear();
            Console.WriteLine("Справочник очищен.");
        }
    }
}