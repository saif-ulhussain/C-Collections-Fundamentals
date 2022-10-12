class Example
{
    static void Main(string[] args)
    {
        var FavouriteSport = new List<string>
        {
            "Football",
            "Tennis",
            "Rugby"
        };

        FavouriteSport.Add("Snooker");
        FavouriteSport.Remove("Rugby");

        foreach (string sport in FavouriteSport)
        {
            Console.WriteLine(sport);
        }

    }
}
