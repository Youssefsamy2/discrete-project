namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i, z, n1, n2;

            Console.Write("Input starting number of range: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", n1, n2);

            for (num = n1; num <= n2; num++)
            {
                z = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        z++;
                        break;
                    }
                }

                if (z == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");
        }
    }
}