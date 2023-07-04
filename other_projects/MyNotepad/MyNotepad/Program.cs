namespace MyNotepad
{
    public class Program
    {

        FileOperation fileOperation;

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMyNotepadForm());
        }
    }
}