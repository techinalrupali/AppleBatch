using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.Containment
{
    class Order
    {
        int orderid;
        string orderdate;
        Customer cust= new Customer();
        Item item=new Item();

        public Order(int orderid, string orderdate, Customer cust, Item item)
        {
            this.Orderid = orderid;
            this.Orderdate = orderdate;
            this.Cust = cust;
            this.Item = item;
        }
        public Order()
        {

        }

        public int Orderid { get => orderid; set => orderid = value; }
        public string Orderdate { get => orderdate; set => orderdate = value; }
        internal Customer Cust { get => cust; set => cust = value; }
        internal Item Item { get => item; set => item = value; }
    }

    class Customer
    {
        Address1 ad=new Address1();
        string cust_name;
        long moblie_no;

        public Customer(Address1 ad, string cust_name, long moblie_no)
        {
            this.Ad = ad;
            this.Cust_name = cust_name;
            this.Moblie_no = moblie_no;
        }
        

        public Customer()
        {

        }
        public string Cust_name { get => cust_name; set => cust_name = value; }
        public long Moblie_no { get => moblie_no; set => moblie_no = value; }
        public Address1 Ad { get => ad; set => ad = value; }
    }
    class Address1
    {
        string street1;
        string city1;

        public Address1(string street1, string city1)
        {
            this.Street1 = street1;
            this.City1 = city1;
        }

        public Address1()
        {

        }
        public string Street1 { get => street1; set => street1 = value; }
        public string City1 { get => city1; set => city1 = value; }
    }
    class Item
    {
        int item_id;
        string product_name;
        int product_price;

        public Item(int item_id, string product_name, int product_price)
        {
            this.Item_id = item_id;
            this.Product_name = product_name;
            this.Product_price = product_price;
        }

        public Item()
        {

        }
        public int Item_id { get => item_id; set => item_id = value; }
        public string Product_name { get => product_name; set => product_name = value; }
        public int Product_price { get => product_price; set => product_price = value; }
    }

    class OrderTest
    {
        static void Main(string[] args)
        {
            Order o1 = new Order();
            o1.Orderid = 100;
            o1.Orderdate = "10/04/2022";
            o1.Cust.Ad.Street1= "Hotagi Road";
            o1.Cust.Ad.City1 = "Solapur";
            o1.Cust.Cust_name = "Rupali Birajdar";
            o1.Cust.Moblie_no = 9852364178;
            o1.Item.Item_id = 5;
            o1.Item.Product_name = "Shoes";
            o1.Item.Product_price = 300;

            Console.WriteLine("Orderid="+o1.Orderid);
            Console.WriteLine("Orderdate="+o1.Orderdate);
            Console.WriteLine("Cust_Ad_Street="+o1.Cust.Ad.Street1);
            Console.WriteLine("Cus_Ad_City="+o1.Cust.Ad.City1);
            Console.WriteLine("Cust_Name="+o1.Cust.Cust_name);
            Console.WriteLine("Mobile Number="+o1.Cust.Moblie_no);
            Console.WriteLine("Item Id="+o1.Item.Item_id);
            Console.WriteLine("Product Name="+o1.Item.Product_name);
            Console.WriteLine("Product Price="+o1.Item.Product_price);
        }
    }
}
