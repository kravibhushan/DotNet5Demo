using static System.Console;


namespace Oops
{
    public class Child : Parent
    {
        static Child() 
        {
            WriteLine("from child static");
        }
        public Child(int id) : base(id)
        {
            WriteLine("from child Instance with parameter");
        }
    }
}
