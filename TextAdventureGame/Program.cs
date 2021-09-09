using System;

namespace TextAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        public static void StartGame()
        {
            Console.WriteLine("Welcome to Krivoukhovye Marsh.");
            Console.WriteLine("Press the key to start the quest.");
            Console.ReadKey();
            Console.Clear();

            FirstRound();
        }

        public static void FirstRound()
        {
            Console.WriteLine("The witches gave you a task to find and kill an evil spirit on a hill under a tree.");
            Console.WriteLine("Choose what you will do with the order.");
            Console.WriteLine("1. Refuse.");
            Console.WriteLine("2. Take the order and kill the monster.");
            Console.WriteLine("3. Take the order and release the monster.");

            var answer = Console.ReadLine().ToLower();

            switch(answer)
            {
                case "1":
                case "Refuse":
                    {
                        Console.WriteLine("The witches will refuse to tell you something just like that, and you will not find Ciri.");
                        Lose();
                        break;
                    }
                case "2":
                case "kill":
                case "kill monster":
                    {
                        Console.WriteLine("The witches told you about Ciri's stay in the swamps, and you also learned that the grandmother is the wife of the Bloody Baron.");
                        SecondRound();
                        break;
                    }
                case "3":
                case "release":
                case "release monster":
                    {
                        Console.WriteLine("The witches found out everything and refused to tell you about Ciri, and cursed Anna.");
                        Lose();
                        break;
                    }


            }
        }

        public static void SecondRound()
        {
            Console.WriteLine("");
            Console.WriteLine("You told about the Baroni's wife and went back to the swamps.");
            Console.WriteLine("You saw in front of you 3 of Anna's illusions, webirite 1 of them using your witch's instinct. Enter 1, 2, or 3.");

            int answer = Convert.ToInt32(Console.ReadLine());
            string[] accidents =
            {
                "It turned out to be a converted drowner, Anna was burned to death.",
                "This is Anna, you push her to the baron, and you yourself deal with the monsters.",
                "This is a trap, you fall into the drowning pit and die."
            };

            if(answer >= 1 && answer <= 3)
            {
                Console.WriteLine(accidents[answer - 1]);

                if(answer == 1 || answer == 3)
                {
                    Lose();
                }
                else
                {
                    ThirdRound();
                }
            }
        }

        public static void ThirdRound()
        {
            Console.WriteLine("");
            Console.WriteLine("Now you must remove the curse from Anna.");
            Console.WriteLine("You have 3 elixirs, give her one that can expose her.");
            Console.WriteLine("Elixirs: Cat, Thunder, Swallow. Enter the name of the elixir.");

            string answer = Console.ReadLine().ToLower();

            while(answer != "cat" && answer != "thunder" && answer != "swallow")
            {
                Console.WriteLine("What are you doing? Help her! Give the elixir you want.");
                Console.WriteLine("Elixirs: Cat, Thunder, Swallow. Enter the name of the elixir.");
                answer = Console.ReadLine().ToLower();
            }

            if(answer == "cat" || answer == "thunder")
            {
                Console.WriteLine("Anna was distraught with pain, and then died. The Baron was beating your heads out of grief.");
                Lose();
            }
            else
            {
                Console.WriteLine("Anna took her form and came to her senses. The Baron and everyone present are happy, you have been rewarded with a large bag of gold.");
                Win();
            }
        }

        public static void Win()
        {
            Console.WriteLine("");
            Console.WriteLine("You managed to find out information about Ciri and save Anna from the witches.");
            Console.WriteLine("Press the key to finish the quest.");
            Console.ReadKey();
        }

        public static void Lose()
        {
            Console.WriteLine("");
            Console.WriteLine("The witches didn’t tell you anything and you didn’t manage to save the baron’s wife.");
            Console.WriteLine("Enter 1 to go through the quest again, or press another key to exit.");

            var key = Console.ReadKey();
            
            if(key.KeyChar == '1')
            {
                Console.Clear();
                StartGame();
            }
        }
    }
}
