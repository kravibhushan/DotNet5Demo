using static System.Console;


namespace Oops
{
    public class Child : Parent
    {
        static Child()
        {
            WriteLine("Static constructor Child");
        }
        public Child(int id) : base(id)
        {
            WriteLine("From overloaded Child Constructor");
        }
        ~Child()
        {
            WriteLine("Child Disctructor");
        }
    }
}
