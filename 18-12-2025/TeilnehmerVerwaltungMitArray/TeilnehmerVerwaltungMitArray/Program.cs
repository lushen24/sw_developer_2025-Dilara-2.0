using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeilnehmerVerwaltungMitArray.Datentypen;

namespace TeilnehmerVerwaltungMitArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Erfassen von Teilnehmerdaten (1x):
             * - Name
             * - Wohnort & PLZ
             * - Geburtsdatum (DateTime)
             * 
             * - User-Freundliches Design 
             * - Fehlertolerante Umsetzung der Eingaben
             * - Formatierte Zusammenfassung der Teilnehmerdaten ausgeben
             * 
             * */           
            string userInput = string.Empty;
            int count = 0;
            //Deklaration 
            Teilnehmer einTeilnehmer;
            Teilnehmer[] teilnehmerListe;

            //Initialisierung
            //einTeilnehmer.Name = string.Empty;
            //einTeilnehmer.Wohnadresse.Wohnort = string.Empty;
            //einTeilnehmer.Wohnadresse.Plz = 0;
            //einTeilnehmer.Geburtsdatum = DateTime.MinValue;

            //1. Ausgabe Header
            CreateHeader("Teilnehmer-Verwaltung v3.0");

            //1.b Abfrage Anzahl der zu erfassenden Teilnehmer
            count = GetInt("Bitte die Anzahl der Teilnhmer angeben (0 = ENDE): ");
            teilnehmerListe = new Teilnehmer[count];
            for (int i = 0; i < count; i++)
            {
                //2. Teilnehmerdaten erfassen
                einTeilnehmer = GetTeilnehmerData();

                //4. Daten persistieren (File)
                string filename = CreateFilename(einTeilnehmer);
                WriteFile(filename, einTeilnehmer);

                //Neuen Teilnehmer:in in die Liste hinzufügen
                teilnehmerListe[i] = einTeilnehmer;     // wenn man [] muss die es mehrzahl sein
            }

            //3. Ausgabe der Daten
            Console.WriteLine("\nFolgende Daten wurden erfasst:\n");
            DisplayTeilnehmerData(teilnehmerListe);
         

            
        }

        private static void WriteFile(string filename, Teilnehmer tn)
        {
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.Write(tn.Name + ";");
                sw.Write(tn.Geburtsdatum.ToShortDateString() + ";");
                sw.Write(tn.Wohnadresse.Strasse + ";");
                sw.Write(tn.Wohnadresse.HausNr + ";");
                sw.Write(tn.Wohnadresse.Plz + ";");
                sw.WriteLine(tn.Wohnadresse.Wohnort + ";");                
            }
        }

        private static string CreateFilename(Teilnehmer einTeilnehmer)
        {
            //martin müller_1980.txt
            //string filename = einTeilnehmer.Name + "_" + einTeilnehmer.Geburtsdatum.Year + ".csv";

            //return filename.Replace(' ', '_');

            return "meine TeilnehmerListe.csv";


        }


        private static void DisplayTeilnehmerData(Teilnehmer[] teilnehmerListToDisplay)
        {
            for (int i = 0; i < teilnehmerListToDisplay.Length; i++)
            {
                DisplayTeilnehmerData(teilnehmerListToDisplay[i]);
                Console.WriteLine();
                    
            }

        }

        private static void DisplayTeilnehmerData(Teilnehmer teilnehmerToDisplay)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t" + teilnehmerToDisplay.Name);
            Console.WriteLine("\t" + teilnehmerToDisplay.Wohnadresse.Plz + " " + teilnehmerToDisplay.Wohnadresse.Wohnort);
            Console.WriteLine("\t" + teilnehmerToDisplay.Geburtsdatum.ToLongDateString());
            Console.WriteLine();
            Console.ResetColor();
        }

        private static Teilnehmer GetTeilnehmerData()
        {
            Teilnehmer einTeilnehmer = new Teilnehmer();

            Console.WriteLine("Bitte geben Sie folgende Teilnehmer-Daten ein:");
            Console.Write("\tName: ");
            einTeilnehmer.Name = Console.ReadLine();

            Console.Write("\tWohnort: ");
            einTeilnehmer.Wohnadresse.Wohnort = Console.ReadLine();

            einTeilnehmer.Wohnadresse.Plz = GetInt("\tPlz: ");
            einTeilnehmer.Geburtsdatum = GetDateTime("\tGeburtstag (dd.mm.yyyy): ");

            return einTeilnehmer;
        }

        static DateTime GetDateTime(string inputPrompt)
        {
            bool isUserInputValid;
            DateTime inputValue = DateTime.MinValue;

            do
            {
                try
                {
                    Console.Write(inputPrompt);
                    inputValue = DateTime.Parse(Console.ReadLine());

                    isUserInputValid = true;
                }
                catch
                {
                    isUserInputValid = false;
                }
            }
            while (isUserInputValid == false);

            return inputValue;
        }

        static int GetInt(string inputPrompt)
        {
            int inputValue = 0;
            bool isUserInputValid;

            do
            {
                try
                {
                    Console.Write(inputPrompt);
                    inputValue = int.Parse(Console.ReadLine());
                    isUserInputValid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\aERROR: " + ex.Message);
                    isUserInputValid = false;
                }
            }
            while (isUserInputValid == false);
            
            return inputValue;
        }

        static void CreateHeader(string titleString)
        {
            int startPositionX = 0;
            //string headerString = "Teilnehmer-Verwaltung v1.0";

            string headerBorder = new string('#', Console.WindowWidth - 1);
            Console.WriteLine(headerBorder);
            startPositionX = (Console.WindowWidth - titleString.Length) / 2;
            Console.CursorLeft = startPositionX;
            Console.WriteLine(titleString);
            Console.WriteLine(headerBorder);
            Console.WriteLine();
        }
    
    }
}
