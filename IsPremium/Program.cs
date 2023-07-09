using IsPremium;

var users = new List<User>()
{
    new User("test1", "Test", true),
    new User("tug1", "Petr", false),
    new User("asdf23", "Vasiliy", false)
};

foreach (var user in users)
{
    Console.WriteLine($"Привет, " + user.Name);
    isPremium(user);
}
Console.ReadLine();

static void isPremium(User user)
{
    if (user.IsPremium == false)
    {
        ShowAds();
    }
}
static void ShowAds()
{
    Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
    // Остановка на 1 с
    Thread.Sleep(1000);

    Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
    // Остановка на 2 с
    Thread.Sleep(2000);

    Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
    // Остановка на 3 с
    Thread.Sleep(3000);
}