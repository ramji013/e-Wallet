using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project5
{
    public class Customers
    {
        public Customer[] data { get; set; }
        public Collection collection { get; set; }
    }

    public class Collection
    {
        public int current_page { get; set; }
        public int per_page { get; set; }
        public int total_entries { get; set; }
        public int total_pages { get; set; }
    }

    public class Customer
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public object additional_first_name { get; set; }
        public object title { get; set; }
    }
}

