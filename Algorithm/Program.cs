using Algorithm.Icertis;
using Algorithm.ParallelPrograming;
using System;
using System.Linq;
using System.Threading;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheretence test
            //Parent parent1 = new Parent();
            //Child child1 = new Child();
            //Parent parent2 = (Parent)child1;
            //Console.WriteLine(parent1.f1());
            //Console.WriteLine(child1.f1());
            //Console.WriteLine(parent2.f1());

            //Note with the reference of clield parent can not be casted 
            //will throw run time exception
            //Child d1 = (Child)parent1;

            //SaleValues sv = new SaleValues();
            //var data = sv.GetDataFromCSV();

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.BuyerName + "--" + item.Price);
            //}

          


            Account fromAccount = new Account(1,1000.00);
            Account toAccount = new Account(2, 2000.00);

            Thread t0 = new Thread(()=> { fromAccount.WithDraw(100); });
            Thread t1 = new Thread(() => { toAccount.Deposit(100); });

            t0.Start();
            t1.Start();
          

            t0.Join();
            t1.Join();

            Console.WriteLine("Done");
            Console.ReadLine();

        }
    }

    class Parent
    {
        public virtual String f1()
        {
            return "Parent Function called";
        }
    }

    class Child : Parent
    {
        public override String f1()
        {
            return "Child Function called";
        }
    }
}
