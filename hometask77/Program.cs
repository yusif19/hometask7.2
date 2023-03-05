namespace hometask77
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int increment = 0;
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            do
            {

                Console.WriteLine("enter element");
                int element = Convert.ToInt32(Console.ReadLine());


                Array.Resize(ref numbers, increment + 1);

                numbers[increment] = element;
                increment++;
                Console.WriteLine("Do you want do continue?");
                string answer = Console.ReadLine();
                if (!(answer == "y" || answer == "Y"))
                {
                    flag = false;

                }
            }
            while (flag);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);

            }
        }
    }
}