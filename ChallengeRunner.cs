using System;
using System.Threading.Tasks;

namespace ChallengeRunner
{
    public interface IChallenge
    {
        string ChallengeDescription {get;}
        string Answer {get;}
    }
    public enum UserAction
    {
        Day1, Day2, Day3, Exit
    }
}

