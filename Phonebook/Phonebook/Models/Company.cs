﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Company : Contact
    {
       public Company(string name, string phone,string address, UserGroup group)
        {
            PhoneNumber = phone;
            Name = name;
            userGroup = group;
            Address = address;
        }
    }
}
