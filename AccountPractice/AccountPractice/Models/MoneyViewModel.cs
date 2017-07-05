using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPractice.Models
{
    public class MoneyViewModel
    {
        public int price { get; set; }
        public DateTime date { get; set; }
        public string memo { get; set; }
        public AccountingType type { get; set; }
    }
    public enum AccountingType
    {
        收入,
        支出
    }
}