using System;

namespace UserManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== User Management System ===");

            var manager = new UserManager();
            manager.AddUser("Alice");
            manager.AddUser("Bob");

            Console.WriteLine("Пользователи добавлены.");

            // Тест удаления (Задание 3.2)
            Console.WriteLine($"Удаление 'Bob': {manager.RemoveUser("Bob")}"); // True
            Console.WriteLine($"Удаление 'Bob': {manager.RemoveUser("Bob")}"); // False

            Console.ReadLine();
        }
    }
}
