using System;

namespace ActionsBuilder.GitHub
{
    public class GitHubActionBuilder :
        IWorkflow,
        IWorkflowName,
        IBranchName,
        IJobName,
        IRunsOn,
        IStep,
        IStepWith,
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

        IJobName IBranchName.WithJob(string name, Action<KeyValue> env)
        {
            return this;
        }

        public IRunsOn WithJob(string name, Action<KeyValue> env = null)
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

        public IStepWith With(Action<KeyValue> config)
        {
            return this;
        }

        public IBuild Build(string fileName = "workflow.yml")
        {
            return this;
        }

        IStep IStep.AddStep(string name, string run)
        {
            return this;
        }

        public IStep AddStep(string name, string run)
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
        public IJobName WithJob(string name, Action<KeyValue> env = null);
    }

    public interface IJobName
    {
        public IRunsOn WithJob(string name, Action<KeyValue> env = null);
        public IRunsOn RunsOn(string name);
    }

    public interface IRunsOn
    {
        public IStep AddStep(string name, string run);
    }

    public interface IStep
    {
        public IStep AddStep(string name, string run);
        public IStepWith With(Action<KeyValue> config);
        public IBuild Build(string fileName = "workflow.yml");
    }

    public interface IStepWith
    {
        public IStep AddStep(string name, string run);
    }

    public interface IBuild
    {
    }

    public class KeyValue
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}