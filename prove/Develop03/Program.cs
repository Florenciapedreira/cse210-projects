public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Memorizer Scripture");
            Console.WriteLine();
            string frase = ("Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight. (Proverbs 3:5-6)");
            Console.WriteLine("Original: {0}", frase);
            Console.WriteLine();
            Console.WriteLine("Press enter to start!");
            Console.ReadLine();

            string replace = frase.Replace("Trust in the Lord" , "_____ in the ____");
            Console.WriteLine("Replace: {0}", replace);
            Console.ReadLine();

            string replace2 = frase.Replace("Trust in the Lord with all your heart and lean not on your own understanding;" , "_____ in the ____ with all ____ _____ and ____ ___ on your own ____________;");
            Console.WriteLine("Replace: {0}", replace2);
            Console.ReadLine();

            string replace3 = frase.Replace("Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him," , "_____ in the ____ with all ____ _____ and ____ ___ on your own ____________; in all your ____ submit to ___,");
            Console.WriteLine("Replace: {0}", replace3);
            Console.ReadLine();

            string replace4 = frase.Replace("Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight. (Proverbs 3:5-6)" , "_____ in the ____ with all ____ _____ and ____ ___ on your own ____________; in all your ____ submit to ___, and he ____ ____ your paths ________. (Proverbs 3:5-6)");
            Console.WriteLine("Replace: {0}", replace4);
            Console.ReadLine();

            string replace5 = frase.Replace("Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight. (Proverbs 3:5-6)" , "_____ in ___ ____ with all ____ _____ and ____ ___ on ____ own ____________; in ___ your ____ ______ to ___, and he ____ ____ your paths ________. (Proverbs 3:5-6)");
            Console.WriteLine("Replace: {0}", replace5);
            Console.ReadLine();

            string replace6 = frase.Replace("Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight. (Proverbs 3:5-6)" , "_____ in ___ ____ ____ all ____ _____ and ____ ___ on ____ ___ ____________; in ___ your ____ ______ to ___, and __ ____ ____ your _____ ________. (Proverbs 3:5-6)");
            Console.WriteLine("Replace: {0}", replace6);
            Console.ReadLine();

            string replace7 = frase.Replace("Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight. (Proverbs 3:5-6)" , "_____ __ ___ ____ ____ ___ ____ _____ ___ ____ ___ __ ____ ___ ____________; __ ___ ____ ____ ______ __ ___, ___ __ ____ ____ ____ _____ ________. (Proverbs 3:5-6)");
            Console.WriteLine("Replace: {0}", replace7);
            Console.ReadLine();
            

            
        }
    }
    