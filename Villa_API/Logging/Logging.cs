namespace Villa_API.Logging
{
    public class Logging : ILogging
    {
        public void Log(string message, string type)
        {
            if (type == "error")
            {
                Console.WriteLine("Error - "+ message);
            }else if (type == "info")
            {
                Console.WriteLine("Infor - "+ message);
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
