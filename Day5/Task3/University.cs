namespace Task3
{
    public class University : EducationInstitution, IHasCampus
    {
        public University(string name) : base(name) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Университет: {Name}");
        }

        public void MaintainBuildings()
        {
            Console.WriteLine($"[Кампус] В аудиториях {Name} проводится уборка.");
        }
    }
}