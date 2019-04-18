namespace CSharp_Basics
{
    public class ItEmployee : Employee
    {
        public string ProgrammingLanguage { get; }
        public ItEmployee(string name, int badgeId, string location, string programmingLanguage) : base(name, badgeId, location)
        {
            this.ProgrammingLanguage = programmingLanguage;
        }

        public ItEmployee(string name, int badgeId, Locations location, string programmingLanguage) : base(name, badgeId, location)
        {
            this.ProgrammingLanguage = programmingLanguage;
        }

        public new string PrintEmployee()
        {
            return $"Name: {Name} Badge: {BadgeID} Lang: {ProgrammingLanguage}";
        }
    }
}