using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class Groomer
    {
        /* 
            A groomer is someone who is employed to groom pets
            Some things that describe a groomer
                - First Name
                - Last Name
                - Date of Birth
                - Phone Number
                - Hourly Rate

            A booking must reference to a groomer
        */
        [Key]
        public int GroomerId { get; set; }
        public String GroomerFname { get; set; }

        public String GroomerLname { get; set; }

        public DateTime GroomerDob { get; set; }


        public String GroomerPhone { get; set; }

        //rate is calculated in terms of cents like $25/hr = 2500 cents/hr
        public int GroomerRate { get; set; }



    }
}