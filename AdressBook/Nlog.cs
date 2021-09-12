﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Address_book
{
    public class Contacts  //created class contact
    {
        //by using encapsulation
        public string first_name { get; set; } //property
        public string last_name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public int phone_no { get; set; }
        public string email { get; set; }
    }
    public class Nlog //created class for different oprations
    {

        //list declaration to store the personal details
        List<Contacts> listcontacts = new List<Contacts>();

        public void Add()//add method 
        {
            Console.WriteLine("Enter Personal Details : ");
            Console.Write("First Name : ");
            string first_name = Console.ReadLine();
            Console.Write("Last Name : ");
            string last_name = Console.ReadLine();
            Console.Write("Address : ");
            string address = Console.ReadLine();
            Console.Write("City : ");
            string city = Console.ReadLine();
            Console.Write("State : ");
            string state = Console.ReadLine();
            Console.Write("Zip Code : ");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phone No. : ");
            int phone_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("E-mail ID : ");
            string email = Console.ReadLine();

            //adding the details in list
            listcontacts.Add(new Contacts()
            {
                first_name = first_name,
                last_name = last_name,
                address = address,
                city = city,
                state = state,
                zip = zip,
                phone_no = phone_no,
                email = email
            });
        }

    }
}