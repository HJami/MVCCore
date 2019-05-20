using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class Travelers
    {
        public int TravelerId { get; set; }
        public string TravelerUserIdentity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string HomeAddress { get; set; }
        public string Passport { get; set; }
    }
}
