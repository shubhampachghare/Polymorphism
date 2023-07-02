namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal mypig = new Pig();
            Animal myDog= new Dog();

            myAnimal.AnimalSound();
            myDog.AnimalSound();
            mypig.AnimalSound();


        }
    }
}