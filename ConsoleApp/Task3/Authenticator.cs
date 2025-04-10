namespace ConsoleApp.Task3
{
    internal class Authenticator
    {
        private static Authenticator instance = null;
        private static readonly object lockObject = new object();

        public string Username { get; private set; }
        public string Password { get; private set; }

        private Authenticator(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public static Authenticator Instance(string username = null, string password = null)
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Authenticator(username, password);
                    }
                }
            }
            return instance;
        }

        public bool Authenticate(string username, string password)
        {
            return Username == username && Password == password;
        }
    }
}
