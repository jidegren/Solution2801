using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassOvning12
{
    class Program
    {
        static List<Person> myContactList = new List<Person>();
        static void Main(string[] args)
        {
            bool ok = true;

            do
            {
                Console.WriteLine("Welcome, lets create a ContactList");
                Console.WriteLine("Enter a firstname");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter a phonenumber");
                string phoneNumber = Console.ReadLine();
                Console.WriteLine("Enter a email");
                string email = Console.ReadLine();
                Console.WriteLine("Enter your home adress");
                string homeAdress = Console.ReadLine();
                Console.WriteLine("Enter your work adress");
                string workAdress = Console.ReadLine();

                AddPerson(firstName, phoneNumber, email, homeAdress, workAdress);

                Console.WriteLine("Do you want to enter another person, [Y]es or [N]o?");
                var keepMakingPeople = Console.ReadKey(true).Key;
                switch (keepMakingPeople)
                {
                    case ConsoleKey.Y:
                        ok = true;
                        break;
                    case ConsoleKey.N:
                        ok = false;
                        break;
                }
            } while (ok);


            ShowFirstNameInList();
            Console.WriteLine("Remove a Person from the list");
            string removeFirstName = Console.ReadLine();
            RemovePerson(removeFirstName);
            Console.Clear();
            ShowFirstNameInList();
            SortList();
            Console.Clear();
            ShowFirstNameInList();

            Console.WriteLine("Enter a Person that you would like to modify");
            string personToChange = Console.ReadLine();
            Console.WriteLine("Would you like to change [F]irstName?");
            Console.WriteLine("Would you like to change [E]mail?");
            Console.WriteLine("Would you like to change [P]honeNumber?");
            Console.WriteLine("To [Q]uit");
            var keyChoice = Console.ReadKey(true).Key;
            bool keepGoing = true;
            do
            {
                switch (keyChoice)
                {
                    case ConsoleKey.F:
                        Console.WriteLine("Enter the name you want insted");
                        string changeName = Console.ReadLine();
                        ChangeFirstName(changeName, personToChange);
                        break;

                    case ConsoleKey.E:
                        Console.WriteLine("Enter the email you want insted");
                        string changeEmail = Console.ReadLine();
                        ChangeEmail(changeEmail, personToChange);
                        break;

                    case ConsoleKey.P:
                        Console.WriteLine("Enter the Phonenumber you want insted");
                        string newPhoneNumber = Console.ReadLine();
                        ChangePhoneNumber(newPhoneNumber, personToChange);
                        break;

                    case ConsoleKey.Q:
                        keepGoing = false;
                        break;
                }
            } while (keepGoing);


        }


        private static void ChangeFirstName(string changeName, string personToChange)
        {
            myContactList.Find(x => x.FirstName == personToChange).FirstName = changeName;
        }
        private static void ChangeEmail(string changeEmail, string personToChange)
        {
            myContactList.Find(x => x.FirstName == personToChange).Email = changeEmail;
        }

        private static void ChangePhoneNumber(string phoneNumber, string personToChange)
        {
            myContactList.Find(x => x.FirstName == personToChange).PhoneNumber = phoneNumber;
        }

        private static void SortList()
        {
            var sortedList = myContactList.OrderBy(x => x.FirstName).ToList();
            myContactList = sortedList;
        }

        private static void ShowFirstNameInList()
        {
            foreach (var person in myContactList)
            {
                Console.WriteLine(person.FirstName);
            }
        }

        private static void RemovePerson(string firstName)
        {
            for (int i = 0; i < myContactList.Count; i++)
            {

                if (myContactList[i].FirstName.Equals(firstName))
                {
                    myContactList.RemoveAt(i);
                }
            }
        }

        private static void AddPerson(string firstName, string phoneNumber, string email, string workAdress, string homeAdress)
        {
            Person myPerson = new Person();
            Adress myHomeAdress = new Adress();
            Adress myWorkAdress = new Adress();
            myPerson.FirstName = firstName;
            myPerson.PhoneNumber = phoneNumber;
            myPerson.Email = email;
            myPerson.HomeAdress = myHomeAdress;
            myPerson.WorkAdress = myWorkAdress;
            myHomeAdress.Gata = homeAdress;
            myHomeAdress.Kommun = "Gråbo";
            myWorkAdress.Gata = workAdress;
            myWorkAdress.Kommun = "Gråbo";
            
            
            

            myContactList.Add(myPerson);
        }
    }
}
