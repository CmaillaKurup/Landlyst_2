﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Landlyst_2.Model
{
    public class Client
    {
        //fields
        string firstname;
        string lastname;
        string email;
        int phone;
        string address;
        int zipcode;
        

        //properties
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public int Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public int Zipcode { get => zipcode; set => zipcode = value; }
       

        //constructor
        public Client()
        {
            firstname = Firstname;
            lastname = Lastname;
            email = Email;
            phone = Phone;
            address = Address;
            zipcode = Zipcode;
        }
    }
}