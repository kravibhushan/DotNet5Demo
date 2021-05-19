using static System.Console;


namespace Oops
{
    public class Parent
    {
        public int Id { get; }
        static Parent()
        {
            WriteLine("Static constructor Parent");
        }
        public Parent(int id)
        {
            Id = id;
            WriteLine("From overloaded parent Constructor");
        }
        ~Parent()
        {
            WriteLine("Parent Disctructor");
        }

    }
}
