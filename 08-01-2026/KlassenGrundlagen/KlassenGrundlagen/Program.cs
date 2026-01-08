namespace KlassenGrundlagen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanzierung deshalb auch new weil wir etwas neues erzeugen
            Employee ma1 = new Employee("Max", "Musterman", new DateTime(2006, 02, 15));
          
            ma1.Name = "Max";
            ma1.Surname = "Musterman";
            ma1.id = Guid.NewGuid();
            ma1.Sallery = 2000.0m;
            ma1.Birthday = new DateTime(2006, 02, 15);

            ma1.Display();

            //bonud geben
            ma1.GiveBonus(0.2);

            Console.WriteLine($"Neues Gehalt: EUR {ma1.Sallery.ToString("#,###.00")})");


            //wörter
            //klasse ist wie manusktipt
            //onjekt ist wie eine kopie von manuskipt also 
            //von der klasse wird das Objekt und Instanz
            //von der klasse Employee eine ma1 instanz hergestellt

          
        }
    }
}
