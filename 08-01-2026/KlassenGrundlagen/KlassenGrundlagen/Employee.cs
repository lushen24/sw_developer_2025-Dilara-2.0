

namespace KlassenGrundlagen
{
    public class Employee
    {
        public string Name;
        public string Surname;
        public Guid id;
        public decimal Sallery;
        public DateTime Birthday;

        //user spezific construcker, dürfen meherere haben  
        public Employee(string name, string surname, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;

            id = Guid.NewGuid();
            Sallery = 1500.0m;
        }

        //bonus gehalt
        public void GiveBonus(double bonusInPercent)
        {
            if (bonusInPercent > 0 && bonusInPercent <= 1)
            {
                Sallery += Sallery * (decimal)bonusInPercent;

                int age = DateTime.Now.Year - Birthday.Year;

                decimal maxSallery = age * 100;
                if (Sallery > maxSallery)
                {
                    Sallery = maxSallery;
                }

            }
        }

        //methoden/Logik
        public void Display()
        {
            Console.WriteLine($"{Name} {Surname}");
            Console.WriteLine($"ID: {id}");

        }
    }
}
