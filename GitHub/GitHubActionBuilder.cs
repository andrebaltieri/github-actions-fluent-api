namespace ActionsBuilder.GitHub
{
    public class GitHubActionBuilder :
        IWorkflow,
        IWorkflowName,
        IBranchName,
        IJobName,
        IRunsOn,
        IStep,
        IBuild
    {
        private GitHubActionBuilder()
        {
        }

        public static IWorkflow Configure()
        {
            return new GitHubActionBuilder();
        }

        public IWorkflowName WithName(string name)
        {
            return this;
        }

        public IBranchName OnBranch(string name)
        {
            return this;
        }

        IJobName IBranchName.WithJob(string name, EnvironmentConfiguration env)
        {
            return this;
        }

        public IRunsOn WithJob(string name, EnvironmentConfiguration env = null)
        {
            return this;
        }

        public IRunsOn RunsOn(string name)
        {
            return this;
        }

        IStep IRunsOn.AddStep(string name, string run)
        {
            return this;
        }

        public IBuild Build()
        {
            return this;
        }

        IStep IStep.AddStep(string name, string run)
        {
            return this;
        }
    }

    public interface IWorkflow
    {
        public IWorkflowName WithName(string name);
    }

    public interface IWorkflowName
    {
        public IBranchName OnBranch(string name);
    }

    public interface IBranchName
    {
        public IJobName WithJob(string name, EnvironmentConfiguration env = null);
    }

    public interface IJobName
    {
        public IRunsOn WithJob(string name, EnvironmentConfiguration env = null);
        public IRunsOn RunsOn(string name);
    }

    public interface IRunsOn
    {
        public IStep AddStep(string name, string run);
    }

    public interface IStep
    {
        public IStep AddStep(string name, string run);
        public IBuild Build();
    }

    public interface IBuild
    {
    }

    public class EnvironmentConfiguration
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}