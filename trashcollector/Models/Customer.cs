using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trashcollector.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string address { get; set; }

        public int zipcode { get; set; } 

        public string weeklyPickUp{ get; set; }

        public string oneTimePickUp { get; set; }

        public double monthlyBill { get; set; }

        public int startDateTemporary { get; set; }

        public int endDateTemporary { get; set; }





    }
}