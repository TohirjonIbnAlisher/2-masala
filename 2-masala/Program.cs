namespace _2_masala
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("num1 = ");
            string num1 = Console.ReadLine();
            Console.Write("num2 = ");
            string num2 = Console.ReadLine();

            if (num1.Length > num2.Length)
            {
                while(num2.Length != num1.Length)
                {
                    num2 = '0' + num2;
                }
            }
            else
            {
                while (num2.Length != num1.Length)
                {
                    num1 = '0' + num1;
                }
            }

            Console.WriteLine(" " + num1);
            Console.WriteLine('+');
            Console.WriteLine(" " + num2);
            string sum = "";
            int saver = 0;

            for(int i = num1.Length - 1; i >= 0; i--)
            {
                sum = ((num1[i] + num2[i] - 96) % 10 + saver).ToString() + sum;
                saver = (num1[i] + num2[i] - 96) / 10;
            }
            if (saver == 1)
                sum = saver + sum;
            Console.WriteLine(" " + sum);
        }
    }
}