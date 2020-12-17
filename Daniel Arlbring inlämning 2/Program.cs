using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace Daniel_Arlbring_inlämning_2
{
    class GroupMembers
    {
        // listan på alla variabler
        private string firstName;

        private string lastName;
        private int age;
        private string city;
        private string home;
        private string family;
        private string pets;
        private string lastJob;
        private string hobby;
        private string favouriteFood;
        private string favouriteMusic;

        private string drive;
        


        public GroupMembers()
        {

        }

        public GroupMembers(string firstName, string lastName, int age, string city, string home, string family, string pets, string profession, string hobby, string favFood, string favMusic, string drive)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.city = city;
            this.home = home;
            this.family = family;
            this.pets = pets;
            this.lastJob = profession;
            this.hobby = hobby;
            this.favouriteFood = favFood;
            this.favouriteMusic = favMusic;
            this.drive = drive;

        }
        //properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Home
        {
            get { return home; }
            set { home = value; }
        }
        public string Family
        {
            get { return pets; }
            set { pets = value; }
        }
        public string Pets
        {
            get { return pets; }
            set { pets = value; }
        }
        public string Lastjob
        {
            get { return lastJob; }
            set { lastJob = value; }
        }
        public string Hobby
        {
            get { return hobby; }
            set { hobby = value; }
        }
        public string Favouritefood
        {
            get { return favouriteFood; }
            set { favouriteFood = value; }
        }
        public string Favouritemusic
        {
            get { return favouriteMusic; }
            set { favouriteMusic = value; }
        }

        public string Drive
        {
            get { return drive; }
            set { drive = value; }
        }


        public string Describe()
        {
            return $"Namn namn: {firstName}\n" +
                $"Stad: {City}\n" +
                $"Boende: {Home}\n" +
                $"Familj: {Family} \n" +
                $"Husdjur: {Pets}\n" +
                $"Senaste yrke: {lastJob}\n" +
                $"Hobby: {Hobby}\n" +
                $"Favoritmat: {favouriteFood}\n" +
                $"Favoritmusik: {favouriteMusic}\n";
        }
        class Program
        {
            static public void Exitprogram(int condition)
            {
                if (condition == 0)
                {
                    return;
                }
                else
                {
                    Menu();
                }
            }
            static void Main(string[] args)
            {

                Console.WriteLine("Välkommen till Basgruppen Coffencode");
                Inlogg();
            }
            static void Inlogg()
            {
                string lösenord = "";

                while (lösenord != "coffencode")
                {
                    Console.Write("Vänligen ange kod: ");
                    lösenord = Console.ReadLine();
                    if (lösenord == "q")
                    {
                        Console.WriteLine("Tack och välkommen åter!");
                        break;
                    }
                    else if (lösenord == "coffencode")
                    {
                        Console.WriteLine("Du är inloggad!");
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Fel kod, vänligen försök igen eller ange q + Enter för att avsluta");
                    }
                }
            }



            //Lägger till en lista för alla i gruppen som menyalternativ.
            public static void Menu()
            {
                GroupMembers Mikael = new GroupMembers("Mikael", "Alexander Larsson", 36, "Vänersborg", "Villa", "Fru, två döttrar och en tredje dotter på väg", "Två kaniner", "Restauranglärare", "Träning och hälsa, surdegsbröd", "Bönchiligryta i tortillabröd", "Elektroniskt. Allt mellan ambient och techno", "Mitt största driv är att det är härligt att få den dagliga hjärngympan man får med programmering, att det är kreativt och att man faktiskt skapar en produkt i slutändan");
                GroupMembers Madeleine = new GroupMembers("Karin", "Madeleine Karlsson", 35, "Stockholm", "Villa", "Smabo och en dotter", "Tre katter", "ekonomiassistent/testare", "Bakning och spela Stardew Valley ", "Någon form av biff, sötpotatispommes och beanésås", "Just nu, allt som inte är barnvisor", "Har alltid tyckt det är intressant hur system är uppbyggda och hur de skapas, så nu vill jag kunna göra det själv.");
                GroupMembers Sammy = new GroupMembers("Sammy", "On Tat Wong", 54, "Åmål", "Villa", "Fru och en son", "3 katter och en hund", "Personlig assistent", "Fotografering, matlagning", "Asiatisk, italiensk, svensk husmanskost", "Soul, RnB, House", " Att kunna skapa någonting själv, problemlösning och tillfredsställelse när man har löst ett problem.");
                GroupMembers David = new GroupMembers("David", "Josef Frödin", 25, "Sundbyberg", "Lägenhet", "det vanliga", "inga", "Verksamhetschef på en studentförening", "Leta efter universums hemligheter, målning, lära sig språk", "Bortsch", "Allt! Inne i rockperiod som varvas med rysk folkmusik", "Det är ballt och jag får kombinera kreativitet, problemlösning och människoperspektiv i en trevlig mix");
                GroupMembers Rauf = new GroupMembers("Rauf", "Karimli", 36, "Göteborg", "Villa ", "Fru, en son och en dotter", "inga ", "Projektledare ", "Spela piano, laga mat", "Grillat kött", "Gott och blandat", "De gränslösa möjligheterna att utveckla och utvecklas");
                GroupMembers Erik = new GroupMembers("Erik", "Rindlert", 31, "Stockholm", "Lägenhet", "Ogift", "Inga", " IT-support", "Litteratur, datorspel", "Svensk-fransk fisksoppa", "Schubert eller Darkthrone, beroende på dag", "Bygga, bygga, bygga");
                GroupMembers Daniel = new GroupMembers("Daniel", "Jacob Arlbrin", 24, "Alingsås", "lägenhet", "Sambo", "Inga", "Väktare", "Motorsport/datorspel", "Italienskt", "House", "Saknas");
                GroupMembers Svante = new GroupMembers("Svante", "Joelsson", 36, "Strömstad", "Lägenhet", "Sambo och en son", "Hund", "Fritidspedagog/Förskolelärare", "Illustrera Animera", "Pasta al fungi", "Gubbrock och allt som är bra", "Kul combo av problemlösning och kreativitet, och att en dag landa ett jobb med mer frihet");
                GroupMembers Sarah = new GroupMembers("Sarah", "Winroth", 31, "Vara ", "Lägenhet ", "Gift ", "Inga ", "Reseledare ", "Motionerar", "Älskar mat i alla former", " Lyssnar på det mesta", "Själva problemlösningen och tillfredsställelsen efteråt");
                GroupMembers Farzane = new GroupMembers("Farzane", "Zafarzade", 32, "Karlstad", "lägenhet", "Gift ", "Inga ", "IT-support", "Träning och bakning", "Alla typer av pastarätter", "lugna och klassikermusik", "Problemlösning, inom att lösa problem man lär sig att bli mer tålmodig och kreativ.");

                int condition = 1;

                void Continue()
                {
                    Console.WriteLine("Vill du se fler val? (1.JA,2.NEJ)");
                    string halloj = Console.ReadLine();
                    if (halloj == "1")
                    {
                        Console.Clear();
                        return;
                        

                    }
                    else
                    {
                        Console.WriteLine("Tack för denna gången!");
                        condition = 0;


                    }


                }

                string pick = null;
                List<GroupMembers> Members = new List<GroupMembers>() { Mikael, Madeleine, Sammy, David, Rauf, Erik, Daniel, Svante, Sarah, Farzane };

                while (condition == 1)
                {
                    Console.WriteLine("1. Skriv ut alla namnen i Coffencode");
                    Console.WriteLine("2. Information om alla i gruppen");
                    Console.WriteLine("3. Ta bort valfri person");
                    Console.WriteLine("q. Avsluta programmet");

                    pick = Console.ReadLine();
                    // cases för att få välja i menyn.
                    switch (pick)
                    {
                        case "1":
                            Console.WriteLine("Du har valt menyval nummer 1");
                            foreach (var member in Members)
                            {

                                Console.WriteLine($"{member.FirstName} " + $"{member.lastName},");
                            }
                            Console.WriteLine("");
                            Console.WriteLine("_____________________");

                            Continue();
                            break;
                        case "2":
                            Console.WriteLine("Du har valt menyval nummer 2");

                            Console.WriteLine("Välj en gruppmeldem för att få mer information:");
                            int i = 0;
                            foreach (var member in Members)
                            {
                                i++;
                                
                                Console.WriteLine($"{i}.{member.FirstName} " + $"{member.lastName}");
                            }
                            int memberpick = Convert.ToInt32(Console.ReadLine());
                            memberpick--;
                           



                            Console.WriteLine($"{Members[memberpick].FirstName} är {Members[memberpick].Age} år gammal och bor i en {Members[memberpick].Home} i {Members[memberpick].City}.");
                            Console.WriteLine($"{Members[memberpick].FirstName}s familj: {Members[memberpick].Family}. Husdjur: {Members[memberpick].Pets}. Hobby: {Members[memberpick].Hobby}");
                            Console.WriteLine($"{Members[memberpick].FirstName}s favorit mat: {Members[memberpick].Favouritefood}");
                            Console.WriteLine($"{Members[memberpick].FirstName}s favorit musik/band: {Members[memberpick].Favouritemusic}");
                            Console.WriteLine($"{Members[memberpick].FirstName}s drivkraft i programmering: {Members[memberpick].drive}");
                            Console.WriteLine("");
                            Console.WriteLine("_____________________");
                           
                            Continue();
                            break;
                      


                        case "3":
                            Console.WriteLine("Du har valt menyval 3");
                            Console.WriteLine("Radera en medlem i listan:");
                            int x = 0;
                            foreach (var member in Members)
                            {
                                x++;
                                Console.WriteLine($"{x}. {member.FirstName}");
                            }

                            int deletepick = Convert.ToInt32(Console.ReadLine());
                            deletepick--;
                            Console.WriteLine(Members[deletepick].FirstName + " har raderats från listan!");
                            Members.Remove(Members[deletepick]);
                            Console.WriteLine("_____________________");
                            Console.WriteLine("");
                            
                            Continue();
                            break;

                        case "q":

                            Console.WriteLine("Tack och välkommen åter");
                            condition = 0;
                            
                            break;
                            // inte säker på att detta är det bästa alternativet, men fick det att fungera.
                        default:
                            if (pick != "4" || pick != "3" || pick != "2" || pick != "1" || pick != "q")
                            {
                                Console.WriteLine("Finns ej. Välj mellan 1-4");
                            }
                            break;
                    }
                }
            } 
        }




    }

}

























