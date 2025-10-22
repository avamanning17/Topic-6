using System;
using System.ComponentModel.Design;
using System.Reflection.Emit;

namespace Topic_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randNum; // We will store our random number in this variable 
            //randNum = generator.Next();
            //Console.WriteLine(randNum);
            ////Console.WriteLine("My random number is " + randNum);
            //Console.WriteLine("Here are some numbers from 0 to 4!");
            //Console.Write(generator.Next(2, 5) + " ");
            //Console.Write(generator.Next(2, 5) + " ");
            //Console.Write(generator.Next(2, 5) + " ");
            //Console.Write(generator.Next(2, 5) + " ");
            //Console.Write(generator.Next(2, 5) + " ");
            //Console.WriteLine(generator.Next(2, 5) + " ");
            //Console.WriteLine("gkjhsdg");

            //Console.WriteLine("Here are some numbers from 0 to 99!");
            //Console.Write(generator.Next(100) + " ");
            //Console.Write(generator.Next(100) + " ");
            //Console.Write(generator.Next(100) + " ");
            //Console.Write(generator.Next(100) + " ");
            //Console.Write(generator.Next(100) + " ");
            //Console.WriteLine(generator.Next(100) + " ");


            //int num1 = generator.Next(10);
            //int num2 = generator.Next(10);

            //if (num1 == num2)
            //{
            //    Console.WriteLine("The random numbers were the same! Weird.");
            //}
            //Console.ReadLine(); // Keeps the program from quitting 
            //if (num1 != num2)
            //{
            //    Console.WriteLine("The random numbers were different! Not weird.");
            //}
            //Console.ReadLine(); // Keeps the program from quitting 

            //int min, max;
            //Console.WriteLine("Enter a min number");
            //int.TryParse(Console.ReadLine(), out min);
            //Console.WriteLine("Enter a max number");
            //int.TryParse(Console.ReadLine(), out max);
            //Console.WriteLine(generator.Next(min, max + 1));


            //int secretNumber, guess;
            //secretNumber = generator.Next(1, 11);

            //Console.WriteLine("Guess the secret number:");
            //int.TryParse(Console.ReadLine(), out guess);
            //if (guess == secretNumber)
            //{
            //    Console.WriteLine("You got it");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong, it was " + secretNumber);
            //}


            int diceOne, diceTwo;
            diceOne = generator.Next(1, 7);
            diceTwo = generator.Next(1, 7);
            Console.WriteLine("Roll both of the dice");
            Console.WriteLine("What did you role on the first dice?");
            int.TryParse(Console.ReadLine(), out diceOne);
            Console.WriteLine("What did you role on the second dice?");
            int.TryParse(Console.ReadLine(), out diceTwo);
            Console.WriteLine("You rolled a total of " + (diceOne + diceTwo) + "!");
            


        }
    }
}
