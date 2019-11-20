namespace HelloAzure.BusinessLogic
{
    public class GreetingService
    {
        public string GetGreeting(string name)
            => $"Hello, {name}";
    }
}
