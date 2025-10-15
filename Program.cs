namespace Topic_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Random generator = new Random();
            int randNum; // We will store our random number in this variable 
            randNum = generator.Next();
            Console.WriteLine(randNum);
            //Console.WriteLine("My random number is " + randNum);
            Console.WriteLine("Here are some numbers from 0 to 4!");
            Console.Write(generator.Next(2, 5) + " ");
            Console.Write(generator.Next(2, 5) + " ");
            Console.Write(generator.Next(2, 5) + " ");
            Console.Write(generator.Next(2, 5) + " ");
            Console.Write(generator.Next(2, 5) + " ");
            Console.WriteLine(generator.Next(2, 5) + " ");
            Console.WriteLine();

            //Console.WriteLine("Here are some numbers from 0 to 99!");
            //Console.Write(generator.Next(100) + " ");
            //Console.Write(generator.Next(100) + " ");
            //Console.Write(generator.Next(100) + " ");
            //Console.Write(generator.Next(100) + " ");
            //Console.Write(generator.Next(100) + " ");
            //Console.WriteLine(generator.Next(100) + " ");
            //Console.WriteLine();

            int num1 = generator.Next(10);
            int num2 = generator.Next(10);

            if (num1 == num2)
            {
                Console.WriteLine("The random numbers were the same! Weird.");
            }
            Console.ReadLine(); // Keeps the program from quitting 
            if (num1 != num2)
            {
                Console.WriteLine("The random numbers were different! Not weird.");
            }
            Console.ReadLine(); // Keeps the program from quitting 

        }
    }
}
