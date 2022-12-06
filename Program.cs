using System;

namespace Encode_Decode_Program
{
    class Globals
    {
        public static string encodeDecodeKey;
        public static int encodeInteger;
        public static string encodedString;
        public static string decodedString;
    }

    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            Console.WriteLine("Enter a string which you want encoded and decoded: "); string encodeString = Console.ReadLine();

            for (int x = 0; x < encodeString.Length; x++)
            {
                int asciiValue = encodeString[x];
                Globals.encodeInteger = rnd.Next(1, 9);
                Globals.encodeDecodeKey = Globals.encodeDecodeKey + Globals.encodeInteger;
                char encodedCharacter = (char)(asciiValue + Globals.encodeInteger);
                Globals.encodedString = Globals.encodedString + encodedCharacter;
                Console.WriteLine("ascii value of character " + x + " in the user inputted string.");
                Console.WriteLine("encoded character " + x + " is " + encodedCharacter);
            }

            for (int x = 0; x < Globals.encodedString.Length; x++)
            {
                int asciiValue = Globals.encodedString[x];
                char decodedCharacter = (char)(asciiValue - (int)Globals.encodeDecodeKey[x]);
                Globals.decodedString = Globals.decodedString + decodedCharacter;
                Console.WriteLine("ascii value of encoded character " + x + " equals " + asciiValue);
                Console.WriteLine("Decoded character equals " + decodedCharacter);
            }

            Console.WriteLine("Encoded string: " + Globals.encodedString);
            Console.WriteLine("Decoded string: " + Globals.decodedString);
            Console.ReadLine();
        }
    }
}