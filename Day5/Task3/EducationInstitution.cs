namespace Task3
{
    public abstract class EducationInstitution
    {
        public string Name { get; set; }

        protected EducationInstitution(string name)
        {
            Name = name;
        }

        public abstract void DisplayInfo();
    }
}