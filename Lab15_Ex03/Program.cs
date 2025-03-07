using static System.Console;

var animalA = new Dog();
var animalB = new Fish();
var animalC = new Bird();

animalA.Move();
animalB.Move();
animalC.Move();

class Animal
{
   public virtual void Move()
   {
       WriteLine("Move successfully.");
   } 
}

class Dog : Animal
{
    public override void Move()
    {
        WriteLine($"{this.GetType().Name}: Running on the ground.");
        base.Move();  // Call base class method for general message
    }
}

class Fish : Animal
{
    public override void Move()
    {
        WriteLine($"{this.GetType().Name}: Swimming in the water.");
        base.Move();  // Call base class method for general message
    }
}

class Bird : Animal
{
    public override void Move()
    {
        WriteLine($"{this.GetType().Name}: Flying in the air.");
        base.Move();  // Call base class method for general message
    }
}
