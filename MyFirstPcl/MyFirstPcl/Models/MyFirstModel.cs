using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstPcl.Models
{
    public class MyFirstModel
    {
    }
    public class Address
    {
        public string order_code { get; set; }
        public int invoice_id { get; set; }
        public string invoice_code { get; set; }
        public int le_wh_id { get; set; }
        public string date { get; set; }
        public int order_id { get; set; }
        public int is_self { get; set; }
        public string shop_name { get; set; }
        public string mobile_no { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string route { get; set; }
        public string cfc_cnt { get; set; }
        public string bags_cnt { get; set; }
        public string crates_cnt { get; set; }
        public int status { get; set; }
        public int discount { get; set; }
        public string discount_amt { get; set; }
        public string discount_type { get; set; }
        public string order_date { get; set; }
        public int cust_le_id { get; set; }
        public int delivery_bydist { get; set; }
        public int is_premium { get; set; }
        public int premium_ordervalue { get; set; }
        public int available_cashabck { get; set; }
        public int applied_cashback { get; set; }
    }

    public class Product
    {
        public int product_id { get; set; }
        public object parent_id { get; set; }
        public string product_name { get; set; }
        public string sku { get; set; }
        public string star { get; set; }
        public int ordered_qty { get; set; }
        public int invoiced_qty { get; set; }
        public int freebee_mpq { get; set; }
        public int freebee_qty { get; set; }
        public int return_qty { get; set; }
        public string mrp { get; set; }
        public int esu { get; set; }
        public int discount { get; set; }
        public string discount_amt { get; set; }
        public string discount_type { get; set; }
        public double singleUnitPrice { get; set; }
        public double singleUnitPriceWithtax { get; set; }
        public string tax_percentage { get; set; }
    }

    public class Data
    {
        public Address address { get; set; }
        public List<Product> products { get; set; }
        public List<object> discounts { get; set; }
    }

    public class RootObject
    {
        public string status { get; set; }
        public string message { get; set; }
        public Data data { get; set; }
    }
}
