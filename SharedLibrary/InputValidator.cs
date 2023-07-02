namespace SharedLibrary
{
    public static class InputValidator
    {
        // Method to validate the option input
        public static void ValidateOptionInput(ref char input)
        {
            char inputToUpperCase = char.ToUpper(input);
            while (!char.IsLetter(inputToUpperCase) || (inputToUpperCase != 'A' && inputToUpperCase != 'B' && inputToUpperCase != 'C' && inputToUpperCase != 'D'))
            {
                Console.WriteLine("Wrong input type, please select one option A-D \n");
                inputToUpperCase = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine("\n");
            }
        }
    }
}