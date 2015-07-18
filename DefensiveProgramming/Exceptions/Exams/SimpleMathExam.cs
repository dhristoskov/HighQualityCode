using System;

namespace Exceptions.Exams
{
    public class SimpleMathExam : Exam
    {
        private const int MinGrade = 2;
        private const int MaxGrade = 6;

        private const int MinProblemSolved = 0;
        private const int MaxProblemSolved = 2;

        private int _problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get { return this._problemsSolved; }
            private set
            {
                if (value < MinProblemSolved || value > MaxProblemSolved)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Solved Problems must be between {0} and {1}!",
                        MinProblemSolved, MaxProblemSolved));
                }
                this._problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            if (this.ProblemsSolved == MinProblemSolved)
            {
                return new ExamResult(MinGrade, MinGrade, MaxGrade, "Bad result: nothing done.");
            }
            if (this.ProblemsSolved == 1)
            {
                return new ExamResult(4, MinGrade, MaxGrade, "Average result: nothing done.");
            }
            if (this.ProblemsSolved == MaxProblemSolved)
            {
                return new ExamResult(MaxGrade, MinGrade, MaxGrade, "Average result: nothing done.");
            }

            throw new ArgumentOutOfRangeException("Incorrect simple math exam data!");
        }
    }
}
