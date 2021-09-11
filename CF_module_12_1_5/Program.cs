using System;
using System.Threading;

namespace CF_module_12_1_5
{
    class Program
    {
        static void Main(string[]args)
        {
			User user = new User();
			user.Login = "abc";
			user.Name = "John";
			user.IsPremium = true;

			Console.WriteLine("{0} здравствуйте!", user.Name);
			if (user.IsPremium)
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
	}
}
