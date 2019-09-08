namespace EmployeeManagement
{
    internal class Login : ILogin
    {
        private const string username = nameof(username);
        private const string pwd = nameof(pwd);
        public string userName { get; set; }
        public string password { get; set; }

        public bool SignIn()
        {
            if (!string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(password))
            {
                return isUserExists(userName, password);
            }
            else
            {
                return false;
            }
        }

        public  bool isUserExists(string userName, string password)
        {
            return userName == username && password == pwd; 
        }
    }
}
