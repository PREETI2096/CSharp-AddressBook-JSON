using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        public void addContact()
        {
            List<Contact> list = new List<Contact>();
            list.Add(new Contact() { firstName = "Preeti", lastName = "Ghatage", address = "Navalur", city = "Dharwad", state = "Karnataka", zipcode = "580093", phoneNumber = "8553256634", email = "pree@gmail.com" });
            list.Add(new Contact() { firstName = "usha", lastName = "a", address = "Navalur", city = "Dharwad", state = "Karnataka", zipcode = "580093", phoneNumber = "8553256634", email = "pree@gmail.com" });
            list.Add(new Contact() { firstName = "shravi", lastName = "sn", address = "Navalur", city = "Dharwad", state = "Karnataka", zipcode = "580093", phoneNumber = "8553256634", email = "pree@gmail.com" });
            list.Add(new Contact() { firstName = "bharti", lastName = "deshmukh", address = "navanagar", city = "hubli", state = "ap", zipcode = "650098", phoneNumber = "9087675413", email = "bd@gmail.com" });
            list.Insert(3, new Contact() { firstName = "shri", lastName = "g ", address = "fg ", city = "dfg ", state = "", zipcode = "", phoneNumber = "", email = "" });
            list.Remove(new Contact() { firstName = "Preeti", lastName = "Ghatage", address = "Navalur", city = "Dharwad", state = "Karnataka", zipcode = "580093", phoneNumber = "8553256634", email = "pree@gmail.com" });
            list.RemoveAt(2);
            foreach (Contact contact in list)
            {
                Console.WriteLine(contact);
            }

            string filePath = @"D:\\AddressBook\\file.txt";

            using (StreamWriter fileWriter = new StreamWriter(filePath))
            {
                fileWriter.WriteLine("firstName,LastName,Address,City,State,zipcode,phoneNumber,email");
                foreach (Contact contact in list)
                {
                    fileWriter.WriteLine($"{contact.firstName},{contact.lastName},{contact.address},{contact.city},{contact.state},{contact.zipcode},{contact.phoneNumber},{contact.email}");
                }
            }

            List<Contact> contactInFile = new List<Contact>();

            using (StreamReader fileReader = new StreamReader(filePath))
            {
                string record = fileReader.ReadLine();

                while (!fileReader.EndOfStream)
                {
                    record = fileReader.ReadLine();
                    string[] values = record.Split(',');
                    Contact newContact = new Contact()
                    {
                        firstName = values[0],
                        lastName = values[1],
                        address = values[2],
                        city = values[3],
                        state = values[4],
                        zipcode = values[5],
                        phoneNumber = values[6],
                        email = values[7]
                    };

                    contactInFile.Add(newContact);
                }
            }
            Console.WriteLine("Read from line");
                foreach (Contact contact in contactInFile)
                {
                    Console.WriteLine($"{contact.firstName},{contact.lastName},{contact.address},{contact.city},{contact.state},{contact.zipcode},{contact.phoneNumber},{contact.email}");
                }
            }
        }
    }