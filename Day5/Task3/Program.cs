namespace Task3
{
    class Program
    {
        static void Main()
        {
            EducationInstitution[] institutions = new EducationInstitution[]
            {
                new OnlineSchool("Skillbox"),
                new University("БГУ"),
                new OnlineSchool("GeekBrains"),
                new University("БНТУ")
            };

            Console.WriteLine("Поиск онлайн-школ (фильтрация по интерфейсу):");

            foreach (var inst in institutions)
            {
                if (inst is IHasOnlineCourses onlineSchool)
                {
                    inst.DisplayInfo();
                    onlineSchool.AccessPlatform();
                }
            }
        }
    }
}