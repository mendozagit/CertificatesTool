namespace CertificatesTool
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                if (File.Exists("files.json"))
                    File.Delete("files.json");
            }
            catch
            {
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
