using System;
using ActionsBuilder.GitHub;

namespace ActionsBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = GitHubActionBuilder
                .Configure()
                .WithName("My workflow name")
                .OnBranch("main")
                .WithJob("Build and deploy", x =>
                {
                    x.Key = "MyEnvVar";
                    x.Value = "MyValue";
                })
                .RunsOn("ubuntu-latest")
                .AddStep("Setup .NET", "actions/setup-dotnet@v1")
                    .With(x =>
                    {
                        x.Key = "dotnet-version";
                        x.Value = "5.0.x";
                    })
                .AddStep("Add GitHub Packages Source", "dotnet nuget add source ...")
                .AddStep("Build with dotnet", "dotnet build ...")
                .Build("main-workflow.yml");
        }
    }
}