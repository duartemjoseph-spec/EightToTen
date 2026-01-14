namespace EightToTen.Services
{
    public class Magic8BallService
    {
        private readonly List<string> _responses = new()
        {
            "It is certain.",
            "Without a doubt.",
            "Yes - definitely.",
            "Reply hazy, try again.",
            "Ask again later.",
            "Don't count on it.",
            "My reply is no.",
            "Outlook not so good."
        };

        public string GetPrediction(string question)
        {
            
            var random = new Random();
            int index = random.Next(_responses.Count);
            return _responses[index];
        }
    }
}