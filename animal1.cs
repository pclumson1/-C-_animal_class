
using System;
using System.Collections.Generic;

namespace MyPolymorphism
{

        public class Animal
    {

        public Animal()
        {

        }

        public Animal(string n)
        {
            Console.WriteLine(" Animal object is created with name: {0}", n);
            name = n ;
        }

        ~  Animal()
        {
            Console.WriteLine(" Animal object {0} is destroyed.", name);
        }

        public void setName(string nm)
        {
            name = nm ;
        }

        public string getName()
        {
            return name;
        }


    
        // Virtual method
        public virtual string speak()
        {
            return "Performing base class speaking";
           
        }

        public string name;
    }

    public class Dog : Animal
    {
        public override string speak()
        {
            // Code to draw a circle...
            return "Whoof! Whooof! I am a dog{0}." ;
            
            base.speak();
        }
    }

    public class Cat : Animal
    {
        public override string  speak()
        {
            // Code to draw a rectangle...
            return "Meaoh! I am a cat.";
            base.speak();
        }
    }

    public class Cow : Animal
    {
        public override string speak()
        {
            // Code to draw a triangle...
            return "Mboooow !!! I am a cow !";
            base.speak();
        }
    }

    class TestClass
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*************************************");
            Console.WriteLine("Hello Prince");

            Animal a = new Animal();
            a.setName("Les animaux");
            // Display the number of command line arguments.
            Console.WriteLine(a.name + " said:"+ a.speak());
            
           
            Animal an = new Animal("Animal domestique");
            an.getName();
            Console.WriteLine(an.name + " said: {0}", an.getName() );
            Console.WriteLine(an.getName() + " said: {0}", an.speak() );
            

            Console.WriteLine("*************************************");
            Console.WriteLine("Hello Prince");

            Dog d = new Dog();
            d.setName("Doggy");
            // Display the dog speak.
            Console.WriteLine(d.name + " said:" + d.speak());
           
            Console.WriteLine("*************************************");
            Console.WriteLine("Hello Prince");

            Cat c = new Cat();
            c.setName("Melou");
            // Display the number of command line arguments.
            Console.WriteLine(c.name + " said:"+ c.speak() );
           
            Console.WriteLine("************************************");
            Console.WriteLine("Hello Prince");

            Cow co = new Cow();
            co.setName("BooBoo");
            // Display the number of command line arguments.
            Console.WriteLine(co.name + " said:"+ co.speak() );

            Console.WriteLine(c.GetType() + " said:"+ c.speak() );

            Console.WriteLine(c.ToString() + " said:"+ c.speak() );
            

           
        }
    }

        
}

