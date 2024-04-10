using Azure.Identity;

namespace ConsoleAppProject;

public class Program
{
    public async static Task Main()
    {
        try
        {
            Console.Out.WriteLine("Generating token...\n");

            InteractiveBrowserCredential cred = new();

            var accessToken = await cred.GetTokenAsync(new([
                // App Scope(s)
                "api://406fd5b9-0a41-4604-8d96-d12c83778971/Data.Read"
            ]));

            Console.Out.WriteLine(accessToken.Token);
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex.ToString());
        }
    }
}
