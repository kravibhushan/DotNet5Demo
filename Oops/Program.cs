using Oops;
using static System.Console;

//namespace Opps
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            WriteLine("Hello World!");
//        }
//    }
//}

//WriteLine("Hello World!");
Display();

void Display()
{
    //Parent obj1 = new Parent(10);
    //Parent obj2 = new Parent(20);
    //Parent obj3 = new Parent(40);
    //Child c1 = new Child(10);
    //Child c2 = new Child(20);
    //Child c3 = new Child(40);
    //Parent p= new Child(10);
    Parent pg = new GrandChild(10);

    ReadLine();
}