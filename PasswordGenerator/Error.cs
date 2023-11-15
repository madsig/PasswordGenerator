namespace PasswordGenerator
{
    internal class Error
    {
        public static bool IsValid(string[] args)
        {
            if (args.Length != 2) return false;

            foreach (var c in args[0])
            {
                if (!char.IsDigit(c)) return false;
            }

            var allowedChars = args[1].All(c => c is 'L' or 'l' or 'd' or 's');
            if (!allowedChars) return false;

            return true;
        }

        public static void ShowHelpText()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Feil parameter");
            Console.ResetColor();
            Console.WriteLine("PasswordGenerator  \r\nOptions:\r\n- l = liten bokstav\r\n- L = stor bokstav\r\n- d = siffer\r\n- s = spesialtegn (!\"#\u00a4%&/(){}[]\r\nEksempel: PasswordGenerator 14 lLssdd\r\n    betyr\r\n        Min. 1 liten bokstav\r\n        Min. 1 1 stor bokstav\r\n        Min. 2 spesialtegn\r\n        Min. 2 sifre\r\n        Lengde på passordet skal være 14");
        }
    }
}
