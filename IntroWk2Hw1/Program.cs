using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroWk2Hw1
{
    class Program
    {
        public static int caseSwitch = 0;  // Case switch allows me to utilize the case method for more elegant code
        public static float guessContainer = 0;
        public static float actualPrice = 3595.56f;
        public static void Main(string[] args)
        {
            string name;
            string strGuessPrice;
            float floatGuessPrice;
            int turnCount = 3;
            string caseTurn;


            Console.WriteLine("Welcome to Generic Cars Guessing Challenge!");
            Console.WriteLine("");
            Console.WriteLine("_____| |_");
            Console.WriteLine("[4x4_|_|-]");
            Console.WriteLine(" (_)   (_)");
            Console.WriteLine("");
            Console.WriteLine("If you can guess the correct ammount for the Car then you will WIN!");
            Console.WriteLine("");
            Console.WriteLine("You only get 3 Guesses! So use them Wisely!!");
            Console.WriteLine("");
            Console.Write("Firstly, please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Thanks " + name);





            for (int i = 0; i < 3; i++)
            {
                Console.Write("What is your price guess? (USE ONLY NUMBERS!) £");
                strGuessPrice = Console.ReadLine();
                floatGuessPrice = float.Parse(strGuessPrice);
                if (floatGuessPrice == actualPrice)
                {

                    caseSwitch = 1;
                }
                else if (floatGuessPrice < actualPrice)
                {
                    caseSwitch = 2;
                }
                else if (floatGuessPrice > actualPrice)
                {
                    caseSwitch = 3;
                }
                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("You Won! go to the front desk to recieve the keys to your brand new car!");
                        Console.WriteLine("Program will now terminate");
                        i = 3;
                        break;                        
                    case 2:
                        turnCount = turnCount - 1;
                        caseTurn = turnCount.ToString();
                        Console.WriteLine("Sorry too Low! You have " + caseTurn + " lives remaining!");
                        break;
                    case 3:
                        turnCount = turnCount - 1;
                        caseTurn = turnCount.ToString();
                        Console.WriteLine("Sorry too High! You have " + caseTurn + " lives remaining!");
                        break;
                }
            }
            Console.ReadLine();

        }




    }
}

