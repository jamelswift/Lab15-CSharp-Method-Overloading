using System;

public class Program
{
    public static void Main()
    {
        Derived_2 d2 = new Derived_2();
        Base b = (Base)d2;
        Derived_1 d1 = (Derived_1)d2;

        b.A();  // Calls Base.A() - because b is of type Base
        d1.A(); // Calls Derived_1.A() - because d1 is of type Derived_1
        d2.A(); // Calls Derived_2.A() - because d2 is of type Derived_2
    }
}

class Base
{
    public virtual void A()
    {
        System.Console.WriteLine("Base.A()");
    }
}

class Derived_1 : Base
{
    // Removed the 'sealed' keyword to allow further overriding
    public override void A()
    {
        System.Console.WriteLine("Derived_1.A()");
    }
}

class Derived_2 : Derived_1
{
    public override void A()
    {
        System.Console.WriteLine("Derived_2.A()");
    }
}
