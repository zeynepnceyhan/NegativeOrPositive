namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int number1;
            Console.WriteLine("Please enter a number: ");
            number1 = Convert.ToInt32(Console.ReadLine());


            if (number1 > 0)
            {
                Console.WriteLine("The number is a positive number...");
            }
            else if (number1 == 0)
            {
                Console.WriteLine("The number is not positive or negative. The number is zero...");
            }
            else
            {
                Console.WriteLine("The number is a negative number...");
            }

        }

    }

}