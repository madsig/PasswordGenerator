namespace PasswordGenerator
{
    internal class Generate
    {
        public static char WriteRandomLowerCaseLetter()
        {
            return GetRandomLetter(97, 123);
        }
        public static char WriteRandomUpperCaseLetter()
        {
            return GetRandomLetter(65, 91);
        }
        public static int WriteRandomDigit()
        {
            return rng(0,10);
        }
        public static string WriteRandomSpecialCharacter()
        {
            string[] specialChars = {"!","-","_","¤","%","&","?","£","$","€"};
            return specialChars[rng(0, specialChars.Length)];
        }

        private static char GetRandomLetter(int min, int max)
        {
            return (char)rng(min, max);
        }

        public static int rng(int min, int max)
        { 
            var Random = new Random();
            return Random.Next(min, max);
        }
    }
}
