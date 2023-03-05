using Phonenumbes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human er = new Human();
            er.GenerateContacts();
            er.SortByName();
            er.AddContact();
            er.Dabechvda();
            er.RemoveNumber();
            er.Dabechvda();
            er.UpdateContact();
            er.Dabechvda();


        }
    }
}

