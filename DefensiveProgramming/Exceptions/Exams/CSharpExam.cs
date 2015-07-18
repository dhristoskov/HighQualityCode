using System;

namespace Exceptions.Exams
{
    public class CSharpExam : Exam
    {
        private const int MinGrade = 0;
        private const int MaxGrade = 100;
        private int _score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get { return this._score; }
            private set
            {
                if (this.Score < MinGrade || this.Score > MaxGrade)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Score must be between {0} and {1}!",
                        MinGrade, MaxGrade));
                }
                this._score = value;
            }
        }

        public override ExamResult Check()
        {
            var examResults = new ExamResult(this.Score, MinGrade, MaxGrade, "Exam results calculated by score.");
            return examResults;
        }
    }
}
