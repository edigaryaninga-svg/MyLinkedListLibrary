using System;

namespace HashTableProj
{
    public class MyHasher
    {
        public static void Main()
        {
            string input = string.Empty;

            while (!input.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("> ");
                input = Console.ReadLine();

                if (input.Equals("quit", StringComparison.OrdinalIgnoreCase))
                    break;

                int additiveValue = AdditiveHash(input);
                int foldingValue = FoldingHash(input);

                Console.WriteLine($"Additive: {additiveValue}");
                Console.WriteLine($"Folding:  {foldingValue}");
            }
        }

        public static int AdditiveHash(string input)
        {
            int currentHashValue = 0;
            foreach (char c in input)
            {
                unchecked
                {
                    currentHashValue += (int)c;
                }
            }
            return currentHashValue;
        }

        public static int FoldingHash(string input)
        {
            int hashValue = 0;
            int startIndex = 0;
            int currentFourBytes;

            do
            {
                currentFourBytes = GetNextBytes(startIndex, input);
                unchecked
                {
                    hashValue += currentFourBytes;
                }
                startIndex += 4;
            } while (startIndex < input.Length);

            return hashValue;
        }

        private static int GetNextBytes(int startIndex, string str)
        {
            int currentFourBytes = 0;

            currentFourBytes += GetByte(str, startIndex);
            currentFourBytes += GetByte(str, startIndex + 1) << 8;
            currentFourBytes += GetByte(str, startIndex + 2) << 16;
            currentFourBytes += GetByte(str, startIndex + 3) << 24;

            return currentFourBytes;
        }

        private static int GetByte(string str, int index)
        {
            if (index < str.Length)
            {
                return (int)str[index];
            }
            return 0;
        }
    }
}