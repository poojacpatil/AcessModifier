using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessModifier
{
    internal class parent
    {
        public virtual void study()
        {
            Console.WriteLine("Learing from online");
        }
    }
    class child : parent
    {
        public override void study()
        {
            Console.WriteLine("Learing from offline ");
        }
    }

    class AA
    {
        static void Main(string[] args)
        {
            parent p1 = new child();
        }
    }
    class parent1
    {
        public void m1()
        {
            Console.WriteLine("Hii");
        }
        public virtual void play()
        {
            Console.WriteLine("play on ground");
        }
        internal virtual void study()
        {
            Console.WriteLine("going to school");
        }
    }
    class child1 : parent1
    {
        public void m1()
        {
            Console.WriteLine("Byy");
        }
        public override void play()
        {
            Console.WriteLine("playing videos games");
        }
        internal sealed override void study()
        {
            Console.WriteLine("online studing");
        }

    }
    class ABC
    {

        static void Main(string[] args)
        {
                parent1 p1= new child1();
                p1.play();
               p1.study();
                p1.m1();

        }       

    }
} 
    

    


