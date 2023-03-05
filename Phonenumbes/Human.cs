using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonenumbes
{
    internal class Human
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
        List<Human> phoneNumbers { get; set; }


        public void GenerateContacts()
        {
            phoneNumbers = new List<Human>()
            {
             new Human() {Name="giorgi1", LastName="mateshvili", Number=555100100},
               new Human() {Name="biorgi2", LastName="ateshvili", Number=551200200},
                 new Human() {Name="aiorgi3", LastName="bateshvili", Number=591300300},

            };
            SortByName();
            //foreach (var item in phoneNumbers)
            //{
            //    Console.WriteLine($"Name: {item.Name} Lastname: {item.LastName} Number:{item.Number}");
            //}

        }
        public void Dabechvda()
        {
            foreach (var item in phoneNumbers)
            {
                Console.WriteLine($"Name: {item.Name} Lastname: {item.LastName} Number:{item.Number}");
            }
        }
        public bool Validation()
        {
            Number = int.Parse(Console.ReadLine());

            int firstOne = int.Parse(Number.ToString().Substring(0, 1));
            if (firstOne != 5 && Number < 500000000 && Number > 600000000)
            {
                Console.WriteLine("araswori nomeri");
            }


            return false;
        }
        public void AddContact()
        {

            Console.WriteLine("shemoitanet saxeli");
            string name = Console.ReadLine();
            Console.WriteLine("shemoitanet gvari");
            string lastname = Console.ReadLine();
            Console.WriteLine("shemoitanet nomeri");
            int number = int.Parse(Console.ReadLine());
            

            foreach (var item in phoneNumbers)
            {


                if (Name != item.Name && LastName != item.LastName && number != item.Number)
                {

                    int firstOne = int.Parse(number.ToString().Substring(0, 1));
                    if (firstOne == 5 && number > 500000000 && number < 600000000)
                    {
                        phoneNumbers.Add(new Human() { Name = name, LastName = lastname, Number = number });
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("number dont exist");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("already exist");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }


            }
            //GenerateContacts();
        }
        public void RemoveNumber()
        {
            Console.WriteLine("washale nomeri");
            int number = int.Parse(Console.ReadLine());
            foreach (var item in phoneNumbers)
            {
                if (number == item.Number)
                {
                    phoneNumbers.Remove(item);
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("araswori  wasashleli nomeri");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }


        }
        public void SortByName()
        {
            NameComparer sortbyname = new NameComparer();
            phoneNumbers.Sort(sortbyname);
            Dabechvda();

        }
        public void SortByLastname()
        {
            LastnameComparer sortbylastname = new LastnameComparer();
            phoneNumbers.Sort(sortbylastname);
            Dabechvda();

        }
        public void UpdateContact()
        {
            Console.WriteLine("shemoitanet nomeri");
            int number = int.Parse(Console.ReadLine());
            int index = 0;
            Human tmp = new Human();
            //foreach (var item in phoneNumbers)
            //{ 
            //    if (number == item.Number)
            //    {
            //        index = phonenumbers[item]
            //    }
            //}

            for (int i = 0; i < phoneNumbers.Count; i++)
            {
                if (number == phoneNumbers[i].Number)
                {
                    tmp = phoneNumbers[i];
                    index = i;
                    Console.WriteLine("moidzebna");
                    //phoneNumbers.Remove(phoneNumbers[i]);
                    Console.WriteLine("risi shesworeba gvinda: name, lastname, number, saxgvari");
                    string whichinfo = Console.ReadLine();
                    if (whichinfo == "name")
                    {
                        Console.WriteLine("shemoitanet saxeli ");
                        phoneNumbers.Remove(phoneNumbers[i]);
                        tmp.Name = Console.ReadLine();

                        phoneNumbers.Insert(index, tmp);
                        break;
                    }
                    else if (whichinfo == "lastname")
                    {
                        Console.WriteLine("shemoitanet gvari");
                        phoneNumbers.Remove(phoneNumbers[i]);
                        tmp.LastName = Console.ReadLine();
                        phoneNumbers.Insert(index, tmp);
                        break;
                    }
                    else if (whichinfo == "number")
                    {
                        //Console.WriteLine("shemoitanet nomeri");
                        //phoneNumbers.Remove(phoneNumbers[i]);
                        Console.WriteLine("shemoitanet nomeri");
                        Number = int.Parse(Console.ReadLine());

                        int firstOne = int.Parse(Number.ToString().Substring(0, 1));
                        if (firstOne == 5 && Number > 500000000 && Number < 600000000)
                        {
                            Console.WriteLine("swori nomeri");
                            tmp.Number = Number;
                            phoneNumbers.Remove(phoneNumbers[i]);
                            phoneNumbers.Insert(index, tmp);
                            break;
                        }
                        else

                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("araswori nomeri");
                            Console.ForegroundColor = ConsoleColor.White;

                            break;
                        }


                    }
                    else if (whichinfo == "saxgvari")
                    {
                        Console.WriteLine("shemoitanet saxeli");
                        tmp.Name = Console.ReadLine();
                        Console.WriteLine("shemoitanet gvari");
                        tmp.LastName = Console.ReadLine();
                        phoneNumbers.Insert(index, tmp);
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ragac arasworia");
                        Console.ForegroundColor = ConsoleColor.White;

                        break;
                    }
                    //break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("msgavsi nomeri ar arsebobs");
                    Console.ForegroundColor = ConsoleColor.White;

                    break;
                }
            }


        }
    }
}
