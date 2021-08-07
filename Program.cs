using System;
using ActionsBuilder.GitHub;

namespace ActionsBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var workflow = GitHubActionBuilder
                .Configure()
                .WithName("My workflow name")
                .OnBranch("main")
                .RunsOn("ubuntu-latest")
                .AddStep("Setup .NET", "actions/setup-dotnet@v1")
                .Build();
        }
    }
}
