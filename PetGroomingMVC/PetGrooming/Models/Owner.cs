﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class Owner
    {
        /*
            An owner is someone who owns one or more pets
            Some things that describe an owner:
                - First Name
                - Last Name
                - Address
                - Phone Number (work)
                - Phone Number (home)

            An owner must reference a list of pets
            
        */
        public int OwnerId { get; set; }
        public String OwnerFname
        {
            get;
            set;
        }
        public String OwnerLname { get; set; }

        public String OwnerAddress { get; set; }//address is mix of numbers and letters , so String

        // string because the format user can type can be differenc (905)-205-1202
        public String OwnerPhoneWork { get; set; }
      
        public String GroomerPhoneHome { get; set; }



    }
}