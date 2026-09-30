using System.Collections.Generic;

namespace UserManagementSystem
{
    /// <summary>
    /// Класс для управления списком пользователей.
    /// </summary>
    public class UserManager
    {
        private List<string> _users = new List<string>();

        /// <summary>
        /// Добавить пользователя в список.
        /// </summary>
        public void AddUser(string username)
        {
            _users.Add(username);
        }
    }
}
