using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotDogsAhoy
{
    class Animal
    {
        public void Poop()
        {
            Console.WriteLine("I did a pooh");
        }

    public void Breathe()
        {
            Console.WriteLine("breathe in");
            Console.WriteLine("breathe out");
        }
    }

    class Walker
    {
        public void Walk()
        {
            Console.WriteLine("I'm going for a walk");
        }
    }

    class Barker
    {
        public void Bark()
        {
            Console.WriteLine("Woof");
        }
    }

    class Robot
    {
        public void Drive()
        {
            Console.WriteLine("I'm a driving along.");
        }

        public void Charge()
        {
            Console.WriteLine("Charging....");
        }
    }

    class person
    {
        Animal animal = new Animal();
        Walker walker = new Walker();

        public void Walk()
        {
            walker.Walk();
        }

        public void Breathe()
        {
            animal.Breathe();
        }

        public void Poop()
        {
            animal.Poop();
        }
    }

    class Dog
    {
        Animal animal = new Animal();
        Walker walker = new Walker();
        Barker barker = new Barker();

        public void Walk()
        {
            walker.Walk();
        }

        public void Breathe()
        {
            animal.Breathe();
        }

        public void Poop()
        {
            animal.Poop();
        }

        public void Bark()
        {
            barker.Bark();
        }
    }

    class RobotDog
    {
        Robot robot = new Robot();
        Barker barker = new Barker();

        public void Drive()
        {
            robot.Drive();
        }

        public void Charge()
        {
            robot.Charge();
        }

        public void Bark()
        {
            barker.Bark();
        }
    }
}

