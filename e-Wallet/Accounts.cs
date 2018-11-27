using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eWallet
{
    public class Accounts
    {
        public Account[] data { get; set; }
        public AccountCollection collection { get; set; }
    }

    public class AccountCollection
    {
        public int current_page { get; set; }
        public int per_page { get; set; }
        public int total_entries { get; set; }
        public int total_pages { get; set; }
    }

    public class Account
    {
        public string id { get; set; }
        public string account_number { get; set; }
        public object iban { get; set; }
        public double balance { get; set; }
        public double balance_available { get; set; }
        public string bic { get; set; }
        public int preauth_amount { get; set; }
        public bool is_locked { get; set; }
        public string currency { get; set; }
        public DateTime updated_at { get; set; }
    }
}