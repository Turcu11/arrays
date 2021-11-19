using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = ReadArray();
            PrintArray(array);

        }

        static void PrintArray(int[] array)
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
            int nrElemente = ReadNumber("Numar de elemente = ", 3, 0);

            int[] array = new int[nrElemente];

            // 2) pentru fiecare pozitie trebuie sa citesc valoarea
            for (int i = 0; i < nrElemente; i++)
            {
                array[i] = ReadNumber($"Element [{i}] = ",3,0);
            }
            return array;
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
