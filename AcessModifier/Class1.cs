using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p2;

namespace AcessModifier
{
    internal class Book
    {
        string bookname;

        public Book()
        {
            Console.WriteLine();
        }
    }
    internal class Bank
    {
         int bankid;
        string name;

        public Bank()
        {
            Console.WriteLine("Bank is default constructer");
        }
   
    }
    class ICIC : Bank
    {
        int bankid;
        string name;

        public ICIC()
        {
            Console.WriteLine(" ICIC bank default constructer"); 
        }
  
    }
    class program
    {
        Bank b1=new Bank(); 
        ICIC p1=new ICIC();
    }

    
}
