using System;

namespace MatrixMultiplier
{

    class Matrixes
    {
        private static int[] firstMatrix;
        private static int[] secondMatrix;
        private static int length1;
        private static int height1;
        private static int length2;
        private static int height2;

        public static void SizeOfTheFirstMatrix()
        {
            Console.WriteLine("Hello! User, this programm multiplies matrixes!!!" +
              " Wow do you know that i wrote it in my freshman year");
            Console.WriteLine("Write the length of the first matrix");
            var inputingValue = Console.ReadLine();
            int test;
            while (!int.TryParse(inputingValue, out test))
            {
                Console.WriteLine("You have mistakent, your input isn't a number");
                inputingValue = Console.ReadLine();
            }
            length1 = int.Parse(inputingValue);

            Console.WriteLine("Write the height of the first matrix");
            inputingValue = Console.ReadLine();
            while (!int.TryParse(inputingValue, out test))
            {
                Console.WriteLine("You have mistakent, your input isn't a number");
                inputingValue = Console.ReadLine();
            }
            height1 = int.Parse(inputingValue);

            firstMatrix = new int[length1 * height1];

            int placeForFirstMatrix;
            int lineForFirstMatrix = 0;
            for (int i = 0; i < firstMatrix.Length; i++)
            {
                placeForFirstMatrix = i % length1 + 1;
                if (placeForFirstMatrix == 1)
                {
                    lineForFirstMatrix++;
                }
                Console.WriteLine("Dear user! Insert element on place " + placeForFirstMatrix
                    + " line " + lineForFirstMatrix);
                inputingValue = Console.ReadLine();
                while (!int.TryParse(inputingValue, out test))
                {
                    Console.WriteLine("You have mistakent, your input isn't a number");
                    inputingValue = Console.ReadLine();
                }
                firstMatrix[i] = int.Parse(inputingValue);
            }
        }

        public static void SizeOfTheSecondMatrix()
        {
            Console.WriteLine("Write the length of the second matrix");
            var inputingValue = Console.ReadLine();
            int test;
            while (!int.TryParse(inputingValue, out test))
            {
                Console.WriteLine("You have mistakent, your input isn't a number");
                inputingValue = Console.ReadLine();
            }
            length2 = int.Parse(inputingValue);

            Console.WriteLine("Write the height of the first matrix");
            inputingValue = Console.ReadLine();

            while (!int.TryParse(inputingValue, out test))
            {
                Console.WriteLine("You have mistakent, your input isn't a number");
                inputingValue = Console.ReadLine();
            }
            height2 = int.Parse(inputingValue);

            secondMatrix = new int[length2 * height2];

            int placeForFirstMatrix;
            int lineForFirstMatrix = 0;
            for (int i = 0; i < secondMatrix.Length; i++)
            {
                placeForFirstMatrix = i % length2 + 1;
                if (placeForFirstMatrix == 1)
                {
                    lineForFirstMatrix++;
                }
                Console.WriteLine("Dear user! Insert element on place " + placeForFirstMatrix
                    + " line " + lineForFirstMatrix);
                inputingValue = Console.ReadLine();
                while (!int.TryParse(inputingValue, out test))
                {
                    Console.WriteLine("You have mistakent, your input isn't a number");
                    inputingValue = Console.ReadLine();
                }
                secondMatrix[i] = int.Parse(inputingValue);
            }
        }
        public static int[] FirstMatrix
        {
            get { return firstMatrix; }
            private set { firstMatrix = value; }
        }

        public static int[] SecondMatrix
        {
            get { return secondMatrix; }
            private set { secondMatrix = value; }
        }

        public static int Height1
        {
            get { return height1; }
            private set { height1 = value; }
        }

        public static int Length1
        {
            get { return length1; }
            private set { length1 = value; }
        }

        public static int Height2
        {
            get { return height2; }
            private set { height2 = value; }
        }

        public static int Length2
        {
            get { return length2; }
            private set { length2 = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Matrixes.SizeOfTheFirstMatrix();
            Matrixes.SizeOfTheSecondMatrix();
            Console.WriteLine();
            int heightOfFirstMatrix = Matrixes.Height1;
            int heightOfSecondMatrix = Matrixes.Height2;
            int lenghtOfFirstMatrix = Matrixes.Length1;
            int lenghtOfSecondMatrix = Matrixes.Length2;
            int[] numbersInFirstMatrix = Matrixes.FirstMatrix;
            int[] numbersInSecondMatrix = Matrixes.SecondMatrix;
            int numberOfTable = 0;
            int stepDown = 0;
            int step = 0;
            int value = 0;
            int counter = 0;
            if (lenghtOfFirstMatrix == heightOfSecondMatrix)
            {
                int[] finalMatrix = new int[heightOfFirstMatrix * lenghtOfSecondMatrix];
                for (int i = 0; i < finalMatrix.Length; i++)
                {
                    for (int j = 0 + stepDown; j < lenghtOfFirstMatrix + stepDown; j++)
                    {
                        value += numbersInFirstMatrix[j] * numbersInSecondMatrix[j * lenghtOfSecondMatrix + step];
                    }
                    numberOfTable++;
                    if (numberOfTable == lenghtOfSecondMatrix)
                    {
                        counter++;
                        stepDown += lenghtOfFirstMatrix;
                        step = (-counter * lenghtOfSecondMatrix * lenghtOfFirstMatrix);
                        numberOfTable = 0;
                    }
                    else
                    {
                        step++;
                    }
                    finalMatrix[i] = value;
                    value = 0;
                }
                Console.WriteLine("Your result matrix is: ");
                for (int i = 0; i < finalMatrix.Length; i++)
                {
                    Console.Write(finalMatrix[i] + " ");
                    if ((i + 1) % lenghtOfSecondMatrix == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Sorry, your matrixes can not be multiplyed");
            }
            Console.WriteLine("Enter any key to close the programm.");
            Console.ReadKey();
        }
    }
}
