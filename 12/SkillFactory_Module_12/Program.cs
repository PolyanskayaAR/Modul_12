using System;
using System.Threading;

namespace SkillFactory_Module_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] listOfUsers = new User[5];  // Создаем список пользователей
            listOfUsers[0] = new User() { Login = "First", Name = "FirstName", IsPremium = true};
            listOfUsers[1] = new User() { Login = "Second", Name = "SecondName", IsPremium = false };
            listOfUsers[2] = new User() { Login = "Third", Name = "ThirdName", IsPremium = false };
            listOfUsers[3] = new User() { Login = "Fourth", Name = "FourthName", IsPremium = true };
            listOfUsers[4] = new User() { Login = "Fifth", Name = "FifthName", IsPremium = false };

            Console.Write("Enter your login: ");  
            string userLogin = Console.ReadLine();
            bool member = false;

            for (int i = 0; i < listOfUsers.Length; i++) 
            {
                if (listOfUsers[i].Login == userLogin)
                {
                    Console.WriteLine($"Hello, {listOfUsers[i].Name}!");
                    member = true;
                    if (listOfUsers[i].IsPremium == false) 
                        ShowAds();
                    break;
                }
             }

            if (!member)                     
            {
                Console.WriteLine($"There is no \"{userLogin}\" login. Please subscribe.");
                ShowAds();
            }
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            Thread.Sleep(3000);
        }
    }

    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }
}
