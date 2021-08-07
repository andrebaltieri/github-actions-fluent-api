namespace ActionsBuilder.GitHub
{
    public class GitHubActionBuilder : IWorkflow, IWorkflowName, IBranchName, IRunsOn, IStep, IBuild
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

        public IRunsOn RunsOn(string name)
        {
            return this;
        }
        
        public IStep AddStep(string name, string run)
        {
            return this;
        }

        public IBuild Build()
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
        public IRunsOn RunsOn(string name);
    }

    public interface IRunsOn
    {
        public IStep AddStep(string name, string run);
    }

    public interface IStep
    {
        public IBuild Build();
    }

    public interface IBuild
    {
    }
}