namespace RandomPasswordGenerationAndEmailSending.Service
{
    public static class GeneratePasswordRandomService
    {
        public static string GenerateRandomPassword()
        {
            var length = 10;
            const string allowedCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%&*()";

            Random random = new Random();

            string generatedPassword = new string(Enumerable.Repeat(allowedCharacters, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return generatedPassword;
        }
    }
}