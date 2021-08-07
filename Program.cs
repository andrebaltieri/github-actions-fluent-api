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
                .WithJob("Build and deploy", new()
                {
                    Key = "MyEnvVar",
                    Value = "MyValue"
                })
                .RunsOn("ubuntu-latest")
                .AddStep("Setup .NET", "actions/setup-dotnet@v1")
                .AddStep("","")
                .AddStep("", "")
                .Build();
        }
    }
}
