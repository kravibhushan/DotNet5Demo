using System;

namespace Oops
{
    public class GrandChild : Child
    {
        static GrandChild()
        {
            Console.WriteLine("Static constructor Grand Child");
        }
        public GrandChild(int id) : base(id)
        {
            Console.WriteLine("From overloaded Grand Child Constructor");
        }
        ~GrandChild()
        {
            Console.WriteLine("GrandChild Disctructor");
        }
    }
}
