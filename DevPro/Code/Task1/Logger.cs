namespace DevPro.Code.Task1;
#region Task Description
/*
    Task 1: Logger

    Context: Your team is working on a project where you need to log various events and errors.
    You are asked to create a simple logging function that writes messages to a text file with a timestamp.

    Example usage:
    log_message("application.log", "User logged in", "INFO")
    log_message("application.log", "Failed login attempt", "WARNING")

   Expected Output in application.log:
   [2023-04-24 12:34:56] [INFO] User logged in
   [2023-04-24 12:35:10] [WARNING] Failed login attempt
 */
#endregion
public class Logger
{
    public void log_message(string fileName, string information, LogsEnum logType)
    {
        Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd hh:mm:ss}] [{logType.ToString().ToUpper()}] [{information}]");
        log_message_into_file(fileName, information, logType);
    }
    private void log_message_into_file(string fileName, string information, LogsEnum logType)
    {
        var path = $@"../../../Code/Task1/logs/{fileName}";
        using var sw = File.AppendText(path);
        sw.WriteLine($"[{DateTime.Now:yyyy-MM-dd hh:mm:ss}] [{logType.ToString().ToUpper()}] [{information}]");
        sw.Close();
    }
}