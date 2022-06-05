namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();

            int rand_num = rd.Next(0, 100);

            int user_num = 0;

            int count = 0;

            while (user_num != rand_num)
            {
                Console.Write("Enter a integer number between 0 and 100: ");
                user_num = Convert.ToInt32(Console.ReadLine());
                count++;

                if (rand_num > user_num)
                {
                    Console.WriteLine("Try with a bigger number!");
                } 
                else if (rand_num < user_num)
                {
                    Console.WriteLine("Try with a smaller number!");
                }
            }

            Console.WriteLine("You got it! The guess number is: " + rand_num);
            Console.WriteLine("You guessed in " + count + " attempts.");

            Console.ReadLine();
        }
    }
}