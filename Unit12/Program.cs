using System;
using System.Collections.Generic;
using System.Threading;

namespace Unit12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            users.Add(new User { Name = "Ольга", Login = "OlgaD", IsPremium = true }) ;
            users.Add(new User { Name = "Павел", Login = "PavelM", IsPremium = false });
            users.Add(new User { Name = "Анна", Login = "AnnaF", IsPremium = false });
            users.Add(new User { Name = "Ирина", Login = "IrinaE", IsPremium = true });

            foreach(User aUser in users)
            {
                Console.WriteLine();
                Console.WriteLine($"Привет, {aUser.Name}!");

                if(!aUser.IsPremium)
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

            Console.ReadKey();
        }
    }
}
