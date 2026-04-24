namespace Task3
{
    public class OnlineSchool : EducationInstitution, IHasOnlineCourses
    {
        public OnlineSchool(string name) : base(name) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Онлайн-школа: {Name}");
        }

        public void AccessPlatform()
        {
            Console.WriteLine($"[Платформа] Доступ к личному кабинету {Name} открыт.");
        }
    }
}