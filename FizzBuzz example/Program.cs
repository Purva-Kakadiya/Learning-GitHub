namespace FizzBuzz_example {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("FizzBuzz Example for numers 1 to 100!");
            Console.WriteLine("Enter number of value that are associated with FizzBuzz: ");
            int numberOfValues = Convert.ToInt32(Console.ReadLine());

            FizzBuzzValue[] fizzBuzzStruct = new FizzBuzzValue[numberOfValues];

            int userInputNumber;
            string userInputWord;
            for (int i = 0; i < numberOfValues; i++)
            {
                Console.WriteLine($"Enter the number and the word associated with it for FizzBuzz");
                userInputNumber = Convert.ToInt32(Console.ReadLine());
                userInputWord = Console.ReadLine();
                fizzBuzzStruct[i] = new FizzBuzzValue(userInputNumber, userInputWord);
            }
            for(int i = 1; i <= 100; i++)
            {
                string output = string.Empty;
                for(int j = 0; j < numberOfValues; j++)
                {
                    if(i % fizzBuzzStruct[j].divisorNumber == 0)
                    {
                        output += fizzBuzzStruct[j].associatedWord;
                    }
                }
                if(output.Length == 0)
                {
                    output = Convert.ToString(i);
                }
                Console.WriteLine(output);
            }
            Console.ReadKey();
        }

        internal struct FizzBuzzValue
        {
            internal int divisorNumber { get; set; }
            internal string associatedWord { get; set; } 
            internal FizzBuzzValue(int userInputNumber, string userInputWord)
            {
                divisorNumber = userInputNumber;
                associatedWord = userInputWord;
            }
        }
    }
}
