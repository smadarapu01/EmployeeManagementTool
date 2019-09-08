using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class Program
    {
        private const string username = nameof(username);
        private const string pwd = nameof(pwd);
        static void Main(string[] args)
        {
            Console.WriteLine("Login process started");
            ILogin login = new Login();
            login.userName = username;
            login.password = pwd;
            if (login.SignIn())
            {
                Console.WriteLine("Logged in successfull");
            }
            else
            { Console.WriteLine("Login failed."); }
            Console.ReadLine();
        }
    }
}
