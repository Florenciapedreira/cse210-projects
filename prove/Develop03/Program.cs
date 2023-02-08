public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Memorizer Scripture");
            let frase = ("Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight. (Proverbs 3:5-6)");
            Console.log(frase);

            frase = frase.replace("Trust in the Lord" , "_____ in the ____");
            Console.log(frase);

            frase = frase.replace("Trust in the Lord with all your heart" , "_____ in the ____ with all ____ _____");
            Console.log(frase);

            frase = frase.replace("Trust in the Lord with all your heart and lean not on your own understanding;" , "_____ in the ____ with all ____ _____ and ____ ___ on your own ____________;");
            Console.log(frase);

            frase = frase.replace("Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him," , "_____ in the ____ with all ____ _____ and ____ ___ on your own ____________; in all your ____ submit to ___,");
            Console.log(frase);

            frase = frase.replace("Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight. (Proverbs 3:5-6)" , "_____ in the ____ with all ____ _____ and ____ ___ on your own ____________; in all your ____ submit to ___, and he ____ ____ your paths ________. (Proverbs 3:5-6)");
            Console.log(frase);

            frase = frase.replace("Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight. (Proverbs 3:5-6)" , "_____ in ___ ____ with all ____ _____ and ____ ___ on ____ own ____________; in ___ your ____ ______ to ___, and he ____ ____ your paths ________. (Proverbs 3:5-6)");
            Console.log(frase);

            frase = frase.replace("Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight. (Proverbs 3:5-6)" , "_____ in ___ ____ ____ all ____ _____ and ____ ___ on ____ ___ ____________; in ___ your ____ ______ to ___, and __ ____ ____ your _____ ________. (Proverbs 3:5-6)");
            Console.log(frase);

            frase = frase.replace("Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight. (Proverbs 3:5-6)" , "_____ __ ___ ____ ____ ___ ____ _____ ___ ____ ___ __ ____ ___ ____________; __ ___ ____ ____ ______ __ ___, ___ __ ____ ____ ____ _____ ________. (Proverbs 3:5-6)");
            Console.log(frase);
            
        }
    }
    