using System;

namespace Hello
{
    public class AdvancedHello
    {

        public static void Main()
        {
            char[] alphabet = new char[55];
            alphabet[53] = ' ';
            alphabet[54] = '!';

            Console.WriteLine("What you want me to type ?");
            string target = GetTargetString();
            string actual = "";
            int tries = 0;
            while (actual != target)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (target.Equals(actual))
                    {
                        Console.WriteLine("Done.");
                        break;
                    }
                    tries++;
                    Thread.Sleep(33);
                    alphabet[i] = (char)('A' + i);
                    char targetChar = GetTargetChar(target, actual);
                    char newCharacter = GetNewCharacter(i, targetChar, alphabet);

                    Console.WriteLine(actual + newCharacter);
                    if (newCharacter == targetChar)
                    {
                        actual += newCharacter;
                    }
                }
            }
            Console.WriteLine($"The proccess is completed. You got your word written in {tries} tries");
        }

        private static char GetNewCharacter(int index, char targetChar, char[] alphabet)
        {
            if (index == alphabet.Length - 1)
                return targetChar;
            else
                return alphabet[index];
        }

        private static string GetTargetString()
        {
            string? target = Console.ReadLine();
            while (target is null || target.Length <= 0)
            {
                target = Console.ReadLine();
            }
            if (target.Equals("Random"))
                target = "49127482164!@^#*&!@(casgdlksjagdasytge2843678o^&@!)*^#!@&*$";
            return target;
        }

        private static char GetTargetChar(string target, string actual)
        {
            if (actual.Length == 0)
                return target[0];
            else
                return target[actual.Length];
        }

    }
}