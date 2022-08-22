using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird penguin = new Bird()
            {
                Name = "MoMo",
                Age = 15,
                Legs = 2,
                blackandWhite = "Black and White"
            };

            Console.WriteLine($" {penguin.Name} is a {penguin.Age} year old penguin at the Gatlinburg Aquarium in Gatlinburg, TN. {penguin.Name} has {penguin.Legs} legs. \n" +
                $"{penguin.Name} is {penguin.blackandWhite}.");
            Console.WriteLine();



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile beardedDragon = new Reptile()
            {
                IsColdBlooded = true,
                HasScales = true,
                HasBeard = true,
                Environment = "Desert",
                Name = "Malygos"
            };

            Console.WriteLine($" I have a bearded dragon, his name is {beardedDragon.Name}. He lives in a {beardedDragon.Environment} terrarium that my husband built him."); 

                Console.WriteLine($" Do bearded dragons have scales, an actual beard, and are they cold-blooded?" +
                $"{beardedDragon.HasScales}, {beardedDragon.HasBeard}, {beardedDragon.IsColdBlooded}");
            Console.WriteLine();

                




        }
    }
}
