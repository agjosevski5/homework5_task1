using System;

namespace HomeworkClass5_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog
            {
                Name = "Aron",
                Race = "Labrador",
                Color = "white"
            };

            dog.Eating();
            dog.Playing();
            dog.Chasing();

            Console.Read();
        }

    }

    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public void Eating()
        {
            Console.WriteLine("The dog is now eating");
        }

        public void Playing()
        {
            Console.WriteLine("The dog is now playing");
        }

        public void Chasing()
        {
            Console.WriteLine("The dog is now chasing it's tail");
        }
    }
}
