namespace PasswordGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (!Error.IsValid(args))
            {
                Error.ShowHelpText();
                return;
            }

            var length = int.Parse(args[0]);
            var pattern = args[1];
            while (pattern.Length < length) pattern += 'l';

            Console.WriteLine($"input lengde: {pattern.Length}");
            Console.WriteLine($"input: {pattern}"); 
            
            var password = "";
            while (pattern.Length > 0)
            {
                var randomIndex = Generate.Rng(0, pattern.Length);

                password += pattern[randomIndex] switch
                {
                    'l' => Generate.WriteRandomLowerCaseLetter(),
                    'L' => Generate.WriteRandomUpperCaseLetter(),
                    'd' => Generate.WriteRandomDigit(),
                    's' => Generate.WriteRandomSpecialCharacter(),
                    _ => ' ',
                };

                pattern = pattern.Remove(randomIndex, 1);
            }
            Console.WriteLine("Her er ditt passord:");
            Console.WriteLine(password);
        }
    }
}