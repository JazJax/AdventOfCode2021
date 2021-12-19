using System;
using System.Threading.Tasks;

namespace ChallengeRunner
{
    public abstract class Challenge
    {
        public abstract string ChallengeDescription { get;}
        public string Answer
        {
            get { return Run();}
        }

        protected abstract string Run();
    }
    public enum UserAction
    {
        Day1, Day2, Day3, Exit
    }
}

