public class Program
{
    public static void Main(string[] args)

    {
        do
         
        {
            Console.WriteLine("We are going to translate your word into pig latin");
            Console.WriteLine();
            Console.WriteLine("Enter any word from the english language");
            string Word = Console.ReadLine().ToLower();
            int Vowel = -1;
            foreach (char letter in Word)
            {
                Vowel = Vowel + 1;
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    break;
                }
            }
            string PigWord = "";
            string Before = "";
            string After = "";
            switch (Vowel)
            {
                case 0:
                    PigWord = Word + "way";
                    break;
                case 1:
                    Before = Word.Substring(0, 1);
                    After = Word.Substring(1);
                    PigWord = After + Before + "ay";
                    break;
                case 2:
                    Before = Word.Substring(0, 2);
                    After = Word.Substring(2);
                    PigWord = After + Before + "ay";
                    break;
                default:
                    PigWord = "Sorry, we can not translate that word.";
                    break;
            }
            {
                Console.WriteLine("Your word translated into pig latin is: " + PigWord);
                Console.WriteLine();
                
            }
            string userInput;
            
            {
                Console.WriteLine("Would you like to translate another word? y/n");
                string Input = Console.ReadLine().ToLower();

                //1) y: move to the next of the loop
                //2) n: stop the loop 

                bool keepRunning = true;
                if (Input == "y")
                {
                    keepRunning = true;

                }
                else if (Input == "n")
                {
                    Console.WriteLine("Goodbye");
                   
                    break;
                }

            }
        } while (true);
    }
}