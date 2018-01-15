using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }

    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int IntelligenceQuotient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }

    class Snake
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CrueltyCoefficient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }

    class Animals
    {
        static void Main(string[] args)
        {
            var dogs = new Dictionary<string, Dog>();
            var cats = new Dictionary<string, Cat>();
            var snakes = new Dictionary<string, Snake>();

            string line = Console.ReadLine();

            while (line != "I'm your Huckleberry")
            {
                string[] tokens = line.Split(' ');
                if (tokens[0] != "talk")
                {
                    string className = tokens[0];
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    int parameter = int.Parse(tokens[3]);

                    switch (className)
                    {
                        case "Dog":
                            Dog currentDog = new Dog();
                            currentDog.Name = name;
                            currentDog.Age = age;
                            currentDog.NumberOfLegs = parameter;

                            dogs.Add(currentDog.Name, currentDog);
                            break;
                        case "Cat":
                            Cat currentCat = new Cat();
                            currentCat.Name = name;
                            currentCat.Age = age;
                            currentCat.IntelligenceQuotient = parameter;

                            cats.Add(currentCat.Name, currentCat);
                            break;
                        case "Snake":
                            Snake currentSnake = new Snake();
                            currentSnake.Name = name;
                            currentSnake.Age = age;
                            currentSnake.CrueltyCoefficient = parameter;

                            snakes.Add(currentSnake.Name, currentSnake);
                            break;
                    }
                }
                else
                {
                    string animalName = tokens[1];

                    if (dogs.ContainsKey(animalName))
                    {
                        dogs[animalName].ProduceSound();
                    }
                    else if (cats.ContainsKey(animalName))
                    {
                        cats[animalName].ProduceSound();
                    }
                    else if (snakes.ContainsKey(animalName))
                    {
                        snakes[animalName].ProduceSound();
                    }
                }


                line = Console.ReadLine();
            }

            PrintDogs(dogs);

            PrintCats(cats);

            PrintSnakes(snakes);
        }

        static void PrintDogs(Dictionary<string, Dog> dogs)
        {
            foreach (var dog in dogs)
            {
                Console.WriteLine(
                    $"Dog: {dog.Value.Name}, Age: {dog.Value.Age}, Number Of Legs: {dog.Value.NumberOfLegs}");
            }
        }

        static void PrintCats(Dictionary<string, Cat> cats)
        {
            foreach (var cat in cats)
            {
                Console.WriteLine(
                    $"Cat: {cat.Value.Name}, Age: {cat.Value.Age}, IQ: {cat.Value.IntelligenceQuotient}");
            }
        }

        static void PrintSnakes(Dictionary<string, Snake> snakes)
        {
            foreach (var snake in snakes)
            {
                Console.WriteLine(
                    $"Snake: {snake.Value.Name}, Age: {snake.Value.Age}, Cruelty: {snake.Value.CrueltyCoefficient}");
            }
        }
    }
}
