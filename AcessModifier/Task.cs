using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessModifier
{
    internal class order
    {
        int orderid;
        string orderdate;
        Customer cust = new Customer();
        Address addr = new Address();
        Item mm = new Item();

        public order()
        {


        }
        public int Orderid { get => orderid; set => orderid = value; }
        public string Orderdate { get => orderdate; set => orderdate = value; }
        public Customer Cust { get => cust; set => cust = value; }
        public Address Addr { get => addr; set => addr = value; }
        public Item Mm { get => mm; set => mm = value; }

    }
    public class Customer
    {
        int custid;
        string custname;
        Address addr = new Address();

        public Customer()
        {


        }
        public int Custid { get => custid; set => custid = value; }
        public string Custname { get => custname; set => custname = value; }
        public Address Addr { get => addr; set => addr = value; }

    }
    public class Address
    {
        string addr1;
        string city;
        int pincode;

        public Address()
        {

        }
        public string Addr1 { get => addr1; set => addr1 = value; }
        public string City { get => city; set => city = value; }
        public int Pincode { get => pincode; set => pincode = value; }

    }
    public class Item
    {
        int itemid;
        string itemname;
        int itemprice;

        public Item()
        {

        }
        public int Itemid { get => itemid; set => itemid = value; }
        public String Itemname { get => itemname; set => itemname = value; }
        public int Itemprice { get => itemprice; set => itemprice = value; }
    }

    class orderrrrrrrrr
    {
        static void Main(string[] args)
        {
            order o1 = new order();
            o1.Orderid = 121;
            o1.Orderdate = "23 march";
            o1.Cust.Custid = 3456;
            o1.Cust.Custname = "ABCDE";
            o1.Addr.Addr1 = "XYZABCE";
            o1.Addr.City = "karad";
            o1.Addr.Pincode = 415104;
            o1.Mm.Itemid = 345;
            o1.Mm.Itemname = "FGHJKDS";
            o1.Mm.Itemprice = 5000;


            Console.WriteLine(o1.Orderid);
            Console.WriteLine(o1.Orderdate);
            Console.WriteLine(o1.Cust.Custid);
            Console.WriteLine(o1.Cust.Custname);
            Console.WriteLine(o1.Addr.Addr1);
            Console.WriteLine(o1.Addr.City);
            Console.WriteLine(o1.Addr.Pincode);
            Console.WriteLine(o1.Mm.Itemid);
            Console.WriteLine(o1.Mm.Itemname);
            Console.WriteLine(o1.Mm.Itemprice);

        }
    }


    class overloading
    {
        static int c;

        public static int C
        {
            set { c = value; }
            get { return c; }
        }
        public static void volume(double r)
        {
            double v = 4 / 3 * 22 / 7 * (r * r * r);
            Console.WriteLine("Volume of sphere" + v);
        }
        public static void volume(double h, double r)

        {
            double v = 22 / 7 * (r * r) * h;
            Console.WriteLine("Volume of cylinder " + v);


        }
        public static void volume(double l, double b, double h)
        {
            double v = l * b * h;
            Console.WriteLine("Volume of cuboid" + v);
        }
        static void Main(string[] args)
        {
            overloading.volume(4.5);
            overloading.volume(3.6, 5.6);
            overloading.volume(4.8, 7.5, 3.2);









        }
    }
    class person
    {
        int personid;
        string personname;
        vehicle v = new vehicle();

        public person()
        {


        }
        public int Personid { get => personid; set => personid = value; }
        public string Personname { get => personname; set => personname = value; }

        public vehicle V { get => v; set => v = value; }

    }
    public class vehicle
    {
        int vehicleid;
        string vehiclename;

        public vehicle()
        {

        }
        public int Vehicleid { get => vehicleid; set => vehicleid = value; }
        public string Vehiclename { get => vehiclename; set => vehiclename = value; }
    }
    class AB
    {
        static void Main(string[] args)
        {
            person p1 = new person();
            p1.Personid = 232;
            p1.Personname = "ABCDE";
            p1.V.Vehicleid = 675;
            p1.V.Vehiclename = "XYZAB";

            Console.WriteLine(p1.Personid);
            Console.WriteLine(p1.Personname);
            Console.WriteLine(p1.V.Vehicleid);
            Console.WriteLine(p1.V.Vehiclename);
        }
    }

    class pen
    {
        int caplength;
        string brand;
    }
}
    

