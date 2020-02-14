using CommandDotNet;

namespace GodfatherCharacters
{
    class Program
    {
        static int Main(string[] args)
        {
            AppRunner<GodfatherChars> appRunner = new AppRunner<GodfatherChars>();
            return appRunner.Run(args);
        }
    }
}
