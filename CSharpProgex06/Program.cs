using System;

namespace CSharpProgex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Congratulations on getting selected for Special Forces.  Now lets find out what job you are going to train for");
            Console.Write("First off, what's your name?: ");
            string name = Console.ReadLine();

            Console.Write($"Alright {name}, are you smart (y/n)?: ");
            string IQ = Console.ReadLine();
            if (IQ == "y")
            {
                Console.WriteLine("Smart guy huh? That gives you two options, delta or echo");
            }
            else if (IQ == "n")
            {
                Console.WriteLine("Strong ranger huh? That gived you a couple of options");
            }
            Console.Write("Are you a glutton for punishment (y/n)?: ");
            string hate = Console.ReadLine();
            if (IQ == "y" && hate == "y")
            {
                Console.WriteLine("Smart and you hate yourself? You sound like an echo");
                Echo wayne = new Echo();
                wayne.AssignMOS();
            }
            else if (IQ == "y" && hate == "n")
            {
                Console.WriteLine("Smart and you don't hate yourself? Delta is for you");
                Delta Chad = new Delta();
                Chad.AssignMOS();
            }
            else if (IQ == "n" && hate == "n")
            {
                Console.WriteLine("Maybe you are smarter than you think.  Bravo for you");
                Bravo Andrew = new Bravo();
                Andrew.AssignMOS();
            }
            else if (IQ == "n" && hate == "y")
            {
                Console.WriteLine("You will be a charlie and you will be miserable.  Congrats");
                Charlie Mike = new Charlie();
                Mike.AssignMOS();
            }
            Console.WriteLine("Now let's get you a language");
            Console.WriteLine("Where do you want to live?");
            Console.WriteLine("1) Colorado, 2) NC, 3) Kentucky, 4)Florida");
            Console.Write("Enter the number for where you want to live: ");
            string location = Console.ReadLine();
            if (location == "1")
            {
                Console.WriteLine("Colorado is great, Have fun learning Russian");
                Russian Brandon = new Russian();
                string brandonLang = Brandon.AssignLanguage();
            }
            else if (location == "2")
            {
                Console.WriteLine("Why would you ever want to be stationed at Bragg...OK, french it is");
                French Rhett = new French();
                string rhettLang = Rhett.AssignLanguage();
            }
            else if (location == "3")
            {
                Console.WriteLine("Campbell is better than Bragg, but still pretty awful.  Arabic it is");
                Arabic Hank = new Arabic();
               string hankLang = Hank.AssignLanguage();
            }
            else if (location == "4")
            {
                Console.WriteLine("Finally someone gets it. Spanish for you");
                Spanish Tobin = new Spanish();
                string tobinLang = Tobin.AssignLanguage();
            }
            Console.WriteLine("Congrats on Graduating the Q course.  Lets get you out to Group to start your career");
            Console.Write("Remind me again what your language was? ");
            string languageGroup = Console.ReadLine();
            Console.Write("What was your desired location? ");
            string locationPref = Console.ReadLine();
            SFGroup.AssignGroup(locationPref, languageGroup);
            ThirdGroup Chaz = new ThirdGroup();
            FifthGroup Rey = new FifthGroup();
            SeventhGroup Ray = new SeventhGroup();
            TenthGroup Parker = new TenthGroup();

            if (languageGroup == "spanish")
            {
                Console.WriteLine(Ray.AssignBase());
                Console.WriteLine(Ray.AOR());
            }
            else if (languageGroup == "russian")
            {
                Console.WriteLine(Parker.AssignBase());
                Console.WriteLine(Parker.AOR());
            }
            else if (languageGroup == "french")
            {
                Console.WriteLine(Chaz.AssignBase());
                Console.WriteLine(Chaz.AOR());
            }
            else if (languageGroup == "arabic")
            {
                Console.WriteLine(Rey.AssignBase());
                Console.WriteLine(Rey.AOR());
            }
        }
    }
}
