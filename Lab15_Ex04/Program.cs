using static System.Console;

var b = new Base();
var d1 = new Derived_1();
var d2 = new Derived_2();

b.A();   // เรียกจาก Base
d1.A();  // เรียกจาก Derived_1
d2.A();  // เรียกจาก Derived_2

class Base
{
    public virtual void A()
    {
        WriteLine("Base.A()");
    }
}

class Derived_1 : Base
{
    public override void A()
    {
        WriteLine("Derived_1.A()");
    }
}

class Derived_2 : Derived_1
{
    public override void A()
    {
        WriteLine("Derived_2.A()");
    }
}
