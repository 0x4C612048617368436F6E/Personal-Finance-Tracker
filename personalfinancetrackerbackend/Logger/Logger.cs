namespace personalfinancetrackerbackend.Logger
{
    internal class Logger:ILogger
    {
        public void Log(string message, string logTag = "info")
        {
            if(logTag == "info")
            {
                Console.WriteLine(string.Concat("INFO - ", message));
            }
            else if(logTag == "warning")
            {
                Console.WriteLine(string.Concat("INFO - ", message))
            }
            else if(logTag == "error")
            {
                Console.WriteLine(string.Concat("INFO - ", message))
            }
            else
            {
                //Not accepted, 
            }
        }
    }
}
