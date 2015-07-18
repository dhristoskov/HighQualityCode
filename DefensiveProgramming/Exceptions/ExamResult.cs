using System;

namespace Exceptions
{
    public class ExamResult
    {
        private int _grade;
        private int _minGrade;
        private int _maxGrade;
        private string _comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Grade = grade;
            this.Comments = comments;
        }

        public int Grade
        {
            get { return this._grade; }
            private set
            {
                if (value < this.MinGrade || value > this.MaxGrade)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Grade must be between {0} and {1}!",
                        this.MinGrade, this.MaxGrade));
                }
                this._grade = value;
            }
        }

        public int MinGrade
        {
            get { return this._minGrade; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(_minGrade), "MinGrade can not be less than zero!");
                }
                this._minGrade = value;
            }
        }

        public int MaxGrade
        {
            get { return this._maxGrade; }
            private set
            {
                if (value <= this.MinGrade)
                {
                    throw new ArgumentOutOfRangeException(nameof(_maxGrade), "MaxGrade must be greater than MinGrade!");
                }
                this._maxGrade = value;
            }
        }

        public string Comments
        {
            get { return this._comments; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Comments can not be null or empty string!");
                }
                this._comments = value;
            }
        }

        public double CalculateExamResults()
        {
            var examResult = (double) (this.Grade - this.MinGrade)/(this.MaxGrade - this.MinGrade);
            return examResult;
        }

    }
}
