namespace EightToTen.Services
{
    public class GuessItService
    {
        private readonly Random _rng = new();

        public string GuessNumber(string guess, int max)
        {
            // Data Validation: Is it a real number?
            if (!int.TryParse(guess, out int userNum))
            {
                return "Invalid input. Please enter a valid number.";
            }

            // Data Validation: Is it within range?
            if (userNum < 1 || userNum > max)
            {
                return $"Please guess a number between 1 and {max}.";
            }

            // Generate Random Target
            int target = _rng.Next(1, max + 1);

            if (userNum == target)
            {
                return $"You guessed {userNum}. The hidden number was {target}. YOU WIN!";
            }
            else if (userNum > target)
            {
                return $"You guessed {userNum}. The hidden number was {target}. Too High!";
            }
            else
            {
                return $"You guessed {userNum}. The hidden number was {target}. Too Low!";
            }
        }
    }
}