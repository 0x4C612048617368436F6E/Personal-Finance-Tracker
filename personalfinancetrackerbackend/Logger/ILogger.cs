namespace personalfinancetrackerbackend.Logger
{
    internal interface ILogger
    {
        void Log(string message, string logTag="info");
    }
}
