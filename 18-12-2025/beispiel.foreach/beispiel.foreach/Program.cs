using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeilnehmerVerwaltung_v3;

namespace beispiel.@foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nameList = new string[]
             { "Gandal",
                "emre",
                "sabrina",
                "louis"
             };

            Adresse[] myadresList = new Adresse[5];

            for (int i = 0; i < nameList.Length; i++)
            {
                Console.WriteLine(nameList[i]);
             }
            foreach (string name in nameList)
            {
                name = name.ToUpper();
                Console.WriteLine(name);
            }

            foreach (Adresse adr in myadresList)
            {
                //adr.Wohnort
            }


        }
    }
}
