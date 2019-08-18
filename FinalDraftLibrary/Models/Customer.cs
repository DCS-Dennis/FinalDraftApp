using System;
using System.Collections.Generic;
using System.Text;

namespace FinalDraftLibrary.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public String BusinessName { get; set; }
        public bool Private { get; set; }
        public bool Builder { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Prov { get; set; }
        public string Postal { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string BusinessPhone { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Notes { get; set; }
    }
}
