namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 2

            Console.WriteLine("Give some number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give another number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2} = {add(num1, num2)}");
            Console.WriteLine($"{num1} - {num2} = {sub(num1, num2)}");
            Console.WriteLine($"{num1} * {num2} = {mult(num1, num2)}");
            Console.WriteLine($"{num1} / {num2} = {div(num1, num2)}");
        }

        public static int add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int mult(int num1, int num2)
        {
            return num1 * num2;
        }
        public static decimal div(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
