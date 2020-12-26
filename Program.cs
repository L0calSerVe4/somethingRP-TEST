using System;
using DiscordRPC;

namespace something
{
    
    public class RPC
{
    public DiscordRpcClient client;
            public void Initialize(string state, string details, string LIT, string SIT) 
            {
                client = new DiscordRpcClient("619183056636477466");			
                
                client.Initialize();

                client.SetPresence(new RichPresence()
                {
                    Details = details,
                    State = state,
                    Assets = new Assets()
                    {
                        LargeImageKey = "chill_zone",
                        LargeImageText = LIT,
                        SmallImageKey = "c_sharp",
                        SmallImageText = SIT
                    },
                    Timestamps = Timestamps.Now
                });
            } 

}
    class Program
    {
        public static void Main(string[] args)
        {
            RPC b = new RPC();
            // string SITT = null;
            // string LITT = null;
            // string statet = null;
            // string detailst = null;
            Console.Clear();
            Console.Title = "Something RP Test";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Something RP Test || .Net Framework v4.8");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("'I don't know how i made this' - NickSaltFoxu");
            Console.ForegroundColor = ConsoleColor.White;

            bool[] argTaken = new bool[2] {false, false};
            for (int i = 0; i < args.Length; i++)
            {
                string _arg = args[i].ToLower();
                if (args.Length > i)
                {
                    if (_arg.Equals("--help") || _arg.Equals("-h"))
                    {
                        Console.WriteLine("something.exe [-h || --help  ==  Help] [--test  ==  RPC Test]");
                        return;
                    }
                    else if (_arg.Equals("--test"))
                    {
                        b.Initialize("C# Example", "Running from CMD", "Something RP Test", ".Net Framework v4.8");
                        Console.WriteLine("Ready!");
                        Console.WriteLine("To stop app press CTRL+C");
                        while(true){
                            System.Threading.Thread.Sleep(5000);
                        }
                    }
                }
            }
            if (argTaken[0]){}
            else
            {
                Console.WriteLine("\nUsage:");
                Console.WriteLine("something.exe [-h || --help  ==  Help] [--test  ==  RPC Test]");
                return;
            }
        }
        
        
    }
}
