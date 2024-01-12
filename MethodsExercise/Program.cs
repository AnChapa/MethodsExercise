namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            string animal, color, flower, item;
            Console.WriteLine("You found and animal. What was it: ");
            animal = Console.ReadLine();
            Console.WriteLine("What color was it: ");
            color = Console.ReadLine();
            Console.WriteLine("What kind of flower did it want: ");
            flower = Console.ReadLine();
            Console.WriteLine("What did it give you in return: ");
            item = Console.ReadLine();

            Console.WriteLine($"\nWhile walking home one day, you met a {color} {animal}.\nThe {color} {animal} came up to you and asked \n\"Could you please pick that {flower} for me. It is too high for me to reach.\"\nAgreeing, you pick and give the flower to the {color} {animal}. It thanked you and said \n\"For your kindness, i will give you a {item}. Thank you.\"\nThus, you walked home with your newfound {item} and the knowledge you helped the {color} {animal}.\nThe End");

            //Exercise 2

            Console.WriteLine("\nEnter a list of numbers seperated with commas for the summation:");
            string? input = Console.ReadLine();

            if(input != null )
            {
                string[] numList = input.Split(',');
                int[] numbers = new int[numList.Length];
                for (int i = 0; i < numList.Length; i++)
                {
                    if (int.TryParse(numList[i], out int parsedNumber))
                    {
                        numbers[i] = parsedNumber;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input: {numList[i]} is not a valid integer.");
                        return;
                    }
                }
                Console.WriteLine($"= {Add(numbers)}");
                Console.WriteLine($"= {Multiply(numbers)}");
            }
            else
            {
                Console.WriteLine("Error, can not be null");
            }
        }

        public static int Add(params int[] numList)
        {
            int sum = 0;
            for(int i =  0; i < numList.Length; i++)
            {
                Console.Write(numList[i] + " + ");
                sum += numList[i];
            }
            
            return sum;
        }
        public static int Multiply(params int[] numList)
        {
            int sum = numList[0];
            for (int i = 0; i < numList.Length; i++)
            {
                Console.Write(numList[i] + " * ");
                if(i != 0)
                    sum = sum * numList[i];
            }

            return sum;
        }
    }
}
