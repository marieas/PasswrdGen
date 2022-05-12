using System;

namespace Weekone
{
    class Program
    {
        //Pause til 13:33

        /*
        Samle nå all validering i en egen metode IsValid() som returnerer true hvis alt er i orden og false ellers.
        Begynnelsen på Main() skal nå være slik:

            if (!IsValid(args))
            {
                ShowHelpText();
                return;

       */
        static Random Random = new Random();

        static bool IsPasswordLengthValid(string passwordLength)
        {
            foreach (var character in passwordLength)
            {
                var isDigit = char.IsDigit(character);
                if (!isDigit)
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsLetterL(char character)
        {
            return character == 'L';
        }


        static bool IsLetterl(char character)
        {
            return character == 'l';
        }
        static bool IsLetterd(char character)
        {
            return character == 'd';
        }

        static bool IsLetters(char character)
        {
            return character == 's';
        }
        static bool IsPatternValid(string pattern)
        {
            foreach (var character in pattern)
            {
                
                bool isValid = IsLetterL(character) || IsLetterl(character) || IsLetterd(character) || IsLetters(character);

                if (isValid)
                {

                }
                else
                {
                    return false;
                }

            }

            return true;
        }

        static bool IsValid(string[] input)
        {
            if (input.Length != 2)
            {
                return false;
            }
            else
            {
                if(!IsPasswordLengthValid(input[0]))
                {
                    return false;
                }
                if (!IsPatternValid(input[1]))
                {
                    return false;
                }

                return true;

            }
        }
        static void Main(string[] args)
        {

            if (!IsValid(args))
            {
                PrintMenu();
                return;
            }

        }

            static void PrintMenu()
            {
                Console.WriteLine(@"   PasswordGenerator  
                  Options:
                  - l = lower case letter
                  - L = upper case letter
                  - d = digit
                  - s = special character (!""#¤%&/(){}[]
                Example: PasswordGenerator 14 lLssdd
                 Min. 1 lower case
                 Min. 1 upper case
                 Min. 2 special characters
                 Min. 2 digits");
            }

            static char GetRandomUpperCaseLetter()
            {
                return GetRandomLetter('A', 'Z');
            }


            static char GetRandomLetter(char min, char max)
            {
                return (char)Random.Next(min, max + 1);
            }
         }


}
