namespace PasswordGenerator
{
    internal class Generate
    {
        public static readonly Random Random = new();
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
            return Rng(0,10);
        }
        public static string WriteRandomSpecialCharacter()
        {
            string[] specialChars = {"!","-","_","¤","%","&","?","£","$","€"};
            return specialChars[Rng(0, specialChars.Length)];
        }

        private static char GetRandomLetter(int min, int max)
        {
            return (char)Rng(min, max);
        }

        public static int Rng(int min, int max)
        { 
            return Random.Next(min, max);
        }
    }
}
