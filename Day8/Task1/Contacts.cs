namespace Task1
{
    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Телефон: {PhoneNumber}";
        }
    }
}