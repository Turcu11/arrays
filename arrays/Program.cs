using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 };
            Print(array);
        }

        static void Print(int[] array)
        {
            if(array is null)
            {
                Console.WriteLine("Array is null");
                return;
            }

            Console.Write("Array = ");
            for(int i = 0; i < array.Length; i++)
            {
                int element = array[i];
                Console.Write(element);
                if(i < array.Length -1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }

        static int[] ReadArray()
        {
            // 1) cintesc numarul de elemente
            // 2) pentru fiecare pozitie trebuie sa citesc valoarea

        }

        static int ReadNumber(string label,int maxTries, int defaultValue)
        {
            Console.Write(label);
            string valueString = Console.ReadLine();

            int currentTry = 0;

            do
            {
                int valueAsNumber;
                bool isNumber = int.TryParse(valueString, out valueAsNumber);

                if (isNumber)
                {
                    return valueAsNumber;
                }
                currentTry++;
                Console.WriteLine($"Valoarea {valueString} nu e valida, mai incearca");
            }
            while (currentTry < maxTries);
            
            return defaultValue;
        }
    }
}
