namespace EmployeeManagement
{
    internal interface ILogin
    {
        /// <summary>
        /// Gets and sets username
        /// </summary>
         string userName { get; set; }

        /// <summary>
        /// Gets and sets password
        /// </summary>
        string password { get; set; }

        /// <summary>
        /// Validates user credentials
        /// </summary>
        bool SignIn();

    }
}
