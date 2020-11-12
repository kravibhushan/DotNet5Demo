using static System.Console;


namespace Oops
{
    public class Parent
    {
        public int Id { get; }
        static Parent()
        {
            WriteLine("From static parent Constructor");
        }
        public Parent(int id)
        {
            Id = id;
            WriteLine("From overloaded parent Constructor");
        }

        
    }
}
