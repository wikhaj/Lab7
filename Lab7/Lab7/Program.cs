namespace Lab7
{
    internal static class Program
    {
        public static List<Book> book_list = new List<Book>();
        public static List<User> user_list = new List<User>();

        public static int UserId = 0;
        public static int BookId = 0;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}