using System;

namespace CSharpEx04
{
    class Dog
    {
        private string _Species;
        public string _Name;
        private string _Food;

        public Dog()
        {
            _Name = ("This is the default class, no name.");
        }

        public Dog(string dogName)
        {
            _Name = dogName;
            _Species = "dog";
        }

        public void DogSound(string dogSound)
        {
            Console.WriteLine($"My name is {_Name}. I am a {_Species} and I say {dogSound}.");
        }

        public void DogEat()
        {
           _Food = "Kibbles";
            Console.WriteLine($"My name is {_Name}. I am a {_Species} and I eat {_Food}.");
            
        }
    }

    class Cow
    {
        private string _Species;
        public string _Name;
        private string _Food;

        public Cow()
        {
            _Name = ("This is the default class, no name.");
        }

        public Cow(string cowName)
        {
            _Name = cowName;
            _Species = "cow";
        }

        public void CowSound(string cowSound)
        {
            Console.WriteLine($"My name is {_Name}. I am a {_Species} and I say {cowSound}.");
        }

        public void CowEat()
        {
            _Food = "Grains";
            Console.WriteLine($"My name is {_Name}. I am a {_Species} and I eat {_Food}.");
        }
    }

    class Cat
    {
        private string _Species;
        public string _Name;
        private string _Food;

        public Cat()
        {
            _Name = ("This is the default class, no name.");
        }

        public Cat(string catName)
        {
            _Name = catName;
            _Species = "cat";
        }

        public void CatSound(string catSound)
        {
            Console.WriteLine($"My name is {_Name}. I am a {_Species} and I say {catSound}.");
        }

        public void CatEat()
        {
            _Food = "Beef";
            Console.WriteLine($"My name is {_Name}. I am a {_Species} and I eat {_Food}.");

        }
    }

    class Pig
    {
        private string _Species;
        public string _Name;
        private string _Food;

        public Pig()
        {
            _Name = ("This is the default class, no name.");
        }

        public Pig(string pigName)
        {
            _Name = pigName;
            _Species = "pig";
        }

        public void PigSound(string pigSound)
        {
            Console.WriteLine($"My name is {_Name}. I am a {_Species} and I say {pigSound}.");
        }

        public void PigEat()
        {
            _Food = "Feed";
            Console.WriteLine($"My name is {_Name}. I am a {_Species} and I eat {_Food}.");

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Dog Porter = new Dog("Porter");
            Console.WriteLine(Porter._Name);
            Porter.DogSound("Woof");
            Porter.DogEat();

            Dog Lager = new Dog("Lager");
            Console.WriteLine(Lager._Name);
            Lager.DogSound("Ruff");
            Lager.DogEat();

            Dog Kolsch = new Dog("Kolsch");
            Console.WriteLine(Kolsch._Name);
            Kolsch.DogSound("Bark");
            Kolsch.DogEat();

            Dog Pilsner = new Dog("Pilsner");
            Console.WriteLine(Pilsner._Name);
            Pilsner.DogSound("Grrr");
            Pilsner.DogEat();



            Cow Stout = new Cow("Stout");
            Console.WriteLine(Stout._Name);
            Stout.CowSound("Moo");
            Stout.CowEat();

            Cow Bud = new Cow("Bud");
            Console.WriteLine(Bud._Name);
            Bud.CowSound("MOOO");
            Bud.CowEat();

            Cow Busch = new Cow("Busch");
            Console.WriteLine(Busch._Name);
            Busch.CowSound("Merrrrr");
            Busch.CowEat();

            Cow Rye = new Cow("Stout");
            Console.WriteLine(Rye._Name);
            Rye.CowSound("Moomoo");
            Rye.CowEat();



            Cat Heineken = new Cat("Heineken");
            Console.WriteLine(Heineken._Name);
            Heineken.CatSound("Meow");
            Heineken.CatEat();

            Cat Stella = new Cat("Stella");
            Console.WriteLine(Stella._Name);
            Stella.CatSound("Hiss");
            Stella.CatEat();

            Cat Pabst = new Cat("Pabst");
            Console.WriteLine(Pabst._Name);
            Pabst.CatSound("Grrr");
            Pabst.CatEat();

            Cat Milwaukee = new Cat("Milwaukee");
            Console.WriteLine(Milwaukee._Name);
            Milwaukee.CatSound("Purrrrr");
            Milwaukee.CatEat();



            Pig Blue = new Pig("Blue");
            Console.WriteLine(Blue._Name);
            Blue.PigSound("Oink");
            Blue.PigEat();

            Pig Miller = new Pig("Miller");
            Console.WriteLine(Miller._Name);
            Miller.PigSound("Snort");
            Miller.PigEat();

            Pig Natty = new Pig("Natty");
            Console.WriteLine(Natty._Name);
            Natty.PigSound("Grunt");
            Natty.PigEat();

            Pig Yuengling = new Pig("Yuengling");
            Console.WriteLine(Yuengling._Name);
            Yuengling.PigSound("Squeal");
            Yuengling.PigEat();
        }

    }
}
