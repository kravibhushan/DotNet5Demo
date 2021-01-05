
namespace Algorithm.Icertis
{
    class Parent
    {
        private int i;
        public Parent()
        {
            i = 42;
        }
        public Parent(int i)
        {
            this.i = i;
        }
        public int getInt()
        {
            return i;
        }
    }

    class C
    {
        public Parent b;
        public C()
        {
            b = new Parent(43);
        }
        public Parent getB()
        {
            return b;
        }
    }

    class D
    {
        public static int f1()
        {
            C c = new C();
            return c.getB().getInt();
        }
    }
}
