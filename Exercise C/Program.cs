namespace Exercise_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputtingStrings();
            ArithmeticExamples();
            AssignmentExamples();
            CompareAndConditions();
        }

        private static void OutputtingStrings()
        {
            string outSent = "I'm in Game 1377: Scripting for Games Designers.";
            Console.WriteLine(outSent + "\n");
            Console.WriteLine(outSent.ToUpper());
            Console.WriteLine(outSent.ToLower());
            Console.WriteLine(outSent.Substring(8));
            Console.WriteLine(outSent.Substring(8, 3));
            Console.WriteLine(outSent[8]);
        }

        private static void ArithmeticExamples()
        {
            int intInput1;
            int intInput2;

            intInput1 = 1;
            intInput2 = 2;

            int sum = intInput1 + intInput2;
            int diff = intInput1 - intInput2;
            int product = intInput1 * intInput2;
            float quotient = intInput1 / intInput2; // Could not figure out how to make the int inputs names into float numbers...
            float remainder = intInput1 % intInput2;

            Console.WriteLine("\n" + sum);
            Console.WriteLine(diff);
            Console.WriteLine(product);
            Console.WriteLine(quotient);
            Console.WriteLine(remainder);
        }

        private static void AssignmentExamples()
        {
            float floatInput1;
            float floatInput2;

            floatInput1 = 10.222f;
            floatInput2 = 20.333f;

            floatInput2 = floatInput2 + floatInput1;
            Console.WriteLine("\n" + floatInput2);
            floatInput2 = floatInput2 - floatInput1;
            Console.WriteLine(floatInput2);
            floatInput2 = floatInput2 * floatInput2;
            Console.WriteLine(floatInput2);
            floatInput2 = floatInput2 / floatInput1;
            Console.WriteLine(floatInput2);
        }

        private static void CompareAndConditions()
        {
            int intInput1;
            int intInput2;

            intInput1 = 30;
            intInput2 = 100;

            if (intInput1 < intInput2)
            {
                Console.WriteLine("\nintInput2 is greater than intInput1");
            }
            if (intInput1 == intInput1)
            {
                Console.WriteLine("The inputs are equal");
            }
            if (intInput1 > intInput2)
            {
                Console.WriteLine("intInput1 is greater than intInput2");
            }
        }
    }
}
